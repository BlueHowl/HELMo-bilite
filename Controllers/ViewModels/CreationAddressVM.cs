using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class CreationAddressVM
    {
        [StringLength(100)] public string? Locality { get; set; }
        [StringLength(10)] public string? LocalityCode { get; set; }
        [StringLength(5)] public string? Number { get; set; }
        [StringLength(100)] public string? Street { get; set; }
        [StringLength(100)] public string? Country { get; set; }
    }
}


