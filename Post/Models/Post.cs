using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Post.Models
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Zawartość")]
        [Required(ErrorMessage = "Musisz podać zawartość wpisu!")]
        [StringLength(maximumLength: 150, ErrorMessage = "Post jest zbyt długi!")]
        public string Name { get; set; }
    }
}
