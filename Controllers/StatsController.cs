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
                AllClientStats  = GetClientStats()
            };
            return View(statsVM);
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
                    DeliveryInProgressCount = client.Deliveries.Count(d => d.Status == State.InProgress),
                    DeliveryTerminedCount = client.Deliveries.Count(d => d.Status == State.IsEnded)
                };
                clientStats.Add(clientStat);
            }

            return clientStats;
        }

    }
}
