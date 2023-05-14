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
    public class HelmoMembersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HelmoMembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HelmoMembers
        public async Task<IActionResult> Index()
        {
              return _context.HelmoMembers != null ? 
                          View(await _context.HelmoMembers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.HelmoMembers'  is null.");
        }

        // GET: HelmoMembers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HelmoMembers == null)
            {
                return NotFound();
            }

            var helmoMember = await _context.HelmoMembers
                .FirstOrDefaultAsync(m => m.Matricule == id);
            if (helmoMember == null)
            {
                return NotFound();
            }

            return View(helmoMember);
        }

        // GET: HelmoMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HelmoMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Matricule,Name,FirstName")] HelmoMember helmoMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helmoMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(helmoMember);
        }

        // GET: HelmoMembers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.HelmoMembers == null)
            {
                return NotFound();
            }

            var helmoMember = await _context.HelmoMembers.FindAsync(id);
            if (helmoMember == null)
            {
                return NotFound();
            }
            return View(helmoMember);
        }

        // POST: HelmoMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Matricule,Name,FirstName")] HelmoMember helmoMember)
        {
            if (id != helmoMember.Matricule)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(helmoMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HelmoMemberExists(helmoMember.Matricule))
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
            return View(helmoMember);
        }

        // GET: HelmoMembers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.HelmoMembers == null)
            {
                return NotFound();
            }

            var helmoMember = await _context.HelmoMembers
                .FirstOrDefaultAsync(m => m.Matricule == id);
            if (helmoMember == null)
            {
                return NotFound();
            }

            return View(helmoMember);
        }

        // POST: HelmoMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.HelmoMembers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HelmoMembers'  is null.");
            }
            var helmoMember = await _context.HelmoMembers.FindAsync(id);
            if (helmoMember != null)
            {
                _context.HelmoMembers.Remove(helmoMember);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HelmoMemberExists(string id)
        {
          return (_context.HelmoMembers?.Any(e => e.Matricule == id)).GetValueOrDefault();
        }
    }
}
