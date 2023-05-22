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
    [Authorize(Roles = "client,driver,dispatcher,admin")]
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
            setViewAddressList();
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
                        Delivery.State.Waiting,
                        null
                    );

                    _context.Add(newDelivery);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                } 
                
            }

            setViewAddressList();
            return View(order);
        }

        // GET: Deliveries/Assign/5
        [Authorize(Roles = "dispatcher,admin")]
        public async Task<IActionResult> Assign(int? id)
        {
            if (id == null || _context.Deliveries == null)
            {
                return NotFound();
            }

            var delivery = await _context.Deliveries
                .Include(d => d.Client)
                .Include(d => d.LoadAddress)
                .Include(d => d.UnloadingAddress).FirstOrDefaultAsync(d => d.Id == id);
            
            if (delivery == null)
            {
                return NotFound();
            }

            /*delivery.Client = await _context.Clients.FindAsync(delivery.IdClient);
            delivery.LoadAddress = await _context.Addresses.FindAsync(delivery.LoadAddressId);
            delivery.UnloadingAddress = await _context.Addresses.FindAsync(delivery.UnloadingAddressId);
            */
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

            setViewDataList(delivery.LoadDate, delivery.UnloadingDate);

            return View(assignOrderVM);
        }

        // POST: Deliveries/Assign/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "dispatcher,admin")]
        public async Task<IActionResult> Assign(int id, [Bind("IdDriver,IdVehicle")] AssignOrderVM delivery)
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

            if (newDelivery.Status == Delivery.State.InProgress) //theoriquement impossible d'en arriver là
            {
                ModelState.AddModelError("Status", "La commande à déjà été prise en charge !");
            }
            
            newDelivery.IdDriver = delivery.IdDriver;
            newDelivery.Driver = await _context.Drivers.Include(d => d.Licenses).FirstOrDefaultAsync(d => d.Id == delivery.IdDriver);//.FindAsync(delivery.IdDriver);

            newDelivery.IdVehicle = delivery.IdVehicle;
            newDelivery.Vehicle = await _context.Vehicles.Include(v => v.License).FirstOrDefaultAsync(v => v.VIN == delivery.IdVehicle);//.FindAsync(delivery.IdVehicle);

            newDelivery.Status = Delivery.State.InProgress;

            if(!newDelivery.Driver.Licenses.Contains(newDelivery.Vehicle.License))
            {
                ModelState.AddModelError("IdVehicle", "Le chauffeur n'a pas le permis !");
            }
            

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

            var assignOrderVM = new AssignOrderVM(
                newDelivery.Id,
                newDelivery.ClientDetails,
                newDelivery.DriverDetails,
                newDelivery.Content,
                newDelivery.LoadAddressDetails,
                newDelivery.LoadDate,
                newDelivery.UnloadAddressDetails,
                newDelivery.UnloadingDate,
                newDelivery.Status,
                newDelivery.VehicleDetails);

            setViewDataList(newDelivery.LoadDate, newDelivery.UnloadingDate);

            return View(assignOrderVM);
        }

        // GET: Deliveries/Edit/5
        [Authorize(Roles = "client")]
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

            var createOrderVM = new CreateOrderVM(
                delivery.Content,
                delivery.LoadAddressId,
                delivery.UnloadingAddressId,
                delivery.LoadDate,
                delivery.UnloadingDate
            );

            setViewAddressList();

            return View(createOrderVM);
        }

        // POST: Deliveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "client")]
        public async Task<IActionResult> Edit(int id, [Bind("Content,LoadAddressId,UnloadingAddressId,LoadDate,UnloadingDate")] CreateOrderVM order)
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

            if (order.LoadDate > order.UnloadingDate)
            {
                ModelState.AddModelError("UnloadingDate", "La date de déchargement ne peut pas être antérieur à la date de chargement !");
            }

            if (newDelivery.Status == Delivery.State.InProgress) //theoriquement impossible d'en arriver là
            {
                ModelState.AddModelError("Status", "La commande à déjà été prise en charge");
            }

            newDelivery.Content = order.Content;
            newDelivery.LoadAddressId = order.LoadAddressId;
            newDelivery.LoadAddress = await _context.Addresses.FindAsync(order.LoadAddressId);
            newDelivery.UnloadingAddressId = order.UnloadingAddressId;
            newDelivery.UnloadingAddress = await _context.Addresses.FindAsync(order.UnloadingAddressId);
            newDelivery.LoadDate = order.LoadDate;
            newDelivery.UnloadingDate = order.UnloadingDate;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newDelivery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryExists(id))
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

            setViewAddressList();
            return View(order);
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



        private void setViewAddressList()
        {
            List<SelectListItem> addressList = _context.Addresses.Select(a => new SelectListItem
            {
                Value = a.IdAddress,
                Text = $"{a.Street} {a.Number}, {a.Locality} {a.LocalityCode}"
            }).ToList();

            ViewData["Addresses"] = addressList;
        }


        private void setViewDataList(DateTime startDate, DateTime endDate)
        {

            var availableDrivers = _context.Drivers
                .Where(driver => !_context.Deliveries.Any(delivery =>
                    delivery.IdDriver == driver.Id &&
                    (delivery.LoadDate <= endDate && delivery.UnloadingDate >= startDate.AddHours(1))))
                .Select(d => new SelectListItem
                {
                    Value = d.Id,
                    Text = $"{d.FirstName} {d.Name} ({(d.Licenses.Count > 0 ? string.Join(",", d.Licenses.Select(l => l.Name).ToList()) : "Sans permi")})"
                }).ToList();


            var availableVehicles = _context.Vehicles
                .Where(v => !_context.Deliveries.Any(d =>
                    d.IdVehicle == v.VIN &&
                    (d.LoadDate <= endDate && d.UnloadingDate >= startDate.AddHours(1)))) //les véhicules on ils aussi un délai de 1h supp
                .Select(v => new SelectListItem
                {
                    Value = v.LicensePlate.ToString(),
                    Text = $"{v.Brand} {v.Model}, {v.LicensePlate} : Permis {v.License.Name}"
                }).ToList();

            ViewData["Drivers"] = availableDrivers;
            ViewData["Vehicles"] = availableVehicles;
        }

    }
}
