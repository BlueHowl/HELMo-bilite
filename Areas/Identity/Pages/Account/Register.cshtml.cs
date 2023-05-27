// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using HELMo_bilite.Data;
using HELMo_bilite.Controllers.ViewModels;
using NuGet.Packaging.Signing;
using System.Linq;

namespace HELMo_bilite.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserStore<User> _userStore;
        private readonly IUserEmailStore<User> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _dbContext;


        public RegisterModel(
            UserManager<User> userManager,
            IUserStore<User> userStore,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext dbContext)
        {

            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _dbContext = dbContext;

        }


        [BindProperty]
        public CreationAddressInscriptionVM AddressCreation { get; set; } = new CreationAddressInscriptionVM();

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        [BindProperty]
        public ICollection<License> Lisence => _dbContext.Licenses.ToList();

        [BindProperty]
        public ICollection<Certification> Certification => _dbContext.Certifications.ToList();

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

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
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Name")]
            public string? Name { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "FirstName")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Role")]
            public int Role { get; set; } = -1;

            [Display(Name = "License")]
            public List<string> License { get; set; }

            [Display(Name = "Matricule")]
            public int? Matricule { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Votre niveau de certification")]
            public string? LevelCertification { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Le nom de votre société")]
            public string? CompanyName { get; set; }
        }



        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            VerifyInput();


            if (ModelState.IsValid)
            {


                var user = CreateUser();

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);

                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");


                    await _userManager.AddToRoleAsync(user, Input.Role == 0 ? ApplicationDbContext.RoleDriver :
                                                            Input.Role == 1 ? ApplicationDbContext.RoleDispatcher :
                                                            Input.Role == 2 ? ApplicationDbContext.RoleClient :
                                                            ApplicationDbContext.RoleDriver);
                    if (Input.Role == 0)
                    {
                        SaveLisencesDriver(user);
                    }



                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {

                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            /*else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }*/

            // If we got this far, something failed, redisplay form
            return Page();
        }



        private User CreateUser()
        {
            try
            {
                switch (Input.Role)
                {
                    case 0:
                        Driver driver = Activator.CreateInstance<Driver>();
                        driver.Name = Input.Name;
                        driver.FirstName = Input.FirstName;
                        driver.Matricule = FormatMatricule(Input.Matricule, Input.Role);
                        return driver;
                    case 1:
                        Dispatcher dispatcher = Activator.CreateInstance<Dispatcher>();
                        dispatcher.Name = Input.Name;
                        dispatcher.FirstName = Input.FirstName;
                        dispatcher.Matricule = FormatMatricule(Input.Matricule, Input.Role);
                        dispatcher.IdCertification = int.Parse(Input.LevelCertification);
                        return dispatcher;
                    case 2:
                        Client client = Activator.CreateInstance<Client>();
                        client.CompanyName = Input.CompanyName;
                        client.CompanyAddressId = StoreAddressesCompanyClient();

                        return client;
                    default:
                        throw new InvalidOperationException($"Can't create an instance of '{nameof(User)}'. " +
                           $"Ensure that '{nameof(User)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                           $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
                }

            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(User)}'. " +
                    $"Ensure that '{nameof(User)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<User> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<User>)_userStore;
        }

        private string StoreAddressesCompanyClient()
        {
            var address = new Address
            {
                Locality = AddressCreation.Locality,
                Street = AddressCreation.Street,
                Number = AddressCreation.Number.ToString(),
                LocalityCode = AddressCreation.LocalityCode.ToString(),
                Country = AddressCreation.Country,
            };

            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();
            return address.IdAddress;
        }
        /// <summary>
        /// this methode contain all the verification of the input
        /// </summary>
        private void VerifyInput()
        {
            if (Input.Role == -1)
                ModelState.AddModelError(string.Empty, "Vous devez choisir un role");

            if (Input.Role == 0 || Input.Role == 1)
            {
                if (String.IsNullOrEmpty(Input.FirstName))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un prenom");
                }
                if (String.IsNullOrEmpty(Input.Name))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un nom");
                }
                if (Input.Matricule == null)
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un matricule");
                }

                var user = _dbContext.HelmoMembers.Where(hm => FormatMatricule(Input.Matricule, Input.Role) == hm.Matricule).FirstOrDefault(); ;
                if (user != null)
                {
                    ModelState.AddModelError(string.Empty, "Matricule deja utiliser");
                }

            }
            if (Input.Role == 1 && Input.LevelCertification == null)
            {
                ModelState.AddModelError(string.Empty, "Vous devez choisir un niveau de certification");
            }

            if (Input.Role == 0 && Input.License == null)
            {
                ModelState.AddModelError(string.Empty, "Vous devez choisir au moins une license");
            }

            if (Input.Role == 2)
            {
                if (String.IsNullOrEmpty(Input.CompanyName))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un nom d'entreprise");
                }
                if (String.IsNullOrEmpty(AddressCreation.Street))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer une rue");
                }
                if (String.IsNullOrEmpty(AddressCreation.Number.ToString()))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un numero");
                }
                if (String.IsNullOrEmpty(AddressCreation.Locality))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer une localite");
                }
                if (String.IsNullOrEmpty(AddressCreation.LocalityCode.ToString()))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un code postal");
                }
                if (String.IsNullOrEmpty(AddressCreation.Country))
                {
                    ModelState.AddModelError(string.Empty, "Vous devez entrer un pays");
                }
            }
        }


        private string FormatMatricule(int? num, int role)
        {
            return (role == 0 ? "DR" : "DI") + $"{num:00000000}";
        }

      
        private void SaveLisencesDriver(User user)
        {
            var driver = _dbContext.Drivers.Find(user.Id);
            driver.Licenses = new List<License>();

            //on trouver le plus grand id de lisence et on le coverti en int
            var higthestLisenceId = int.Parse(Input.License.OrderByDescending(l => l).FirstOrDefault());


            var lisences = _dbContext.Licenses.ToList();
            foreach (var lisence in lisences)
            {

                if (higthestLisenceId >= lisence.Id)
                {
                    driver.Licenses.Add(lisence);
                }
            }
            _dbContext.SaveChanges();
        }
    }
}
