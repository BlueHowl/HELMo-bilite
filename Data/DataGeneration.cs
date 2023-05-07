using Bogus;
using HELMo_bilite.Models;
using Microsoft.EntityFrameworkCore;

namespace HELMo_bilite.Data;

public class DataGeneration
{
    private ModelBuilder modelBuilder;

    private Faker<Driver> driverFaker = new Faker<Driver>()
            .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
            .RuleFor(p => p.Name, f => f.Name.LastName())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.Password, f => f.Internet.Password());

    private Faker<Dispatcher> dispatcherFaker = new Faker<Dispatcher>()
            .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
            .RuleFor(p => p.Name, f => f.Name.LastName())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.Password, f => f.Internet.Password());

    private Faker<Address> addressFaker = new Faker<Address>()
            .RuleFor(a => a.IdAddress, f => f.UniqueIndex.ToString())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.Number, f => f.Address.BuildingNumber())
            .RuleFor(a => a.Locality, f => f.Address.City())
            .RuleFor(a => a.LocalityCode, f => f.Address.ZipCode())
            .RuleFor(a => a.Country, f => f.Address.Country());

    private Faker<Client> clientFaker = new Faker<Client>()
                    .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
                    .RuleFor(p => p.Name, f => f.Name.LastName())
                    .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                    .RuleFor(p => p.Email, f => f.Internet.Email())
                    .RuleFor(p => p.Password, f => f.Internet.Password())
                    .RuleFor(p => p.Number, f => f.Phone.PhoneNumberFormat())
                    .RuleFor(p => p.CompanyName, f => f.Company.CompanyName());

    private Faker<Vehicule> truckFraker = new Faker<Vehicule>()
            .RuleFor(t => t.Plate, f => f.Vehicle.Vin())
            .RuleFor(t => t.Model, f => f.Vehicle.Model())
            .RuleFor(t => t.Brand, f => f.Vehicle.Manufacturer())
            .RuleFor(t => t.Payload, f => f.Random.Int(1, 40) * 1000);

    private List<License> license = new List<License>
        {
            new License{Id = 1,   Name = "B"},
            new License{Id = 2,   Name = "C"},
            new License{Id = 3,   Name = "CE"}
        };
    private List<Certification> certifications = new List<Certification>
        {
            new Certification { Id = 1, Name = "CESS" },
            new Certification { Id = 2, Name = "Bachelier" },
            new Certification { Id = 3, Name = "Master" }
        };


    public DataGeneration(ModelBuilder modelBuilder) {
        this.modelBuilder = modelBuilder;
    }
    public void Start()
    {
        //pour l'instant c'est plus ou moin les meme methodes mais ca va changer en fonction du model
        SeedDiver();
        SeedDispatcher();
        SeedClient();
        SeedAdmin();
        SeedTruck();
    }




    private void SeedAdmin()
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

    private void SeedDiver()
    {
        var drivers = new List<Driver>();        

        for (int i = 0; i < 10; i++)
        {
            var driver = driverFaker.Generate();
            int index = new Random().Next(certifications.Count);
            
            

            drivers.Add(driverFaker.Generate());
        }


        modelBuilder.Entity<License>().HasData(license);
        modelBuilder.Entity<Driver>().HasData(drivers);

    }

    private void SeedDispatcher()
    {
        var dispatchers = new List<Dispatcher>();
        

        for (int i = 0; i < 10; i++)
        {
            var dispatcher = dispatcherFaker.Generate();
            int index = new Random().Next(certifications.Count);
            dispatcher.IdCertification = certifications[index].Id;
            dispatchers.Add(dispatcher);
        }
        modelBuilder.Entity<Certification>().HasData(certifications);
        modelBuilder.Entity<Dispatcher>().HasData(dispatchers);

    }

    private void SeedClient()
    {

        var clients = new List<Client>();
        var addresses = new List<Address>();

        for (int i = 0; i < 10; i++)
        {
            addresses.Add(addressFaker.Generate());
        }        

        foreach (var address in addresses)
        {
            var client = clientFaker.Generate();
            client.CompanyAddressId = address.IdAddress;
            //client.CompanyAddress = address;
            clients.Add(client);
            
        }

        modelBuilder.Entity<Address>().HasData(addresses);
        modelBuilder.Entity<Client>().HasData(clients);

    }

    private void SeedTruck()
    {
        var trucks = new List<Vehicule>();

        

        for (int i = 0; i < 10; i++)
        {
            var tr = truckFraker.Generate();
            tr.IdLicenses = license[new Random().Next(license.Count)].Id;  
            trucks.Add(tr);
        }

        modelBuilder.Entity<Vehicule>().HasData(trucks);
    }
    
}
