using HELMo_bilite.Models;

namespace HELMo_bilite.Controllers.ViewModels
{
    public record ClientOrderVM(string Content, string LoadAddressId, string UnloadingAddressId, DateTime LoadDate, DateTime UnloadingDate);
}