using Bogus;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using System.Reflection.Emit;

namespace HELMo_bilite.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Dispatcher> Dispatchers { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Admin> Admins { get; set; }

    public DbSet<Truck> Trucks { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        base.OnConfiguring(optionsBuilder);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .ToTable("User")
            .HasDiscriminator<string>("Role")
            .HasValue<Driver>("Driver")
            .HasValue<Dispatcher>("Dispatcher")
            .HasValue<Client>("Client")
            .HasValue<Admin>("Admin");




        //apres tout
        //doit etre la dernier ligne de OnModelCreating
        new DataGeneration(modelBuilder).Start();

    }

}