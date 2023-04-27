using Microsoft.EntityFrameworkCore;

namespace HELMo_bilite.Models;

public class DeliveryDbContext : DbContext
{
    public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options) : base(options){}

    DbSet<Delivery> Deliveries { get; set; }
   

}
