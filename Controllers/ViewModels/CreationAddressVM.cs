using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class CreationAddressVM
    {
        [DisplayName("Localité")]
        [StringLength(100)]
        [Required(ErrorMessage = "La localité doit être indiquée !")]
        public string Locality { get; set; }

        //[StringLength(10)]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Le code ne peut faire plus de 10 chiffres !")]
        [DisplayName("Code postal")]
        [Range(0, 9999999999, ErrorMessage = "Le code postal ne peut faire plus de 10 chiffres !")]
        [Required(ErrorMessage = "Le code postal doit être indiqué !")]
        public int LocalityCode { get; set; }

        //[StringLength(5)]
        //[RegularExpression(@"^\d{5}$", ErrorMessage = "Le numéro ne peut faire plus de 5 chiffres !")]
        [DisplayName("Numéro")]
        [Range(0, 99999, ErrorMessage = "Le numéro doit être compris entre 0 et 99999 !")]
        [Required(ErrorMessage = "Le numéro doit être indiqué !")]
        public int Number { get; set; }

        [DisplayName("Rue")]
        [StringLength(100)]
        [Required(ErrorMessage = "La rue doit être indiquée !")]
        public string Street { get; set; }

        [DisplayName("Pays")]
        [StringLength(100)]
        [Required(ErrorMessage = "Le pays doit être indiqué !")]
        public string Country { get; set; }
    }
}


