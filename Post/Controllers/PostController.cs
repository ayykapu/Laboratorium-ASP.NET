using Microsoft.AspNetCore.Mvc;

namespace Post.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
