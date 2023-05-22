using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class VehicleVM
    {
        [StringLength(17)]
        public string? VIN { get; set; }

        [StringLength(50)]
        public string Plate { get; set; }
        [Required]
        [StringLength(50)]
        public string Brand { get; set; }
        [Required]
        [StringLength(50)]
        public string Model { get; set; }
        [Required]
        public int IdLicenses { get; set; }
        [Required]
        public int Payload { get; set; }

        public string? PictureScr { get; set; }

        public IFormFile? Picture { get; set; }
    }
}
