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
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace HELMo_bilite.Controllers
{
    [Authorize(Roles = "admin")]
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            
            return View(GetClientForIndex());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.CompanyAddress)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            ViewData["CompanyAddressId"] = new SelectList(_context.Addresses, "IdAddress", "IdAddress");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyName,CompanyAddressId,Number,Id,Email,UserName")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyAddressId"] = new SelectList(_context.Addresses, "IdAddress", "IdAddress", client.CompanyAddressId);
            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            ViewData["CompanyAddressId"] = new SelectList(_context.Addresses, "IdAddress", "IdAddress", client.CompanyAddressId);
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyName,CompanyAddressId,Number,Id,Email,UserName")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
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
            ViewData["CompanyAddressId"] = new SelectList(_context.Addresses, "IdAddress", "IdAddress", client.CompanyAddressId);
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.CompanyAddress)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Clients == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Clients'  is null.");
            }
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EditBadPayer(string id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            ViewData["CompanyAddressId"] = new SelectList(_context.Addresses, "IdAddress", "IdAddress", client.CompanyAddressId);
            return View(new ClientVM
            {
                Id = client.Id,
                CompanyName = client.CompanyName,
                IsBadPayer = client.IsBagPayer
            });
        }

        [HttpPost, ActionName("EditBadPayer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBadPayerConfirmed(string id)
        {


            if (_context.Clients == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Clients'  is null.");
            }
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                client.IsBagPayer = !client.IsBagPayer;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(string id)
        {
          return (_context.Clients?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private List<ClientVM> GetClientForIndex()
        {
            var clients = _context.Clients.Include(c => c.CompanyAddress).ToList();
            var clientVMs = new List<ClientVM>();
            foreach (var client in clients)
            {
                var addressString = $"{client.CompanyAddress.Street} {client.CompanyAddress.Number}, {client.CompanyAddress.LocalityCode} {client.CompanyAddress.Locality}";
                var srcImage = "/images/" + (client.PictureScr == null ? "defaultCompanyPictrure.jpg" : ("client/" + client.PictureScr));
                clientVMs.Add(new ClientVM
                {
                    CompanyName = client.CompanyName,
                    Email = client.Email,
                    PhoneNumber = client.Number,
                    CompanyAddress = addressString,
                    Id = client.Id,
                    IsBadPayer = client.IsBagPayer,
                    HasDelivery = false,
                    PictureSrc = srcImage,
                });
            }
            return clientVMs;
        }
    }
}
