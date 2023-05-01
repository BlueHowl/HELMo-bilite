using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

[Table("DEV.WEB.AVC.Driver")]
public class Driver : User
{
    /// <summary>
    /// TODO peut être une enum, ou une classe a part entière
    /// </summary>
    public List<License> Licenses { get; set; }
}
