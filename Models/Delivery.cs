using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Delivery
{
    public class State
    {
        public static readonly string Waiting = "En Attente";
        public static readonly string InProgress = "En Cours";
        public static readonly string IsEnded = "Terminé";
    }


    [Key]
    public int Id { get; set; }

    [Required]
    public Client Client { get; set; }
    [Required]
    [ForeignKey(nameof(Client))]
    public string IdClient { get; set; }
    public string ClientDetails => $"{Client?.CompanyName}\n{Client?.Email}\n{Client?.PhoneNumber}";


    [DisplayName("Chauffeur")]
    public Driver Driver { get; set; }
    [ForeignKey(nameof(Driver))]
    public string? IdDriver { get; set; }
    public string DriverDetails => $"{Driver?.FirstName} {Driver?.Name}\n{Driver?.Email}";


    [DisplayName("Contenu")]
    [Required]
    public string Content { get; set; }

    [Required]
    public Address LoadAddress { get; set; }
    [DisplayName("Addresse de chargement")]
    [Required]
    [ForeignKey(nameof(LoadAddress))]
    public string LoadAddressId { get; set; }
    public string LoadAddressDetails => $"{LoadAddress?.Street} {LoadAddress?.Number}, {LoadAddress?.Locality} {LoadAddress?.LocalityCode}";

    [DisplayName("Date de chargement")]
    [Required]
    public DateTime LoadDate { get; set; }

    [Required]
    public Address UnloadingAddress { get; set; }
    [DisplayName("Addresse de déchargement")]
    [Required]
    [ForeignKey(nameof(UnloadingAddress))]
    public string UnloadingAddressId { get; set; }
    public string UnloadAddressDetails => $"{UnloadingAddress?.Street} {UnloadingAddress?.Number}, {UnloadingAddress?.Locality} {UnloadingAddress?.LocalityCode}";

    [DisplayName("Date de déchargement")]
    [Required]
    public DateTime UnloadingDate { get; set; }

    [DisplayName("Statut")]
    [Required]
    public string Status { get; set; }

    [DisplayName("Véhicule")]
    public Vehicle Vehicle { get; set; }
    [ForeignKey(nameof(Vehicle))]
    public string? IdVehicle { get; set; }
    public string VehicleDetails => $"{Vehicle?.Brand} {Vehicle?.Model}\n{Vehicle?.VIN}";

    public Delivery()
    {

    }

    public Delivery(Client client, Driver driver, string content, Address loadAddress, DateTime loadDate, Address unloadingAddress, DateTime unloadingDate, string status, Vehicle vehicule)
    {
        Client = client;
        IdClient = client.Id;
        Driver = driver;/*
        IdDriver = driver?.Id;*/
        Content = content;
        LoadAddress = loadAddress;
        LoadAddressId = loadAddress.IdAddress;
        LoadDate = loadDate;
        UnloadingAddress = unloadingAddress;
        UnloadingAddressId = unloadingAddress.IdAddress;
        UnloadingDate = unloadingDate;
        Status = status;
        Vehicle = vehicule;
        IdVehicle = vehicule?.VIN;
    }
}
