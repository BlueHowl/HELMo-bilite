using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

[Table("DEV.WEB.AVC.License")]
public class License
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

}
