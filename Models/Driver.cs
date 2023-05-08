using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

public class Driver : User
{
    
    public ICollection<License> Licenses { get; set; } = new List<License>();

    public ICollection<Delivery>? Deliverys { get; set; } = new List<Delivery>();

}
