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
    [Required(ErrorMessage = "Veuillez sélectionner un chauffeur !")]
    public string IdDriver { get; set; }

    [DisplayName("Contenu")]
    public string? Content { get; set; }

    [DisplayName("Addresse de chargement")]
    public string? LoadAddress { get; set; }
    
    [DisplayName("Date de chargement")]
    public DateTime? LoadDate { get; set; }

    [DisplayName("Addresse de déchargement")]
    public string? UnloadingAddress { get; set; }

    [DisplayName("Date de déchargement")]
    public DateTime? UnloadingDate { get; set; }

    [DisplayName("Statut")]
    public string? Status { get; set; }

    [DisplayName("Véhicule")]
    [Required(ErrorMessage = "Veuillez séléctionner une véhicule !")]
    public string IdVehicle { get; set; }

    public AssignOrderVM() { }

    public AssignOrderVM(int id, string client, string? idDriver, string content, string loadAddressId, DateTime loadDate, string unloadingAddressId, DateTime unloadingDate, string status, string? idVehicle)
    {
        Id = id;
        Client = client;
        IdDriver = idDriver;
        Content = content;
        LoadAddress = loadAddressId;
        LoadDate = loadDate;
        UnloadingAddress = unloadingAddressId;
        UnloadingDate = unloadingDate;
        Status = status;
        IdVehicle = idVehicle;
    }
}