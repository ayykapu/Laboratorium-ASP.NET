using Microsoft.AspNetCore.Mvc;
using Post.Models;

namespace Post.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
