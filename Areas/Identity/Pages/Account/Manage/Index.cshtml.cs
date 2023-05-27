// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
using Bogus.DataSets;
using System.Text.RegularExpressions;
using HELMo_bilite.Controllers.ViewModels;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp.Formats.Jpeg;

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
        public CreationAddressInscriptionVM ClientCompanyAdress { get; set; }

        [BindProperty]
        public ICollection<string> Licenses { get; set; } = new List<string>();

        private bool IsAleradySubmit = false;

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
            public string? PictureSrc { get; set; }

            public IFormFile LogoPicture { get; set; }
            public string? LogoSrc { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Date d'anniversaire")]
            public DateTime? BirthDate { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Le nom de votre companie")]
            public string CompanyName { get; set; }


            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Numéro de téléphone")]
            public string PhoneNumber { get; set; }

            public bool Loaded { get; set; }
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
                LoadDriver(user);
            }
            if (role == "dispatcher")
            {
                LoadDispatcher(user);
            }

            if (role == "client")
            {
                LoadClient(user);
            }
            Input.Loaded = true;

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
            if (!Input.Loaded)
            {
                IsAleradySubmit = true;
                LoadAsync(user);
                return Page();
            }

            ModelErrorApplied(role, user);

            if (!ModelState.IsValid)
            {
                IsAleradySubmit = true;
                LoadAsync(user);
                return Page();
            }


            if (role == "driver")
            {
                StoreDriver(user);
            }

            if (role == "dispatcher")
            {
                StoreDispatcher(user);
            }

            if (role == "client")
            {
                StoreClient(user);
            }



            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Votre profile a bien été mis a jour";
            return RedirectToPage();
        }

        private async void StoreClient(User user)
        {
            var client = _dbContext.Clients.Find(user.Id);
            client.CompanyName = Input.CompanyName;
            client.Number = Input.PhoneNumber;
            if (Input.ProfilePicture != null)
            {
                string pathFileSave = await SavePicture(Input.ProfilePicture, "client", 200, 200, user.Id);
                if (pathFileSave != null)
                {
                    client.PictureScr = pathFileSave;
                    Input.LogoSrc = getPicture("client", pathFileSave);
                }
            }


            var address = _dbContext.Addresses.Find(client.CompanyAddressId);

            address.Number = "" + ClientCompanyAdress.Number;
            address.Street = ClientCompanyAdress.Street;
            address.Locality = ClientCompanyAdress.Locality;
            address.LocalityCode = "" + ClientCompanyAdress.LocalityCode;
            address.Country = ClientCompanyAdress.Country;

            _dbContext.SaveChanges();
        }

        private async void StoreDriver(User user)
        {
            var driver = _dbContext.Drivers.Find(user.Id);
            if (Input.ProfilePicture != null)
            {
                string pathFileSave = await SavePicture(Input.ProfilePicture, "user", 200, 200, user.Id);
                if (pathFileSave != null)
                {
                    driver.PictureScr = pathFileSave;
                    Input.PictureSrc = getPicture("user", pathFileSave);
                }
            }

            driver.BirthDate = Input.BirthDate;
            driver.Name = Input.Name;
            driver.FirstName = Input.FirstName;
            driver.Matricule = Input.Matricule;
            _dbContext.SaveChanges();
        }
        private async void StoreDispatcher(User user)
        {
            var dispatcher = _dbContext.Dispatchers.Find(user.Id);
            dispatcher.Name = Input.Name;
            if (Input.ProfilePicture != null)
            {
                string pathFileSave = await SavePicture(Input.ProfilePicture, "user", 200, 200, user.Id);
                if (pathFileSave != null)
                {
                    dispatcher.PictureScr = pathFileSave;
                    Input.PictureSrc = getPicture("user", pathFileSave);
                }
            }

            dispatcher.FirstName = Input.FirstName;
            dispatcher.Matricule = Input.Matricule;
            dispatcher.IdCertification = _dbContext.Certifications.Find(Input.LevelCertification).Id;
            _dbContext.SaveChanges();
        }

        private void ModelErrorApplied(string role, User user)
        {
            if (role == "driver" || role == "dispatcher")
            {
                if (string.IsNullOrEmpty(Input.Matricule))
                    ModelState.AddModelError(nameof(Input.Matricule), "le matricule ne peut pas etre vide");

                if (string.IsNullOrEmpty(Input.Name))
                    ModelState.AddModelError(nameof(Input.Name), "votre nom ne peut pas etre vide");

                if (string.IsNullOrEmpty(Input.FirstName))
                    ModelState.AddModelError(nameof(Input.FirstName), "votre prenom ne peut pas etre vide");
                var member = _dbContext.HelmoMembers.Find(user.Id);
                if (member.Matricule != Input.Matricule)
                {
                    var userFind = _dbContext.HelmoMembers.Where(hm => Input.Matricule == hm.Matricule).FirstOrDefault(); ;
                    if (userFind != null)
                    {
                        ModelState.AddModelError(nameof(Input.Matricule), "Matricule deja utiliser");
                    }

                }

            }
            if(role == "client")
            {
                Regex regex = new Regex(@"^\+32\d{9}$");
                if(Input.PhoneNumber != null && !regex.IsMatch(Input.PhoneNumber))
                    ModelState.AddModelError(nameof(Input.PhoneNumber), "le numero de telephone doit etre de la forme +32xxxxxxxxx");

                if (string.IsNullOrEmpty(Input.CompanyName))
                    ModelState.AddModelError(nameof(Input.CompanyName), "le nom de la societe ne peut pas etre vide");
                
                //validation de l'adresse client
                if (ClientCompanyAdress.Number < 0)
                    ModelState.AddModelError(nameof(ClientCompanyAdress.Number), "le numero de rue ne peut pas etre vide");
                if (string.IsNullOrEmpty(ClientCompanyAdress.Street))
                    ModelState.AddModelError(nameof(ClientCompanyAdress.Street), "le nom de la rue ne peut pas etre vide");
                if (string.IsNullOrEmpty(ClientCompanyAdress.Locality))
                    ModelState.AddModelError(nameof(ClientCompanyAdress.Locality), "le nom de la localite ne peut pas etre vide");
                if (ClientCompanyAdress.LocalityCode < 0)
                    ModelState.AddModelError(nameof(ClientCompanyAdress.LocalityCode), "le code postal ne peut pas etre vide");
                if (string.IsNullOrEmpty(ClientCompanyAdress.Country))
                    ModelState.AddModelError(nameof(ClientCompanyAdress.Country), "le nom du pays ne peut pas etre vide");




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




        private void LoadDispatcher(User user)
        {
            var dispatcher = _dbContext.Dispatchers.Find(user.Id);
            if (dispatcher == null)
            {
                return;
            }

            Input.LevelCertification = _dbContext.Certifications.Find(dispatcher.IdCertification).Id;

            Input.Name = dispatcher.Name;
            Input.FirstName = dispatcher.FirstName;
            Input.Matricule = dispatcher.Matricule;
            Input.BirthDate = dispatcher.BirthDate;
            if (dispatcher.PictureScr != null)
                Input.PictureSrc = getPicture("user", dispatcher.PictureScr);
        }

        private void LoadDriver(User user)
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
            Input.BirthDate = driver.BirthDate;
            if (driver.PictureScr != null)
            {
                Input.PictureSrc = getPicture("user", driver.PictureScr);
            }

        }

        private void LoadClient(User user)
        {
            var client = _dbContext.Clients.Include(c => c.CompanyAddress).FirstOrDefault(c => c.Id == user.Id);
            Input.PhoneNumber = client.Number;
            if (client == null)
            {
                return;
            }
            Input.CompanyName = client.CompanyName;
            if (client.PictureScr != null)
                Input.LogoSrc = getPicture("client", client.PictureScr);

            ClientCompanyAdress = new CreationAddressInscriptionVM
            {
                Locality = client.CompanyAddress.Locality,
                Country = client.CompanyAddress.Country,
                LocalityCode = int.Parse(client.CompanyAddress.LocalityCode),
                Street = client.CompanyAddress.Street,
                Number = int.Parse(client.CompanyAddress.Number)
            };

        }

        private string getPicture(string folder, string name)
        {
            return Path.Combine("/", "images", folder, name);
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

    }
}
