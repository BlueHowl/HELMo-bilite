using Bogus;
using HELMo_bilite.Controllers.ViewModels;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace HELMo_bilite.Data;

public class DataGeneration
{
    private static readonly int nbClient = 1000;
    private static readonly int nbDelivery = 1000;
    private static readonly int nbAddress = 100;
    private static readonly int nbVehicule = 100;
    private static readonly int nbDriver = 100;
    private static readonly int nbDispatcher = 100;

    private static readonly Faker<Address> addressFaker = new Faker<Address>()
            .RuleFor(a => a.IdAddress, f => f.IndexGlobal.ToString())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.Number, f => f.Address.BuildingNumber())
            .RuleFor(a => a.Locality, f => f.Address.City())
            .RuleFor(a => a.LocalityCode, f => f.Address.ZipCode())
            .RuleFor(a => a.Country, f => f.Address.Country());


    public static void SeedRole(RoleManager<IdentityRole> roleManager)
    {
        if (roleManager.RoleExistsAsync("admin").Result == false)
        {
            IdentityRole admin = new IdentityRole() { Name = "admin" };
            var result = roleManager.CreateAsync(admin);
            result.Wait();
        }
        if (roleManager.RoleExistsAsync("client").Result == false)
        {
            IdentityRole admin = new IdentityRole() { Name = "client" };
            var result = roleManager.CreateAsync(admin);
            result.Wait();
        }
        if (roleManager.RoleExistsAsync("dispatcher").Result == false)
        {
            IdentityRole admin = new IdentityRole() { Name = "dispatcher" };
            var result = roleManager.CreateAsync(admin);
            result.Wait();
        }

        if (roleManager.RoleExistsAsync("driver").Result == false)
        {
            IdentityRole admin = new IdentityRole() { Name = "driver" };
            var result = roleManager.CreateAsync(admin);
            result.Wait();
        }

    }
    private static void SeedDriver(UserManager<User> _userManager, ApplicationDbContext _context)
    {

        var lisences = _context.Licenses.ToList();
        for (int i = 0; i < nbDriver; i++)
        {
            var surName = new Bogus.Person().FirstName;
            var lastName = new Bogus.Person().LastName;
            var email = $"{surName}.{lastName}@helmobilite.be";
            var matricule = "DR" + Randomizer.Seed.Next(100000, 1000000);

            var licenseList = new List<License>();

            int n = Randomizer.Seed.Next(1, 4);

            for (int j = 0; j < n; ++j)
            {
                licenseList.Add(licenses[j]);
            }

            var driver = new Driver()
            {
                Matricule = matricule,
                FirstName = surName,
                Name = lastName,
                Email = email,
                UserName = email,
                Licenses = licenseList,

            };

            var result = _userManager.CreateAsync(driver, "Test@123").Result;
            if (result.Succeeded)
            {
                var result2 = _userManager.AddToRoleAsync(driver, "driver").Result;
            }

        }
        _context.SaveChanges();
    }

    private static void SeedDispatcher(UserManager<User> _userManager)
    {
        
        for (int i = 0; i < nbDispatcher; i++)
        {
            var surName = new Bogus.Person().FirstName;
            var lastName = new Bogus.Person().LastName;
            var email = $"{surName}.{lastName}@helmobilite.be";
            var matricule = "DI" + Randomizer.Seed.Next(100000, 1000000);
            var dispatcher = new Dispatcher()
            {
                Matricule = matricule,
                FirstName = surName,
                Name = lastName,
                Email = email,
                UserName = email,
                IdCertification = 1
            };
            var result = _userManager.CreateAsync(dispatcher, "Test@123").Result;
            if (result.Succeeded)
            {
                var result2 = _userManager.AddToRoleAsync(dispatcher, "dispatcher").Result;
            }

        }
    }

    private async static void SeedClient(UserManager<User> _userManager, ApplicationDbContext _context)
    {
        for (int i = 0; i < nbClient; i++)
        {
            var surName = new Bogus.Person().FirstName;
            var lastName = new Bogus.Person().LastName;
            var company = new Bogus.Faker().Company.CompanyName();
            var email = $"{surName}.{lastName}@une.companie.be";

            var addressCompanyId = GeneratedAddress(_context);


            var client = new Client()
            {
                Email = email,
                UserName = email,
                CompanyName = company,
                CompanyAddressId = addressCompanyId
            };


            var result =  _userManager.CreateAsync(client, "Test@123").Result;            
            if (result.Succeeded)
            {
                var result2 = _userManager.AddToRoleAsync(client, "client").Result;
            }


        }
        _context.SaveChanges();
    }
    private static async void SeedAdmin(UserManager<User> _userManager)
    {
        Admin admin = new Admin
        {
            Email = "valentin.lopez1109@gmail.com",
            UserName = "valentin.lopez1109@gmail.com"
        };

        var resultAdmin = _userManager.CreateAsync(admin, "Test@123").Result;
        if (resultAdmin.Succeeded)
        {
            var resultAdmin2 = _userManager.AddToRoleAsync(admin, "admin").Result;
        }
    }




    public static async void SeedUser(UserManager<User> _userManager, ApplicationDbContext _context)
    {

        if (_context.Drivers.ToList().Count == 0)            
            SeedDriver(_userManager, _context);
        
        if(_context.Dispatchers.ToList().Count == 0)
            SeedDispatcher(_userManager);
        if(_context.Clients.ToList().Count == 0)
            SeedClient(_userManager, _context);

        SeedAdmin(_userManager);

        _context.SaveChanges();
    }

    public static void SeedVehicles(ApplicationDbContext _context)
    {

        var vehicles = _context.Vehicles.ToList();

        if (vehicles.Count > 0)
        {
            return;
        }

        Faker<Models.Vehicle> truckFraker = new Faker<Models.Vehicle>()
            .RuleFor(t => t.VIN, f => f.Vehicle.Vin())
            .RuleFor(t => t.LicensePlate, f => "a-111-aaa")
            .RuleFor(t => t.Model, f => f.Vehicle.Model())
            .RuleFor(t => t.Brand, f => f.Vehicle.Manufacturer())
            .RuleFor(t => t.Payload, f => f.Random.Int(1, 40) * 1000);

        List<License> license = new List<License>
        {
            new License{Id = 1,   Name = "B"},
            new License{Id = 2,   Name = "C"},
            new License{Id = 3,   Name = "CE"}
        };


        for (int i = 0; i < nbVehicule; i++)
        {
            var tr = truckFraker.Generate();
            tr.IdLicense = license[new Random().Next(license.Count)].Id;
            _context.Vehicles.Add(tr);
        }
        _context.SaveChanges();

    }
    public static void SeedDelivery(ApplicationDbContext _context)
    {
        
        var deliveries = _context.Deliveries.ToList();
        if (deliveries.Count > 0)
        {
            return;
        }

        
        for (int i = 0; i < nbDelivery; i++)
        {
            


            var delivery = CreateDelivery(_context);

            _context.Deliveries.Add(delivery);
        }
        _context.SaveChanges();
    }

    public static void SeedAddresses(ApplicationDbContext _context)
    {

        var addresses = _context.Addresses.ToList();
        if (addresses.Count > 0)
        {
            return;
        }

        for (int i = 0; i < 10; i++)
        {
            GeneratedAddress(_context);
        }
    }

    private static string GeneratedAddress(ApplicationDbContext _context)
    {
        var newAddress = addressFaker.Generate();        
        _context.Addresses.Add(newAddress);
        return newAddress.IdAddress;
    }

    private static Delivery CreateDelivery(ApplicationDbContext _context)
    {
        var clients = _context.Clients.ToList();

        var addressLoad = GeneratedAddress(_context);
        var addressUnload = GeneratedAddress(_context);
        string driverId = null;
        string vehicleId = null;
        string statut = Delivery.State.Waiting;

        //une chance sur deux d'avoir un driver et un véhicule
        if (new Random().Next(0, 2) == 1)
        {
            var drivers = _context.Drivers.ToList();
            driverId = drivers[new Random().Next(drivers.Count)].Id;
            var vehicles = _context.Vehicles.ToList();
            vehicleId = vehicles[new Random().Next(vehicles.Count)].VIN;

            if (new Random().Next(0, 2) == 1)
            {
                statut = Delivery.State.InProgress;
            }
            else
            {
                statut = Delivery.State.IsEnded;
            }
        }

        return new Delivery
        {
            IdClient = clients[new Random().Next(clients.Count)].Id,
            IdDriver = driverId,
            IdVehicle = vehicleId,
            Content = new Bogus.Faker().Commerce.Product(),
            LoadAddressId = addressLoad,
            UnloadingAddressId = addressUnload,
            LoadDate = DateTime.Now.AddDays(new Random().Next(1, 10)),
            UnloadingDate = DateTime.Now.AddDays(new Random().Next(1, 10)),
            Status = statut

        };
    }

}
