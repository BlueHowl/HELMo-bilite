using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HELMo_bilite.Data;
using HELMo_bilite.Models;

namespace HELMo_bilite.Controllers
{
    public class DispatchersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DispatchersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dispatchers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Dispatchers.Include(d => d.Certification);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Dispatchers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Dispatchers == null)
            {
                return NotFound();
            }

            var dispatcher = await _context.Dispatchers
                .Include(d => d.Certification)
                .FirstOrDefaultAsync(m => m.Matricule == id);
            if (dispatcher == null)
            {
                return NotFound();
            }

            return View(dispatcher);
        }

        // GET: Dispatchers/Create
        public IActionResult Create()
        {
            ViewData["IdCertification"] = new SelectList(_context.Certifications, "Id", "Name");
            return View();
        }

        // POST: Dispatchers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCertification,Matricule,Name,FirstName,Email,Password")] Dispatcher dispatcher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dispatcher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCertification"] = new SelectList(_context.Certifications, "Id", "Name", dispatcher.IdCertification);
            return View(dispatcher);
        }

        // GET: Dispatchers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Dispatchers == null)
            {
                return NotFound();
            }

            var dispatcher = await _context.Dispatchers.FindAsync(id);
            if (dispatcher == null)
            {
                return NotFound();
            }
            ViewData["IdCertification"] = new SelectList(_context.Certifications, "Id", "Name", dispatcher.IdCertification);
            return View(dispatcher);
        }

        // POST: Dispatchers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdCertification,Matricule,Name,FirstName,Email,Password")] Dispatcher dispatcher)
        {
            if (id != dispatcher.Matricule)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dispatcher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DispatcherExists(dispatcher.Matricule))
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
            ViewData["IdCertification"] = new SelectList(_context.Certifications, "Id", "Name", dispatcher.IdCertification);
            return View(dispatcher);
        }

        // GET: Dispatchers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Dispatchers == null)
            {
                return NotFound();
            }

            var dispatcher = await _context.Dispatchers
                .Include(d => d.Certification)
                .FirstOrDefaultAsync(m => m.Matricule == id);
            if (dispatcher == null)
            {
                return NotFound();
            }

            return View(dispatcher);
        }

        // POST: Dispatchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Dispatchers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Dispatchers'  is null.");
            }
            var dispatcher = await _context.Dispatchers.FindAsync(id);
            if (dispatcher != null)
            {
                _context.Dispatchers.Remove(dispatcher);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DispatcherExists(string id)
        {
          return (_context.Dispatchers?.Any(e => e.Matricule == id)).GetValueOrDefault();
        }
    }
}
