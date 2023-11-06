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
        public required DateTime Date { get; set; }

        [Display(Name = "Tagi")]
        [Required(ErrorMessage = "Musisz podać tag autora wpisu!")]
        public required string Tags { get; set; }

        [Display(Name = "Komentarz")]
        [Required(ErrorMessage = "Komentarz jest wymagany!")]
        public required string Comment { get; set; }

        [Display(Name = "Temat")]
        [Required(ErrorMessage = "Musisz podać temat wpisu!")]
        public required Topic Topic {  get; set; }


    }
}
