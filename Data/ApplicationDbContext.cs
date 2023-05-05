using Bogus;
using HELMo_bilite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;

namespace HELMo_bilite.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Dispatcher> Dispatchers { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Admin> Admins { get; set; }

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


       /* modelBuilder.Entity<Client>()
            .HasOne(c => c.CompanyAddress)
            .WithMany()
            .HasForeignKey(c => c.CompanyAddressId)
            .IsRequired();*/

        Seed(modelBuilder);

        /*//many to many
        modelBuilder.Entity<Student>()
            .HasMany<Course>(c => c.Courses)
            .WithMany(t => t.Students)
            .UsingEntity(sc => sc.ToTable("StudentCourse"));*/
    }


    private void Seed(ModelBuilder modelBuilder)
    {         
        //pour l'instant c'est plus ou moin les meme methodes mais ca va changer en fonction du model
        SeedDiver(modelBuilder);
        SeedDispatcher(modelBuilder);
        SeedClient(modelBuilder);
        SeedAdmin(modelBuilder);

    }

    private void SeedAdmin(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>().HasData(new Admin
        {
            Matricule = "-1",
            Name = "Admin",
            FirstName = "Admin",
            Email = "admin@admin.com",
            Password = "admin",

        });
    }

    private void SeedDiver(ModelBuilder modelBuilder)
    {
        var drivers = new List<Driver>();
        var driverFaker = new Faker<Driver>()
            .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
            .RuleFor(p => p.Name, f => f.Name.LastName())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.Password, f => f.Internet.Password());

        for (int i = 0; i < 10; i++)
        {
            drivers.Add(driverFaker.Generate());
        }

        modelBuilder.Entity<Driver>().HasData(drivers);

    }

    private void SeedDispatcher(ModelBuilder modelBuilder)
    {
        var dispatchers = new List<Dispatcher>();
        var dispatcherFaker = new Faker<Dispatcher>()
            .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
            .RuleFor(p => p.Name, f => f.Name.LastName())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.Password, f => f.Internet.Password());

        for (int i = 0; i < 10; i++)
        {
            dispatchers.Add(dispatcherFaker.Generate());
        }

        modelBuilder.Entity<Dispatcher>().HasData(dispatchers);

    }

    private void SeedClient(ModelBuilder modelBuilder)
    {

        var clients = new List<Client>();
        var addresses = new List<Address>();

        var addressFaker = new Faker<Address>()
            .RuleFor(a => a.IdAddress, f => f.UniqueIndex.ToString())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.Number, f => f.Address.BuildingNumber())
            .RuleFor(a => a.Locality, f => f.Address.City())
            .RuleFor(a => a.LocalityCode, f => f.Address.ZipCode())
            .RuleFor(a => a.Country, f => f.Address.Country());

        for (int i = 0; i < 10; i++)
        {
            addresses.Add(addressFaker.Generate());
        }
        modelBuilder.Entity<Address>().HasData(addresses);

        var clientFaker = new Faker<Client>()
                    .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
                    .RuleFor(p => p.Name, f => f.Name.LastName())
                    .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                    .RuleFor(p => p.Email, f => f.Internet.Email())
                    .RuleFor(p => p.Password, f => f.Internet.Password())
                    .RuleFor(p => p.Number, f => f.Phone.PhoneNumberFormat())
                    .RuleFor(p => p.CompanyName, f => f.Company.CompanyName());


        foreach (var address in addresses)
        {
            var client = clientFaker.Generate();
            client.CompanyAddressId = address.IdAddress;
            //client.CompanyAddress = address;
            clients.Add(client);
        }
        modelBuilder.Entity<Client>().HasData(clients);

        /*
                var clientFaker = new Faker<Client>()
                    .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
                    .RuleFor(p => p.Name, f => f.Name.LastName())
                    .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                    .RuleFor(p => p.Email, f => f.Internet.Email())
                    .RuleFor(p => p.Password, f => f.Internet.Password())
                    .RuleFor(p => p.Number, f => f.Phone.PhoneNumberFormat())
                    .RuleFor(p => p.CompanyName, f => f.Company.CompanyName());

                var faker = new Faker();

                for (int i = 0; i < 10; i++)
                {
                    var ad = addressFaker.Generate();

                    addresses.Add(ad);

                    var client = new Client
                    {
                        Matricule = faker.UniqueIndex.ToString(),
                        Name = faker.Name.LastName(),
                        FirstName = faker.Name.FirstName(),
                        Email = faker.Internet.Email(),
                        Password = faker.Internet.Password(),
                        Number = faker.Phone.PhoneNumberFormat(),
                        CompanyName = faker.Company.CompanyName(),
                        CompanyAddress = ad
                    };

                    clients.Add(client);
                }

                //modelBuilder.Entity<Address>().HasData(addresses);

                modelBuilder.Entity<Client>().HasData(clients);
        */


    }
}