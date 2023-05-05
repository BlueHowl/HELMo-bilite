﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HELMo_bilite.Models;
public class Certification
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}
