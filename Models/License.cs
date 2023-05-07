using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class License
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// TODO a voir si je ne le change pas plus tard car many to many unidircetinnel ne fonctionne que en version 7 de .net
    /// </summary>
    public ICollection<Driver> ?Drivers { get; set;} = new List<Driver>();


} 
