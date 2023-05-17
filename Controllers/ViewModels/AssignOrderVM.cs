using HELMo_bilite.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HELMo_bilite.Controllers.ViewModels;

public class AssignOrderVM
{
    [Key]
    public int Id { get; set; }

    [DisplayName("Client")]
    public string? Client { get; set; }

    [DisplayName("Chauffeur")]
    public string? IdDriver { get; set; }

    [DisplayName("Contenu")]
    public string? Content { get; set; }

    [DisplayName("Addresse de chargement")]
    public string? LoadAddressId { get; set; }
    
    [DisplayName("Date de chargement")]
    public DateTime? LoadDate { get; set; }

    [DisplayName("Addresse de déchargement")]
    public string? UnloadingAddressId { get; set; }

    [DisplayName("Date de déchargement")]
    public DateTime? UnloadingDate { get; set; }

    [DisplayName("Statut")]
    public string? Status { get; set; }

    [DisplayName("Véhicule")]
    public string? IdVehicle { get; set; }

    public AssignOrderVM() { }

    public AssignOrderVM(int id, string client, string? idDriver, string content, string loadAddressId, DateTime loadDate, string unloadingAddressId, DateTime unloadingDate, string status, string? idVehicle)
    {
        Id = id;
        Client = client;
        IdDriver = idDriver;
        Content = content;
        LoadAddressId = loadAddressId;
        LoadDate = loadDate;
        UnloadingAddressId = unloadingAddressId;
        UnloadingDate = unloadingDate;
        Status = status;
        IdVehicle = idVehicle;
    }
}