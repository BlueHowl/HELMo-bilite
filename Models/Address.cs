using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

public class Address
{
    [Key] public string IdAddress { get; set; }
    [Required] public string Locality { get; set; }
    [Required] public string Number { get; set; }
    [Required] public string Street { get; set; }
    [Required] public string LocalityCode { get; set; }
    [Required] public string Country { get; set; }
}
