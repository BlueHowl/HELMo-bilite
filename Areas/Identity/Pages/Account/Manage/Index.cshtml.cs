// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
using HELMo_bilite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HELMo_bilite.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _dbContext;
        

        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            

        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }



        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        [BindProperty]
        public ICollection<string> Licenses { get; set; } = new List<string>();

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>

            [DataType(DataType.Text)]
            [Display(Name = "Name")]
            public string? Name { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "FirstName")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Role")]
            public int Role { get; set; } = 0;

            [Display(Name = "License")]
            public List<string> License { get; set; }

            [Display(Name = "Matricule")]
            public string? Matricule { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Votre niveau de certification")]
            public string? LevelCertification { get; set; }

        }

        private async Task LoadAsync(User user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
            Username = userName;

            Input = new InputModel();

            if (role == "driver")
            {
                var driver = _dbContext.Drivers.Include(d => d.Licenses).FirstOrDefault(d => d.Id == user.Id);
                
                if (driver == null)
                {
                    return;
                }

                Licenses = driver.Licenses.Select(i => i.Name).ToList();
                if (Licenses.Count == 0)
                {
                    Licenses.Add("pas de lisence");
                }

                Input.Name = driver.Name;
                Input.FirstName = driver.FirstName;
                Input.Matricule = driver.Matricule;
            }
            if(role == "dispatcher")
            {
                var dispatcher = _dbContext.Dispatchers.Find(user.Id);
                Input.Name = dispatcher.Name;
                Input.FirstName = dispatcher.FirstName;
                Input.LevelCertification = _dbContext.Certifications.Find(dispatcher.IdCertification).Name; ;

            }

        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
            var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
            if (role == "driver")
            {
                var driver = _dbContext.Drivers.Find(user.Id);
                driver.Name = Input.Name;
                driver.FirstName = Input.FirstName;
                driver.Matricule = Input.Matricule;
                _dbContext.SaveChanges();
            }
            
            if(role == "dispatcher")
            {
                var dispatcher = _dbContext.Dispatchers.Find(user.Id);
                dispatcher.Name = Input.Name;
                dispatcher.FirstName = Input.FirstName;
                _dbContext.SaveChanges();
            }



            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
