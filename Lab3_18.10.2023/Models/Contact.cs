using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3_18._10._2023.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Musisz podać imię!")]
        [StringLength(maximumLength:50, ErrorMessage ="Przekroczono limit znaków!")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
    }
}
