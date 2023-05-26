using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
using HELMo_bilite.Controllers.ViewModels;
using Microsoft.AspNetCore.Authorization;
using static HELMo_bilite.Models.Delivery;

namespace HELMo_bilite.Controllers
{
    [Authorize(Roles = "admin")]
    public class DriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DriversController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Drivers
        public async Task<IActionResult> Index()
        {
            return _context.Drivers != null ?
                        View(await _context.Drivers.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Drivers'  is null.");
        }

        // GET: Drivers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Drivers == null)
            {
                return NotFound();
            }

            var driver = await _context.Drivers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // GET: Drivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Matricule,Name,FirstName,Id,Email,UserName")] Driver driver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(driver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(driver);
        }

        // GET: Drivers/Edit/5
        /// <summary>
        /// ici on utilise le matricule comme id
        /// car l'id est un GUID et on ne peut pas le modifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Drivers == null)
            {
                return NotFound();
            }

            var driver = await _context.Drivers.Include(d => d.Licenses)
                .FirstOrDefaultAsync(m => m.Matricule == id);

            if (driver == null)
            {
                return NotFound();
            }
            driver.Licenses ??= new List<License>();


            var allLisence = await _context.Licenses.ToListAsync();

            return View(new EditDriverLicensesVM
            {
                Matricule = driver.Matricule,
                Licenses = allLisence
                           .Select(a => new SelectListItem
                           {
                               Value = "" + a.Id,
                               Text = a.Name,
                               Selected = driver.HasLicense(a.Id)
                           })
                           .ToList()
            });

        }

        // POST: Drivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,[Bind("IdsLicensesSelect")] EditDriverLicensesVM driver)
        {          
            if(driver.IdsLicensesSelect?.Count == 0)
            {
                ModelState.AddModelError("IdsLicensesSelect", "Vous devez selectionner au moins une licence");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var driverToUpdate = await _context.Drivers
                        .Include(d => d.Licenses)
                        .FirstOrDefaultAsync(m => m.Matricule == id);
                    if (driverToUpdate == null)
                    {
                        return NotFound();
                    }


                    //on trouver le plus grand id de lisence et on le coverti en int
                    var higthestLisenceId = driver.IdsLicensesSelect.Select(l => int.Parse(l))
                                                                    .OrderByDescending(l => l).FirstOrDefault();

                    

                    var lisences = _context.Licenses.ToList();
                    var lisencesDriver = new List<License>();
                    foreach (var lisence in lisences)
                    {
                        if (higthestLisenceId >= lisence.Id)
                        {
                            lisencesDriver.Add(lisence);
                        }
                    }
                    driverToUpdate.Licenses = lisencesDriver;

                    //on supprime toutes les livraison du chauffeur si le camion a un lisence non possedée par le chauffeur
                    var deliveries = _context.Deliveries.Include(d => d.Vehicle).Where(d => d.IdDriver == driverToUpdate.Id);
                    foreach (var delivery in deliveries)
                    {
                        if (!driverToUpdate.HasLicense(delivery.Vehicle.IdLicense))
                        {
                            delivery.IdDriver = null;
                            delivery.Status = State.Waiting;
                            _context.Update(delivery);
                        }
                    }
                    _context.Update(driverToUpdate);
                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {

                    if (!DriverExists(id))

                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "HelmoMembers");
            }
            return View(driver);
        }

        // GET: Drivers/Delete/5
        /*public async Task<IActionResult> Delete(string id)

        {
            if (id == null || _context.Drivers == null)
            {
                return NotFound();
            }

            var driver = await _context.Drivers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // POST: Drivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Drivers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Drivers'  is null.");
            }
            var driver = await _context.Drivers.FindAsync(id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }*/


        private bool DriverExists(string id)
        {
            return (_context.Drivers?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
