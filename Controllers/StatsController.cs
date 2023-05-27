using HELMo_bilite.Controllers.ViewModels;
using HELMo_bilite.Data;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using static HELMo_bilite.Models.Delivery;

namespace HELMo_bilite.Controllers
{
    [Authorize(Roles ="admin")]
    public class StatsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public StatsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {

            var statsVM = new StatsVM
            {
                AllClientStats = GetClientStats(),
                AllDayStats = GetDayStats(),
                AllDriverStats = GetDriverStats(),

            };
            return View(statsVM);
        }


        [HttpPost]
        public ActionResult GetStatPerMonthDriver(int year, string[] matricules)
        {

            var listDriverStat = new List<StatsPerMonthDriver>();
            foreach(var mat in matricules)
            {
                listDriverStat.Add(GetStatDriver(year, mat));
            }


            return Json(listDriverStat);
        }

        private StatsPerMonthDriver GetStatDriver(int year, string matricule)
        {
            var idDriver  = _dbContext.Drivers.FirstOrDefault(d => d.Matricule == matricule).Id;
            var allDeliveryOfYear = _dbContext.Deliveries.Where(
                d => (d.LoadDate.Year == year || d.UnloadingDate.Year == year) 
                        && d.IdDriver == idDriver).ToList();

            var statPerMonth = new StatsPerMonthDriver();
            statPerMonth.Matricule = matricule;
            statPerMonth.StatsPerMonth = new List<StatsPerMonth>();
            for (int i = 0; i < 12; i++)
            {
                var month = i + 1;
                var deliverysOfMonth = allDeliveryOfYear.Where(d => d.LoadDate.Month == month || d.UnloadingDate.Month == month).ToList();
                var stat = new StatsPerMonth
                {
                    Month = month,
                    Count = allDeliveryOfYear.Where(d => d.LoadDate.Month == month || d.UnloadingDate.Month == month).Count(),
                };
                statPerMonth.StatsPerMonth.Add(stat);
            }
            return statPerMonth;

        }





        private List<ClientStatsVM> GetClientStats()
        {
            var allClient = _dbContext.Clients.Include(c => c.Deliveries).ToList();
            List<ClientStatsVM> clientStats = new List<ClientStatsVM>();
            foreach (var client in allClient)
            {
                var clientStat = new ClientStatsVM
                {
                    CompanyName = client.CompanyName,
                    DeliveryCountTotal = client.Deliveries.Count,
                    DeliveryWaitingCount = client.Deliveries.Count(d => d.Status == State.Waiting),
                    DeliveryInProgressCount = client.Deliveries.Count(d => d.Status == State.InProgress),
                    DeliveryTerminedCount = client.Deliveries.Count(d => d.Status == State.IsEnded)
                };
                clientStats.Add(clientStat);
            }

            return clientStats;
        }
        private List<DayStatsVM> GetDayStats()
        {
            var allDeliveries = _dbContext.Deliveries.ToList();
            List<DayStatsVM> dayStats = new List<DayStatsVM>();
            HashSet<DateTime> addedDates = new HashSet<DateTime>(); // Ensemble pour stocker les dates ajoutées

            foreach (var delivery in allDeliveries)
            {
                if (!addedDates.Contains(delivery.LoadDate))
                {
                    var deliveriesBetweenDay = allDeliveries.Where(d => IsDaybetween(delivery.LoadDate, d.LoadDate, d.UnloadingDate));

                    //date depart
                    var dayStat = new DayStatsVM
                    {
                        Day = delivery.LoadDate,
                        DeliveryCount = deliveriesBetweenDay.Count(),
                        DeliveryStartCount = deliveriesBetweenDay.Count(d => d.LoadDate == delivery.LoadDate),
                        DeliveryInProgressCount = deliveriesBetweenDay.Count(d => d.LoadDate != delivery.LoadDate && d.UnloadingDate != delivery.LoadDate),
                        DeliveryTerminedCount = deliveriesBetweenDay.Count(d => d.UnloadingDate == delivery.LoadDate)
                    };
                    dayStats.Add(dayStat);
                    addedDates.Add(delivery.LoadDate); // Ajouter la date à l'ensemble des dates ajoutées
                }

                if (!addedDates.Contains(delivery.UnloadingDate))
                {
                    var deliveriesBetweenDay = allDeliveries.Where(d => IsDaybetween(delivery.UnloadingDate, d.LoadDate, d.UnloadingDate));
                    var dayStat2 = new DayStatsVM
                    {
                        Day = delivery.UnloadingDate,
                        DeliveryCount = deliveriesBetweenDay.Count(),
                        DeliveryStartCount = deliveriesBetweenDay.Count(d => d.LoadDate == delivery.UnloadingDate),
                        DeliveryInProgressCount = deliveriesBetweenDay.Count(d => d.LoadDate != delivery.UnloadingDate && d.UnloadingDate != delivery.UnloadingDate),
                        DeliveryTerminedCount = deliveriesBetweenDay.Count(d => d.UnloadingDate == delivery.UnloadingDate)
                    };
                    dayStats.Add(dayStat2);
                    addedDates.Add(delivery.UnloadingDate); // Ajouter la date à l'ensemble des dates ajoutées
                }
            }

            dayStats.Sort((d, d2) => d.Day.CompareTo(d2.Day));
            return dayStats;
        }
        private List<DriverStatsVM> GetDriverStats()
        {
            var allDrivers = _dbContext.Drivers.Include(d => d.Deliverys).ToList();
            List<DriverStatsVM> driverStats = new List<DriverStatsVM>();
            foreach (var driver in allDrivers)
            {
                var driverStat = new DriverStatsVM
                {
                    Matricule = driver.Matricule,
                    DriverName = driver.FirstName + " " + driver.Name,
                    DeliveryCountTotal = driver.Deliverys.Count,
                    DeliveryInProgressCount = driver.Deliverys.Count(d => d.Status == State.InProgress),
                    DeliveryTerminedCount = driver.Deliverys.Count(d => d.Status == State.IsEnded)
                };
                driverStats.Add(driverStat);
            }
            return driverStats;

        }

        private bool IsDaybetween(DateTime day, DateTime start, DateTime end)
        {
            return day >= start && day <= end;
        }

    }
}
