using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Dispatcher : User
{
    //[NotMapped]
    public List<Certification> Certifications { get; set; }
}
