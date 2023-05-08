using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;


public class User
{
    /// <summary>
    /// TODO: demander au prof si le client a un matricule
    /// </summary>
    [Key]
    [Required]
    [StringLength(10)]
    public string Matricule { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }

    //this is unique

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(60)]
    public string Password { get; set; }
    
}
