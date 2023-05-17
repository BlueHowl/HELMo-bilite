using Bogus.DataSets;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HELMo_bilite.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public static readonly string RoleDriver = "driver";
    public static readonly string RoleDispatcher = "dispatcher";
    public static readonly string RoleClient = "client";
    public static readonly string RoleAdmin = "admin";

    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Dispatcher> Dispatchers { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Models.Vehicle> Vehicles { get; set; }
    public DbSet<Certification> Certifications { get; set; }
    public DbSet<License> Licenses { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<HelmoMember> HelmoMembers { get; set; }
    public DbSet<Models.Address> Addresses { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        base.OnConfiguring(optionsBuilder);

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Driver>()
            .HasMany(l => l.Licenses)
            .WithMany(d => d.Drivers)
            .UsingEntity(t => t.ToTable("DriverLicense"));


        modelBuilder.Entity<Delivery>()
            .HasOne(d => d.LoadAddress)
            .WithOne()
            .HasForeignKey<Models.Address>("LoadAddressId")
            .IsRequired(false);

        modelBuilder.Entity<Delivery>()
           .HasOne(d => d.UnloadingAddress)
           .WithOne()
           .HasForeignKey<Models.Address>("UnloadingAddressId")
           .IsRequired(false);


        modelBuilder.Entity<License>().HasData(new License { Id = 1, Name = "B" });
        modelBuilder.Entity<License>().HasData(new License { Id = 2, Name = "C (camion)" });
        modelBuilder.Entity<License>().HasData(new License { Id = 3, Name = "CE (camion avec remorque)" });

        modelBuilder.Entity<Certification>().HasData(new Certification { Id = 1, Name = "Pas de diplome" });
        modelBuilder.Entity<Certification>().HasData(new Certification { Id = 2, Name = "CESS" });
        modelBuilder.Entity<Certification>().HasData(new Certification { Id = 3, Name = "Bachlier" });
        modelBuilder.Entity<Certification>().HasData(new Certification { Id = 4, Name = "Master" });



    }

}