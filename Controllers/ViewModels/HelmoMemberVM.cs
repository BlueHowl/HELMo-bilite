using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class HelmoMemberVM
    {
        public string? PictureScr { get; init; }
        [Display(Name = "Matricule")]
        public string Matricule { get; init; }

        [Display(Name = "Nom")]
        public string Name { get; init; }

        [Display(Name = "Prenom")]
        public string FirstName { get; init; }

        public string Role { get; init; }
    }
}
