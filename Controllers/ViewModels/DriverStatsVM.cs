namespace HELMo_bilite.Controllers.ViewModels
{
    public class DriverStatsVM
    {
        public string DriverName { get; set; }
        public int DeliveryCountTotal { get; set; }
        public int DeliveryInProgressCount { get; set; }
        public int DeliveryTerminedCount { get; set; }
    }
}
