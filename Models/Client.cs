﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Client : User
{
    [Required]
    public string CompanyName { get; set; }

    public Address CompanyAddress { get; set; }

    [ForeignKey(nameof(CompanyName))]
    public string CompanyAddressId { get; set; }
    [StringLength(50)]
    public string? Number { get; set; }

    public bool IsBadPayer { get; set; } = false;

    public ICollection<Delivery>? Deliveries { get; set; } = new List<Delivery>();

    public string Details => $"{CompanyName}\n{Email}\n{PhoneNumber}";
}
