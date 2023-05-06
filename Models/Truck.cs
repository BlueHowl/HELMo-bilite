using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Truck
{
    [Key]
    public string Plate { get; set; }
    [Required]
    public string Brand { get; set; }
    [Required]
    public string Model { get; set; }
    
    public License Licenses { get; set; }

    [Required]
    public int Payload { get; set; }  
    
    public string ?Picture { get; set; }


}
