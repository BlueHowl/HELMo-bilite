using HELMo_bilite.Models;

namespace HELMo_bilite.Controllers.ViewModels
{
    public class StatsVM
    {
        public List<ClientStatsVM> AllClientStats { get; set; }

        public List<DayStatsVM> AllDayStats { get; set; }

        public List<DriverStatsVM> AllDriverStats { get; set; }

    }
}
