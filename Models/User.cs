using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;


[Table("DEV.WEB.AVC.User")]
public class User
{
    /// <summary>
    /// TODO: demander au prof si le client a un matricule
    /// </summary>
    [Key]
    [Required]
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
