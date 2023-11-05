﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3_B.Models
{
    public enum Priority
    {
        [Display(Name="Niski")]
        Low,
        [Display(Name = "Normalny")]
        Normal,
        [Display(Name = "Pilny")]
        Urgent
    }

    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name="Imię")]
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength:50, ErrorMessage = "Imię jest niepoprawne!")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Adres email")]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime? Birth { get; set; }
        [Display(Name="Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
