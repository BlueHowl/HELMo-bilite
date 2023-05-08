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


    public Driver Driver { get; set; }
    [ForeignKey(nameof(Driver))]
    public string? IdDriver { get; set; }


    [Required]
    public string Content { get; set; }

    [Required]
    public Address LoadAddress { get; set; }
    [Required]
    [ForeignKey(nameof(LoadAddress))]
    public string LoadAddressId { get; set; }
    [Required]
    public DateTime LoadDate { get; set; }

    [Required]
    public Address UnloadingAddress { get; set; }
    [Required]
    [ForeignKey(nameof(UnloadingAddress))]

    public string UnloadingAddressId { get; set; }

    [Required]
    public DateTime UnloadingDate { get; set; }

    [Required]
    public string status { get; set; }

    public Vehicule Vehicule { get; set; }
    [ForeignKey(nameof(Vehicule))]
    public string? IdVehicule { get; set; }



}
