using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
[Table("DEV.WEB.AVC.Client")]
public class Client : User
{
    [Required]
    public string CompanyName { get; set; }
    [Required]
    public Address CompanyAdress { get; set; }
    public string Number { get; set; }
}
