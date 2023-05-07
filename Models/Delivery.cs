using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Delivery
{
    [Key]
    public int Id { get; set; }

    [Required]
    public Client Client { get; set; }
    [Required]
    [ForeignKey(nameof(Client))]
    public string IdClient { get; set; }

    public Dispatcher Dispatcher { get; set; }
    [ForeignKey(nameof(Dispatcher))]
    public string IdDispatcher { get; set; }
    
    public Driver Driver { get; set; }
    [ForeignKey(nameof(Driver))]
    public string IdDriver { get; set; }

    [Required]
    public string Content { get; set; }

    

    [Required]
    public DateTime LoadDate { get; set; }

    [Required]
    public DateTime UnloadingDate { get; set; }

    [Required]
    public string status { get; set; }



}
