using Microsoft.EntityFrameworkCore;

namespace HELMo_bilite.Models;

public class DeliveryDbContext : DbContext
{
    public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options) : base(options){}

   
    public DbSet<Driver> Drivers { get; set; }
    //public DbSet<Delivery> Deliveries { get; set; }



}
