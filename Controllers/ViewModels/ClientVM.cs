namespace HELMo_bilite.Controllers.ViewModels
{
    public class ClientVM
    {
        public string? PictureSrc { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string CompanyAddress { get; set; }

        public string Id { get; set; }

        public bool IsBadPayer { get; set; }

        public bool HasDelivery { get; set; }
    }
}
