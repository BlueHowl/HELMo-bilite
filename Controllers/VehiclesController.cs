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
using Microsoft.AspNetCore.Hosting;
using SixLabors.ImageSharp.Formats.Jpeg;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HELMo_bilite.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VehiclesController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vehicles.Include(v => v.License);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.License)
                .FirstOrDefaultAsync(m => m.VIN == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            ViewData["IdLicenses"] = new SelectList(_context.Licenses, "Id", "Name");
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Create([Bind("VIN,Plate,Brand,Model,IdLicenses,Payload,Picture")] VehicleVM vehicleInput)
        {
            VerifCreate(vehicleInput);  
            if (ModelState.IsValid)
            {
                var vehicle = new Vehicle
                {
                    VIN = vehicleInput.VIN,
                    LicensePlate = vehicleInput.Plate,
                    Brand = vehicleInput.Brand,
                    Model = vehicleInput.Model,
                    IdLicense = vehicleInput.IdLicenses,
                    Payload = vehicleInput.Payload
                };
                if (vehicle.Picture != null)
                    vehicle.Picture = await SavePicture(vehicleInput.Picture, "vehicules", 400, 400, vehicle.VIN);


                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdLicenses"] = new SelectList(_context.Licenses, "Id", "Name", vehicleInput.IdLicenses);
            return View(vehicleInput);
        }

        // GET: Vehicles/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["IdLicenses"] = new SelectList(_context.Licenses, "Id", "Name", vehicle.IdLicense);
            return View(new VehicleVM
            {
                PictureScr = vehicle.Picture == null ? "defaultTucksPicture.png" : ("vehicules/" + vehicle.Picture),
                Plate = vehicle.LicensePlate,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                IdLicenses = vehicle.IdLicense,
                Payload = vehicle.Payload
            });
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Plate,Brand,Model,IdLicenses,Payload,Picture")] VehicleVM vehicle)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    var vehicleToUpdate = await _context.Vehicles.FindAsync(id);
                    if (vehicleToUpdate == null)
                    {
                        return NotFound();
                    }
                    vehicleToUpdate.Brand = vehicle.Brand;
                    vehicleToUpdate.Model = vehicle.Model;
                    vehicleToUpdate.IdLicense = vehicle.IdLicenses;
                    vehicleToUpdate.Payload = vehicle.Payload;
                    if(vehicle.Picture != null)
                        vehicleToUpdate.Picture =  await SavePicture(vehicle.Picture, "vehicules", 400, 400, id);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Plate))
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

            ViewData["IdLicenses"] = new SelectList(_context.Licenses, "Id", "Name", vehicle.IdLicenses);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.License)
                .FirstOrDefaultAsync(m => m.VIN == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Vehicles == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Vehicles'  is null.");
            }
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                if(vehicle.Picture != null)
                    System.IO.File.Delete(Path.Combine(_webHostEnvironment.WebRootPath, "images", "vehicules", vehicle.Picture)); // Delete
                
                _context.Vehicles.Remove(vehicle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(string id)
        {
            return (_context.Vehicles?.Any(e => e.VIN == id)).GetValueOrDefault();
        }
        private async Task<string> SavePicture(IFormFile profilePicture, string path, int maxWidth, int maxHeight, string nameFile)
        {
            var webRootPath = _webHostEnvironment.WebRootPath;
            var fileEnter = Path.GetFileName(profilePicture.FileName);
            string fileName = nameFile + Path.GetExtension(fileEnter);

            var filePath = Path.Combine(webRootPath, "images", path, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                // Redimensionner l'image
                using (var image = Image.Load(profilePicture.OpenReadStream()))
                {
                    image.Mutate(x => x.Resize(new ResizeOptions
                    {
                        Size = new Size(maxWidth, maxHeight),
                        Mode = ResizeMode.Max
                    }));

                    // Enregistrer l'image redimensionnée
                    image.Save(fileStream, new JpegEncoder());
                }

                await fileStream.FlushAsync();
            }

            return fileName;
        }

        private void VerifCreate(VehicleVM vehicleInput)
        {
            if (vehicleInput.VIN == null)
            {
                ModelState.AddModelError("VIN", "Le VIN est obligatoire");
            }
            var vehiculeFound = _context.Vehicles.FirstOrDefault(v => v.VIN == vehicleInput.VIN);
            if(vehiculeFound != null)
            {
                ModelState.AddModelError("VIN", "Ce VIN est appartient deja a autre vehicule");
            }
            if (vehicleInput.Plate == null)
            {
                ModelState.AddModelError("Plate", "La plaque est obligatoire");
            }
            var plateFound = _context.Vehicles.FirstOrDefault(v => v.LicensePlate == vehicleInput.Plate);
            if (plateFound != null)
            {
                ModelState.AddModelError("Plate", "Cette plaque est appartient deja a autre vehicule");
            }

            if (vehicleInput.Brand == null)
            {
                ModelState.AddModelError("Brand", "La marque est obligatoire");
            }

            if (vehicleInput.Model == null)
            {
                ModelState.AddModelError("Model", "Le model est obligatoire");
            }

            if (vehicleInput.IdLicenses == null)
            {
                ModelState.AddModelError("IdLicenses", "Le type de permis est obligatoire");
            }

            if (vehicleInput.Payload == null)
            {
                ModelState.AddModelError("Payload", "La charge utile est obligatoire");
            }

        }

    }


}
