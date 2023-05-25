using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Vehicle
{
    /// <summary>
    /// le numero de chassi du véhicule ne peut pas être modifié
    /// </summary>
    [Key]
    [StringLength(17)]
    public string VIN { get; set; }

    [StringLength(10)]
    public string LicensePlate  { get; set; }
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

    public string Details => $"{Brand} {Model}\n{VIN}";

}
