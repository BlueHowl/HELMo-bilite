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
using Microsoft.AspNetCore.Authorization;

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

            return View(new EditDriverLisencesVM
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
        public async Task<IActionResult> Edit(string id, EditDriverLisencesVM driver)
        {          

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
                    var higthestLisenceId = int.Parse(driver.Licenses.OrderByDescending(l => l).FirstOrDefault().Value);


                    var lisences = _context.Licenses.ToList();
                    foreach (var lisence in lisences)
                    {
                        if (higthestLisenceId >= lisence.Id)
                        {
                            driverToUpdate.Licenses.Add(lisence);
                        }
                    }
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
                return RedirectToAction(nameof(Index));
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
