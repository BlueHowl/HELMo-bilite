namespace HELMo_bilite.Models
{
    public class Delivery
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string DispatcherId { get; set; }
        public string DriverId { get; set; }
        public string Content { get; set; }
        public Adress LoadAdress { get; set; }
        public Adress UnloadingAdress { get; set; }
        public DateTime LoadDate { get; set; }
        public DateTime UnloadingDate { get; set; }

    }
}
