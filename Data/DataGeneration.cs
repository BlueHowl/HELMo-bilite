﻿using Bogus;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;

namespace HELMo_bilite.Data;

public class DataGeneration
{

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

    public static async void SeedUser(UserManager<User> _userManager, ApplicationDbContext _context)
    {

        if (_userManager.Users.Count() != 0)
            return;

        var licenses = _context.Licenses.ToList();
        for (int i = 0; i < 10; i++)
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

        for (int i = 0; i < 10; i++)
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

        Faker<Address> addressFaker = new Faker<Address>()
            .RuleFor(a => a.IdAddress, f => f.UniqueIndex.ToString())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.Number, f => f.Address.BuildingNumber())
            .RuleFor(a => a.Locality, f => f.Address.City())
            .RuleFor(a => a.LocalityCode, f => f.Address.ZipCode())
            .RuleFor(a => a.Country, f => f.Address.Country());

        for (int i = 0; i < 10; i++)
        {
            var surName = new Bogus.Person().FirstName;
            var lastName = new Bogus.Person().LastName;
            var company = new Bogus.Faker().Company.CompanyName();
            var email = $"{surName}.{lastName}@une.companie.be";

            var addressCompany =  addressFaker.Generate();

            _context.Addresses.Add(addressCompany);
            var client = new Client()
            {
                Email = email,
                UserName = email,
                CompanyName = company,
                CompanyAddressId = addressCompany.IdAddress
            };

            var result = _userManager.CreateAsync(client, "Test@123").Result;
            if (result.Succeeded)
            {
                var result2 = _userManager.AddToRoleAsync(client, "client").Result;
            }

        }
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
            .RuleFor(t=> t.LicensePlate, f=> "a-111-aaa")
            .RuleFor(t => t.Model, f => f.Vehicle.Model())
            .RuleFor(t => t.Brand, f => f.Vehicle.Manufacturer())
            .RuleFor(t => t.Payload, f => f.Random.Int(1, 40) * 1000);

        List<License> license = new List<License>
        {
            new License{Id = 1,   Name = "B"},
            new License{Id = 2,   Name = "C"},
            new License{Id = 3,   Name = "CE"}
        };


        for (int i = 0; i < 10; i++)
        {
            var tr = truckFraker.Generate();
            tr.IdLicense = license[new Random().Next(license.Count)].Id;
            _context.Vehicles.Add(tr);
        }
        _context.SaveChanges();

    }

}
