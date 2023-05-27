using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

public class Driver : HelmoMember
{
    
    public ICollection<License>? Licenses { get; set; }

    public ICollection<Delivery>? Deliverys { get; set; } = new List<Delivery>();

    public string Details => $"{FirstName} {Name}\n{Email}";

    public bool HasLicense(int id)
    {

        return Licenses != null && Licenses.Any(l => l.Id == id);
    }


}
