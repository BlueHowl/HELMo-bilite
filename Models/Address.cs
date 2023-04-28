using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Models;

public class Address
{
    [Key] public int Id { get; set; }
    [Required] public string Locality { get; set; }
    [Required] public string Number { get; set; }
    [Required] public string Street { get; set; }
    [Required] public int LocalityCode { get; set; }
}
