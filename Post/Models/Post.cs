using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Post.Models
{
    public class PostClass
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Zawartość")]
        [Required(ErrorMessage = "Musisz podać zawartość wpisu!")]
        [StringLength(maximumLength: 150, ErrorMessage = "Post jest zbyt długi!")]
        public string Content { get; set; }


        [Display(Name = "Autor wpisu")]
        [Required(ErrorMessage = "Musisz podać nick autora wpisu!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Nick jest zbyt długi!")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Musisz podać datę wpisu!")]
        public DateTime Date { get; set; }

        public string Tags { get; set; }

        public string Comment { get; set; }

    }
}
