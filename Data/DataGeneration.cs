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

    private Faker<Certification> certificationFaker = new Faker<Certification>()
            .RuleFor(c => c.Id, f => f.UniqueIndex)
            .RuleFor(c => c.Name, f => "diplome");

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

    private Faker<Truck> truckFraker = new Faker<Truck>()
            .RuleFor(t => t.Plate, f => f.Vehicle.Vin())
            .RuleFor(t => t.Model, f => f.Vehicle.Model())
            .RuleFor(t => t.Brand, f => f.Vehicle.Manufacturer())
            //.RuleFor(t => t.Licenses, f =>  )
            .RuleFor(t => t.Payload, f => f.Random.Int(1, 40) * 1000);



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
        //SeedTruck();
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
            drivers.Add(driverFaker.Generate());
        }

        modelBuilder.Entity<Driver>().HasData(drivers);

    }

    private void SeedDispatcher()
    {
        var dispatchers = new List<Dispatcher>();
        var certifications = new List<Certification>();

        /*var certificationFaker = new Faker<Certification>()
            .RuleFor(c => c.Id, f => f.UniqueIndex)
            .RuleFor(c => c.Name, f => "diplome");


        var dispatcherFaker = new Faker<Dispatcher>()
            .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
            .RuleFor(p => p.Name, f => f.Name.LastName())
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.Email, f => f.Internet.Email())
            .RuleFor(p => p.Password, f => f.Internet.Password());*/

        for (int i = 0; i < 10; i++)
        {
            dispatchers.Add(dispatcherFaker.Generate());
        }

        modelBuilder.Entity<Dispatcher>().HasData(dispatchers);

    }

    private void SeedClient()
    {

        var clients = new List<Client>();
        var addresses = new List<Address>();

       /* var addressFaker = new Faker<Address>()
            .RuleFor(a => a.IdAddress, f => f.UniqueIndex.ToString())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.Number, f => f.Address.BuildingNumber())
            .RuleFor(a => a.Locality, f => f.Address.City())
            .RuleFor(a => a.LocalityCode, f => f.Address.ZipCode())
            .RuleFor(a => a.Country, f => f.Address.Country());*/

        for (int i = 0; i < 10; i++)
        {
            addresses.Add(addressFaker.Generate());
        }
        modelBuilder.Entity<Address>().HasData(addresses);

       /* var clientFaker = new Faker<Client>()
                    .RuleFor(u => u.Matricule, f => f.UniqueIndex.ToString())
                    .RuleFor(p => p.Name, f => f.Name.LastName())
                    .RuleFor(p => p.FirstName, f => f.Name.FirstName())
                    .RuleFor(p => p.Email, f => f.Internet.Email())
                    .RuleFor(p => p.Password, f => f.Internet.Password())
                    .RuleFor(p => p.Number, f => f.Phone.PhoneNumberFormat())
                    .RuleFor(p => p.CompanyName, f => f.Company.CompanyName());*/


    }

    private void SeedTruck()
    {
        var trucks = new List<Truck>();
        



        for (int i = 0; i < 10; i++)
        {
            trucks.Add(truckFraker.Generate());
        }

        modelBuilder.Entity<Truck>().HasData(trucks);
    }
}
