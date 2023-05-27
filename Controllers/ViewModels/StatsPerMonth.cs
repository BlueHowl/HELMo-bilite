namespace HELMo_bilite.Controllers.ViewModels
{
    public class StatsPerMonth
    {
        public int Month { get; set; }
        public int Count { get; set; }
    }
    public class StatsPerMonthDriver
    {
        public string Matricule { get; set; }
        public List<StatsPerMonth> StatsPerMonth { get; set; }
    }
}
