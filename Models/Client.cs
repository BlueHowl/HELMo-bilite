using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Models;

public class Client : User
{
    [Required]
    public string CompanyName { get; set; }
    [Required]
    public Address CompanyAdress { get; set; }
    public string Number { get; set; }
}
