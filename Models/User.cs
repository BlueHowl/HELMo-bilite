using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

public class User : IdentityUser
{
    public string? PictureScr { get; set; }
}

public class HelmoMember : User
{

    [Required]
    [StringLength(10)]
    public string Matricule { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }

    public DateTime? BirthDate { get; set; }

}
