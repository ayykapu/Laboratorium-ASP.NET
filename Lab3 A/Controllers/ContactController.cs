using Microsoft.AspNetCore.Mvc;

namespace Lab3_A.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
