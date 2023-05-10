using Bogus;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
            var matricule = "DR"+Randomizer.Seed.Next(100000, 1000000);
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

    }



}
