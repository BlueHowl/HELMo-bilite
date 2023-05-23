namespace HELMo_bilite.Controllers.ViewModels
{
    public class ClientStatsVM
    {
        public string CompanyName { get; set; }

        public int DeliveryCountTotal { get; set; }

        public int DeliveryInProgressCount { get; set; }
        public int DeliveryTerminedCount { get; set; }
    }
}
