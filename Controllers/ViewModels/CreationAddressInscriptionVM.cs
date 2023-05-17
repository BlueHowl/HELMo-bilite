using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class CreationAddressInscriptionVM
    {
        [DisplayName("Localité")]
        [StringLength(100)]
        public string? Locality { get; set; }

        //[StringLength(10)]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Le code ne peut faire plus de 10 chiffres !")]
        [DisplayName("Code postal")]
        [Range(0, 9999999999, ErrorMessage = "Le code postal ne peut faire plus de 10 chiffres !")]
        public int? LocalityCode { get; set; }

        //[StringLength(5)]
        //[RegularExpression(@"^\d{5}$", ErrorMessage = "Le numéro ne peut faire plus de 5 chiffres !")]
        [DisplayName("Numéro")]
        [Range(0, 99999, ErrorMessage = "Le numéro doit être compris entre 0 et 99999 !")]
        public int? Number { get; set; }

        [DisplayName("Rue")]
        [StringLength(100)]
        public string? Street { get; set; }

        [DisplayName("Pays")]
        [StringLength(100)]
        public string? Country { get; set; }
    }
}
