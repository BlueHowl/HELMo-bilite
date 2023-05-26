using HELMo_bilite.Controllers.ViewModels;
using HELMo_bilite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static HELMo_bilite.Models.Delivery;

namespace HELMo_bilite.Controllers
{
    public class StatsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public StatsController( ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       
        public IActionResult Index()
        {
            
            var statsVM = new StatsVM
            {
                AllClientStats  = GetClientStats(),
                AllDayStats = GetDayStats(),
                AllDriverStats = GetDriverStats(),

            };
            return View(statsVM);
        }

        [HttpPost]
        public ActionResult GetClientStatsAjax(string sortParam)
        {
            var clientStats = GetClientStats();

            switch (sortParam)
            {
                case "CompanyName":
                    clientStats.Sort((c, c2) => c.CompanyName.CompareTo(c2.CompanyName));
                    break;
                case "DeliveryCountTotal":
                    clientStats.Sort((c, c2) => c.DeliveryCountTotal.CompareTo(c2.DeliveryCountTotal));
                    break;
            }
            return Json(clientStats);
        }
        [HttpPost]
        public ActionResult GetDriverStatsAjax(string matricule)
        {
            var driver = _dbContext.Drivers.Include(d => d.Deliverys).FirstOrDefault(d=> d.Matricule == matricule);
            
            List<StatsDriverPerDayVM> statsDriverPerDay = new List<StatsDriverPerDayVM>();

            foreach (var delivery in driver.Deliverys)
            {
                if (!statsDriverPerDay.Exists(d => d.Day == delivery.LoadDate))
                {
                    var deliveriesBetweenDay = driver.Deliverys.Where(d => IsDaybetween(delivery.LoadDate, d.LoadDate, d.UnloadingDate));

                    //date depart
                    var dayStat = new StatsDriverPerDayVM
                    {
                        Day = delivery.LoadDate,
                        DeliveryCount = deliveriesBetweenDay.Count(),
                    };
                    statsDriverPerDay.Add(dayStat);
                }

                if (!statsDriverPerDay.Exists(d => d.Day == delivery.UnloadingDate))
                {
                    var deliveriesBetweenDay = driver.Deliverys.Where(d => IsDaybetween(delivery.UnloadingDate, d.LoadDate, d.UnloadingDate));
                    var dayStat2 = new StatsDriverPerDayVM
                    {
                        Day = delivery.UnloadingDate,
                        DeliveryCount = deliveriesBetweenDay.Count()
                    };
                    statsDriverPerDay.Add(dayStat2);
                }


            }
           
            
            return Json(new
            {
                driverMatricul = driver.Matricule,
                deliveryPerDayCount = Json(statsDriverPerDay)
               
            });
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
            foreach (var delivery in allDeliveries)
            {
                if(!dayStats.Exists(d=> d.Day == delivery.LoadDate))
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
                }

               

                if (!dayStats.Exists(d => d.Day == delivery.UnloadingDate))
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
                }
                
            }
            dayStats.Sort((d, d2) => d.Day.CompareTo(d2.Day));


            return dayStats; 
        }
        [HttpPost]
        private List<DriverStatsVM> GetDriverStats()
        {
            var allDrivers = _dbContext.Drivers.Include(d => d.Deliverys).ToList();
            List<DriverStatsVM> driverStats = new List<DriverStatsVM>();
            foreach (var driver in allDrivers)
            {
                var driverStat = new DriverStatsVM
                {
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
