using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;

public class Address
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key] public string IdAddress { get; set; }
    [Required][StringLength(100)] public string Locality { get; set; }
    [Required][StringLength(5)] public string Number { get; set; }
    [Required][StringLength(100)] public string Street { get; set; }
    [Required][StringLength(10)] public string LocalityCode { get; set; }
    [Required][StringLength(100)] public string Country { get; set; }

    public Address() { }

    public Address(string locality, string number, string street, string localityCode, string country)
    {
        Locality = locality;
        Number = number;
        Street = street;
        LocalityCode = localityCode;
        Country = country;
    }


    
}
