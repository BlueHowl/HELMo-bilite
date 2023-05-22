using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
using HELMo_bilite.Controllers.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HELMo_bilite.Controllers
{
    public class DeliveriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public DeliveriesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Deliveries
        public async Task<IActionResult> Index()
        {
            var deliveries = _context.Deliveries
                .Include(d => d.Client)
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .Include(d => d.LoadAddress)
                .Include(d => d.UnloadingAddress);
            return View(await deliveries.ToListAsync());
        }

        // GET: Deliveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Deliveries == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries
                .Include(d => d.Client)
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .Include(d => d.LoadAddress)
                .Include(d => d.UnloadingAddress)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // GET: Deliveries/Create
        [Authorize(Roles = "client,admin")]
        public IActionResult Create()
        {
            setViewDataLists();
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "client,admin")]
        public async Task<IActionResult> Create([Bind("Content,LoadAddressId,UnloadingAddressId,LoadDate,UnloadingDate")] CreateOrderVM order)
        {
            if(order.LoadDate > order.UnloadingDate)
            {
                ModelState.AddModelError("UnloadingDate", "La date de déchargement ne peut pas être antérieur à la date de chargement !");
            }

            if(ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);

                if (currentUser is Client client)
                {
                    var loadAddress = await _context.Addresses.FindAsync(order.LoadAddressId);
                    var unloadAddress = await _context.Addresses.FindAsync(order.UnloadingAddressId);

                    var newDelivery = new Delivery
                    (
                        client,
                        null,
                        order.Content,
                        loadAddress,
                        order.LoadDate,
                        unloadAddress,
                        order.UnloadingDate,
                        "En attente",
                        null
                    );

                    _context.Add(newDelivery);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                } 
                
            }

            setViewDataLists();
            return View(order);
        }

        // GET: Deliveries/Edit/5
        //[Authorize(Roles = "dispatcher,admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Deliveries == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries.FindAsync(id);
            
            if (delivery == null)
            {
                return NotFound();
            }

            delivery.Client = await _context.Clients.FindAsync(delivery.IdClient);
            delivery.LoadAddress = await _context.Addresses.FindAsync(delivery.LoadAddressId);
            delivery.UnloadingAddress = await _context.Addresses.FindAsync(delivery.UnloadingAddressId);

            var assignOrderVM = new AssignOrderVM(
                delivery.Id, 
                delivery.ClientDetails, 
                delivery.DriverDetails,
                delivery.Content,
                delivery.LoadAddressDetails, 
                delivery.LoadDate,
                delivery.UnloadAddressDetails,
                delivery.UnloadingDate,
                delivery.Status,
                delivery.VehicleDetails);

            setViewDataLists();

            return View(assignOrderVM);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "dispatcher,admin")]
        public async Task<IActionResult> Edit(int id, [Bind("IdDriver,IdVehicle")] AssignOrderVM delivery)
        {
            var newDelivery = await _context.Deliveries
                .Include(d => d.Client)
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .Include(d => d.LoadAddress)
                .Include(d => d.UnloadingAddress)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (newDelivery == null)
            {
                return NotFound();
            }

            //TODO if(newDelivery) gerer status

            newDelivery.IdDriver = delivery.IdDriver;
            newDelivery.Driver = await _context.Drivers.FirstOrDefaultAsync(d => d.Matricule == delivery.IdDriver);

            newDelivery.IdVehicle = delivery.IdVehicle;
            newDelivery.Vehicle = await _context.Vehicles.FindAsync(delivery.IdVehicle);

            newDelivery.Status = "En cours";

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newDelivery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryExists(delivery.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            setViewDataLists();
            return View(newDelivery);
        }

        // GET: Deliveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Deliveries == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries
                .Include(d => d.Client)
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .Include(d => d.LoadAddress)
                .Include(d => d.UnloadingAddress)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // POST: Deliveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Deliveries == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Deliveries'  is null.");

            }
            var delivery = await _context.Deliveries
                .Include(d => d.Client)
                .Include(d => d.Driver)
                .Include(d => d.Vehicle)
                .Include(d => d.LoadAddress)
                .Include(d => d.UnloadingAddress)
                .FirstOrDefaultAsync(m => m.Id == id);//.FindAsync(id);

            if (delivery != null)
            {
                _context.Deliveries.Remove(delivery);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryExists(int id)
        {
            return (_context.Deliveries?.Any(e => e.Id == id)).GetValueOrDefault();
        }



        // GET: Deliveries/CreateAddress
        public IActionResult CreateAddress()
        {
            return View();
        }

        // POST: Deliveries/CreateAddress
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAddress([Bind("Street,Number,Locality,LocalityCode,Country")] CreationAddressVM address)
        {
            if (ModelState.IsValid)
            {
                var newAddress = new Address(address.Locality, address.Number.ToString(), address.Street, address.LocalityCode.ToString(), address.Country);

                _context.Addresses.Add(newAddress); //TODO peut être simplifié _context.Add(newAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }

            return View(address);
        }



        private void setViewDataLists()
        {
 
            List<SelectListItem> clientList = _context.Clients.Select(c => new SelectListItem
            {
                Value = c.Id,
                Text = $"{c.CompanyName} {c.Email}"
            }).ToList();

            List<SelectListItem> driverList = _context.Drivers.Select(d => new SelectListItem
            {
                Value = d.Matricule.ToString(),
                Text = $"{d.FirstName} {d.Name} ({(d.Licenses.Count > 0 ? string.Join(",", d.Licenses.Select(l => l.Name).ToList()) : "Sans permi")})"
            }).ToList();

            List<SelectListItem> vehiculeList = _context.Vehicles.Select(v => new SelectListItem
            {
                Value = v.VIN.ToString(),
                Text = $"{v.Brand} {v.Model}, {v.VIN}"
            }).ToList();

            List<SelectListItem> addressList = _context.Addresses.Select(a => new SelectListItem
            {
                Value = a.IdAddress,
                Text = $"{a.Street} {a.Number}, {a.Locality} {a.LocalityCode}"
            }).ToList();

            ViewData["Clients"] = clientList;
            ViewData["Drivers"] = driverList;
            ViewData["Vehicles"] = vehiculeList;
            ViewData["Addresses"] = addressList;
        }

    }
}
