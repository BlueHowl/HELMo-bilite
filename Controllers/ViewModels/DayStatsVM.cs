namespace HELMo_bilite.Controllers.ViewModels
{
    public class DayStatsVM
    {
        public DateTime Day { get; set; }
        public int DeliveryCount { get; set; }
        public int DeliveryStartCount { get; set; }
        public int DeliveryInProgressCount { get; set; }
        public int DeliveryTerminedCount { get; set; }
    }
}
