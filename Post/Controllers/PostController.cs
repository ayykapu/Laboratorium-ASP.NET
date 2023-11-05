using Microsoft.AspNetCore.Mvc;
using Post.Models;

namespace Post.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
             _postService = postService;
        }
        public IActionResult Index()
        {
            return View(_postService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PostClass model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

    }
}
