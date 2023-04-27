using System.ComponentModel.DataAnnotations;

namespace HELMo_bilite.Models;

public class Delivery
{
    [Key]
    public int Id { get; set; }

    [Required]
    public Client ClientId { get; set; }

    [Required]
    public Dispatcher DispatcherId { get; set; }
    
    public Driver Driver { get; set; }

    [Required]
    public string Content { get; set; }

    [Required]
    public Address LoadAdress { get; set; }

    [Required]
    public Address UnloadingAdress { get; set; }

    [Required]
    public DateTime LoadDate { get; set; }

    [Required]
    public DateTime UnloadingDate { get; set; }

    [Required]
    public string status { get; set; }


}
