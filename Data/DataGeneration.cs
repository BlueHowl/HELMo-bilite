using Bogus;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Address = HELMo_bilite.Models.Address;

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

    public static async void SeedUser(UserManager<User> _userManager)
    {
        if (_userManager.Users.Count() != 0)
            return;

        for (int i = 0; i < 10; i++)
        {
            var surName = new Bogus.Person().FirstName;
            var lastName = new Bogus.Person().LastName;
            var email = $"{surName}.{lastName}@helmobilite.be";
            var matricule = "DR" + Randomizer.Seed.Next(100000, 1000000);
            var driver = new Driver()
            {
                Matricule = matricule,
                FirstName = surName,
                Name = lastName,
                Email = email,
                UserName = email,

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
            var matricule = "DR" + Randomizer.Seed.Next(100000, 1000000);
            var client = new Client()
            {
                Matricule = matricule,
                FirstName = surName,
                Name = lastName,
                Email = email,
                UserName = email,
                CompanyName = "test"

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
    }

    public static void SeedAddresses(ApplicationDbContext _context)
    {

        var addrs = _context.Set<Address>().ToList();

        if (addrs.Count > 0)
        {
            return;
        }

        Faker<Address> addressFaker = new Faker<Address>()
            .RuleFor(a => a.IdAddress, f => f.UniqueIndex.ToString())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.Number, f => f.Address.BuildingNumber())
            .RuleFor(a => a.Locality, f => f.Address.City())
            .RuleFor(a => a.LocalityCode, f => f.Address.ZipCode())
            .RuleFor(a => a.Country, f => f.Address.Country());

        List<Address> addresses = new List<Address>();


        for (int i = 0; i < 10; i++)
        {
            var address = addressFaker.Generate();

            _context.Addresses.Add(address);
        }
        _context.SaveChanges();

    }


}
