using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Dispatcher : User
{
    [ForeignKey(nameof(Certification))]
    public int? IdCertification { get; set; }
    public Certification Certification { get; set; }

    //public ICollection<Delivery> Deliverys { get; set; } = new List<Delivery>();
}
