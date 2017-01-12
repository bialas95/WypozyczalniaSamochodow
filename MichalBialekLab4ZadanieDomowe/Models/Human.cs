﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe.Models
{
    public abstract class Human
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public long Pesel { get; set; }
        [Required]
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public long DrivingLicense { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
    }
}
