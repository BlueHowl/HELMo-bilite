using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
[Table("DEV.WEB.AVC.Dispatcher")]
public class Dispatcher : User
{
    //[NotMapped]
    public List<Certification> Certifications { get; set; }
}
