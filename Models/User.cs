using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

public class User
{
    /// <summary>
    /// TODO: demander au prof si le client a un matricule
    /// </summary>
    [Key]
    public string matricule { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public string FirstName { get; set; }

    //this is unique

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
    [Required]
    public int Status { get; set; }
}
