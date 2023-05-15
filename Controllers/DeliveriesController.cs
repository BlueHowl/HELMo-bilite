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
            var applicationDbContext = _context.Deliveries.Include(d => d.Client).Include(d => d.Driver).Include(d => d.Vehicule);
            return View(await applicationDbContext.ToListAsync());
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
                .Include(d => d.Vehicule)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (delivery == null)
            {
                return NotFound();
            }

            return View(delivery);
        }

        // GET: Deliveries/Create
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
        public async Task<IActionResult> Create([Bind("Content,LoadAddressId,UnloadingAddressId,LoadDate,UnloadingDate")] ClientOrderVM order)
        {
            if(ModelState.IsValid && order.UnloadingDate > order.LoadDate)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);

                if (currentUser is Client client)
                {
                    //TODO changer addresses + afficher message erreur si champs invalides
                    var loadAddress = await _context.Addresses.FirstOrDefaultAsync();
                    var unloadAddress = await _context.Addresses.FirstOrDefaultAsync();

                    var newDelivery = new Delivery
                    (
                        (Client)currentUser,
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

            setViewDataLists();

            return View(delivery);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdClient,IdDriver,Content,LoadAddressId,LoadDate,UnloadingAddressId,UnloadingDate,status,IdVehicule")] Delivery delivery)
        {
            if (id != delivery.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(delivery);
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
            return View(delivery);
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
                .Include(d => d.Vehicule)
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
            var delivery = await _context.Deliveries.FindAsync(id);
            if (delivery != null)
            {
                _context.Deliveries.Remove(delivery);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryExists(int id)
        {
            return (_context.Deliveries?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private void setViewDataLists()
        {
            List<SelectListItem> clientList = _context.Clients.Select(c => new SelectListItem
            {
                Value = c.Matricule.ToString(),
                Text = $"{c.FirstName} {c.Name}"
            }).ToList();

            List<SelectListItem> driverList = _context.Drivers.Select(d => new SelectListItem
            {
                Value = d.Matricule.ToString(),
                Text = $"{d.FirstName} {d.Name} ({(d.Licenses.Count > 0 ? string.Join(",", d.Licenses.Select(l => l.Name).ToList()) : "Sans permi")})"
            }).ToList();

            List<SelectListItem> vehiculeList = _context.Vehicules.Select(v => new SelectListItem
            {
                Value = v.Plate.ToString(),
                Text = $"{v.Brand} {v.Model}"
            }).ToList();

            ViewData["IdClient"] = clientList;
            ViewData["IdDriver"] = driverList;
            ViewData["IdVehicule"] = vehiculeList;
        }

    }
}
