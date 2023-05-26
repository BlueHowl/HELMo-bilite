using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HELMo_bilite.Controllers.ViewModels;

public class TerminateDeliveryVM
{
    [Key]
    public int Id { get; set; }

    [DisplayName("Client")]
    public string? Client { get; set; }

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

    [DisplayName("Commentaire")]
    public string? Comment { get; set; }

    [DisplayName("Raison")]
    public string? Reason { get; set; }

    [DisplayName("Véhicule")]
    public string? IdVehicle { get; set; }

    public TerminateDeliveryVM() { }

    public TerminateDeliveryVM(int id, string client, string content, string loadAddressId, DateTime loadDate, string unloadingAddressId, DateTime unloadingDate, string status, string? comment, string? reason, string idVehicle)
    {
        Id = id;
        Client = client;
        Content = content;
        LoadAddress = loadAddressId;
        LoadDate = loadDate;
        UnloadingAddress = unloadingAddressId;
        UnloadingDate = unloadingDate;
        Status = status;
        Comment = comment;
        Reason = reason;
        IdVehicle = idVehicle;
    }

}