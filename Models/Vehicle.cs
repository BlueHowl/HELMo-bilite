using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Vehicle
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
    public License License { get; set; }
    [Required]
    [ForeignKey(nameof(License))]
    public int IdLicense { get; set; }
    [Required]
    public int Payload { get; set; }

    [StringLength(150)]
    public string ?Picture { get; set; }


}
