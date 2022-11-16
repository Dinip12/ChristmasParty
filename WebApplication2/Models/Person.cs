﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    [Table("People")]
    public class Person
    {        
            [Key]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string PhoneNumber { get; set; }

            [Required]
            public string Email { get; set; }
            [Required]
            public bool IsAttending { get; set; }        
    }
}
