using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HELMo_bilite.Data;
using HELMo_bilite.Models;

namespace HELMo_bilite.Controllers
{
    public class DeliveriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveriesController(ApplicationDbContext context)
        {
            _context = context;
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
            ViewData["IdClient"] = new SelectList(_context.Clients, "Id", "Id");
            ViewData["IdDriver"] = new SelectList(_context.Drivers, "Id", "Id");
            ViewData["IdVehicule"] = new SelectList(_context.Vehicules, "Plate", "Plate");
            return View();
        }

        // POST: Deliveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdClient,IdDriver,Content,LoadAddressId,LoadDate,UnloadingAddressId,UnloadingDate,status,IdVehicule")] Delivery delivery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(delivery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdClient"] = new SelectList(_context.Clients, "Id", "Id", delivery.IdClient);
            ViewData["IdDriver"] = new SelectList(_context.Drivers, "Id", "Id", delivery.IdDriver);
            ViewData["IdVehicule"] = new SelectList(_context.Vehicules, "Plate", "Plate", delivery.IdVehicule);
            return View(delivery);
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
            ViewData["IdClient"] = new SelectList(_context.Clients, "Id", "Id", delivery.IdClient);
            ViewData["IdDriver"] = new SelectList(_context.Drivers, "Id", "Id", delivery.IdDriver);
            ViewData["IdVehicule"] = new SelectList(_context.Vehicules, "Plate", "Plate", delivery.IdVehicule);
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
            ViewData["IdClient"] = new SelectList(_context.Clients, "Id", "Id", delivery.IdClient);
            ViewData["IdDriver"] = new SelectList(_context.Drivers, "Id", "Id", delivery.IdDriver);
            ViewData["IdVehicule"] = new SelectList(_context.Vehicules, "Plate", "Plate", delivery.IdVehicule);
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
                return Problem("Entity set 'ApplicationDbContext.Delivery'  is null.");
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
    }
}
