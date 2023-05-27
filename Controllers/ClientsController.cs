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
                IsBadPayer = client.IsBadPayer
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
                client.IsBadPayer = !client.IsBadPayer;
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
                var srcImage = "images/" + (client.PictureScr == null ? "defaultCompanyPictrure.jpg" : ("client/" + client.PictureScr));
                clientVMs.Add(new ClientVM
                {
                    CompanyName = client.CompanyName,
                    Email = client.Email,
                    PhoneNumber = client.Number,
                    CompanyAddress = addressString,
                    Id = client.Id,
                    IsBadPayer = client.IsBadPayer,
                    HasDelivery = false,
                    PictureSrc = srcImage,
                });
            }
            return clientVMs;
        }
    }
}
