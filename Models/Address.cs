using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

[Table("DEV.WEB.AVC.Address")]
public class Address
{
    [Key] public int Id { get; set; }
    [Required] public string Locality { get; set; }
    [Required] public string Number { get; set; }
    [Required] public string Street { get; set; }
    [Required] public int LocalityCode { get; set; }
}
