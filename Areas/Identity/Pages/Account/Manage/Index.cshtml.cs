// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
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
        private readonly IWebHostEnvironment _webHostEnvironment;



        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ApplicationDbContext dbContext, 
            IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
             _webHostEnvironment = webHostEnvironment;

        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }
        [BindProperty]

        public List<Certification> Certifications => _dbContext.Certifications.ToList();

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
            [StringLength(100)]
            [Display(Name = "Nom")]
            public string? Name { get; set; }

            [DataType(DataType.Text)]
            [StringLength(100)]
            [Display(Name = "FirstName")]
            public string FirstName { get; set; }

            [Display(Name = "Matricule")]
            public string? Matricule { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Votre niveau de certification")]
            public int? LevelCertification { get; set; }

            public IFormFile ProfilePicture { get; set; }

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
            if (role == "dispatcher")
            {
                var dispatcher = _dbContext.Dispatchers.Find(user.Id);
                Input.Name = dispatcher.Name;
                Input.FirstName = dispatcher.FirstName;
                Input.Matricule = dispatcher.Matricule;
                Input.LevelCertification = _dbContext.Certifications.Find(dispatcher.IdCertification).Id;

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

            var role = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            ModelErrorApplied(role);

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }


            if (role == "driver")
            {
                Console.WriteLine("--------------------------------------------------------------------------");

                Console.WriteLine(Input.ProfilePicture);
                var pathFileSave = await SaveFile(Input.ProfilePicture, "user");
                Console.WriteLine("fichier sauvegarder :" + pathFileSave);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------");

                StoreDriver(user);
            }

            if (role == "dispatcher")
            {
                StoreDispatcher(user);
            }



            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }

        private void StoreDriver(User user)
        {
            var driver = _dbContext.Drivers.Find(user.Id);
            driver.Name = Input.Name;
            driver.FirstName = Input.FirstName;
            driver.Matricule = Input.Matricule;
            _dbContext.SaveChanges();
        }
        private void StoreDispatcher(User user)
        {
            var dispatcher = _dbContext.Dispatchers.Find(user.Id);
            dispatcher.Name = Input.Name;
            dispatcher.FirstName = Input.FirstName;
            dispatcher.Matricule = Input.Matricule;
            dispatcher.IdCertification = _dbContext.Certifications.Find(Input.LevelCertification).Id;
            _dbContext.SaveChanges();
        }

        private void ModelErrorApplied(string role)
        {
            if (role == "driver" || role == "dispatcher")
            {
                if (string.IsNullOrEmpty(Input.Matricule))
                    ModelState.AddModelError(nameof(Input.Matricule), "le matricule ne peut pas etre vide");

                if (string.IsNullOrEmpty(Input.Name))
                    ModelState.AddModelError(nameof(Input.Name), "votre nom ne peut pas etre vide");

                if (string.IsNullOrEmpty(Input.FirstName))
                    ModelState.AddModelError(nameof(Input.FirstName), "votre prenom ne peut pas etre vide");

                var user = _dbContext.HelmoMembers.Where(hm => Input.Matricule == hm.Matricule).FirstOrDefault(); ;
                if (user != null)
                {
                    ModelState.AddModelError(nameof(Input.Matricule), "Matricule deja utiliser");
                }


            }
            //obtention des erreurde validation
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            StatusMessage = "Error: ";
            int n = 0;
            foreach (var error in errors)
            {
                if (n++ != 0)
                    StatusMessage += ", ";
                StatusMessage += error.ErrorMessage;



            }
        }


        private async Task<string> SaveFile(IFormFile profilePicture, string path)
        {
            var webRootPath = _webHostEnvironment.WebRootPath;
            var fileName = Path.GetFileName(profilePicture.FileName);
            var filePath = Path.Combine(webRootPath, "images", path, fileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await profilePicture.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
