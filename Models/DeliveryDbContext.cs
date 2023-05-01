using Microsoft.EntityFrameworkCore;
using HELMo_bilite.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class DeliveryDbContext : DbContext
{
    public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options) : base(options){}
    
   
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Dispatcher> Dispatchers { get; set; }
    public DbSet<Client> Licenses { get; set; }


    public DbSet<User> Users { get; set; }
    //public DbSet<Delivery> Deliveries { get; set; }

   
    //public DbSet<HELMo_bilite.Models.Delivery>? Delivery { get; set; }
    //public DbSet<Delivery> Deliveries { get; set; }



}
