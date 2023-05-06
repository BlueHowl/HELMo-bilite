using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Dispatcher : User
{
    
    public ICollection<Certification> Certifications { get; set; } = new List<Certification>();
}
