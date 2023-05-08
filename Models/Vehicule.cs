using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Vehicule
{
    [Key]
    [StringLength(50)]
    public string Plate { get; set; }
    [Required]
    [StringLength(50)]
    public string Brand { get; set; }
    [Required]
    [StringLength(50)]
    public string Model { get; set; }
    [Required]    
    public License Licenses { get; set; }
    [Required]
    [ForeignKey(nameof(Licenses))]
    public int IdLicenses { get; set; }
    [Required]
    public int Payload { get; set; }

    [StringLength(150)]
    public string ?Picture { get; set; }


}
