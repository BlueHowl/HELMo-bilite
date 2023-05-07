using Bogus;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using System.Reflection.Emit;

namespace HELMo_bilite.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Driver> Drivers { get; set; }//fait
    public DbSet<Dispatcher> Dispatchers { get; set; }//fait
    public DbSet<Client> Clients { get; set; }//fait
    public DbSet<Admin> Admins { get; set; }//fait
    public DbSet<Vehicule> Trucks { get; set; }//fait
    public DbSet<Certification> Certifications { get; set; }//fait
    public DbSet<License> Licenses { get; set; }//fait

    public DbSet<Delivery> Deliveries { get; set; }

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


        modelBuilder.Entity<Driver>()
            .HasMany(l => l.Licenses)
            .WithMany(d => d.Drivers)
            .UsingEntity(t => t.ToTable("DriverLicense"));      
        

       



        //apres tout
        //doit etre la dernier ligne de OnModelCreating
        new DataGeneration(modelBuilder).Start();

    }

}