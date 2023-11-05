using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Post.Models
{
    public enum Topic
    {
        [Display(Name = "Zwykły")]
        Default,
        [Display(Name = "Recenzja")]
        Review,
        [Display(Name = "Informacja")]
        Info, 
        [Display(Name = "Prośba")]
        Request
    }

    public class PostClass 
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Zawartość")]
        [Required(ErrorMessage = "Musisz podać zawartość wpisu!")]
        [StringLength(maximumLength: 150, ErrorMessage = "Post jest zbyt długi!")]
        public required string Content { get; set; }


        [Display(Name = "Autor wpisu")]
        [Required(ErrorMessage = "Musisz podać nick autora wpisu!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Nick jest zbyt długi!")]
        public required string Author { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Musisz podać datę wpisu!")]
        public DateTime Date { get; set; }

        public required string Tags { get; set; }

        public required string Comment { get; set; }
        public required Topic Topic {  get; set; }
    }
}
