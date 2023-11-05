using Microsoft.AspNetCore.Mvc;
using Lab3_B.Models;
using System.Reflection;

namespace Lab3_B.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        static int id = 1;
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
           if (ModelState.IsValid)
           {
               model.Id = id++;
                _contactService.Add(model);
               return RedirectToAction("Index");
           }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            _contactService.DeleteByID(model.Id);
            return RedirectToAction("Index");
        }
    }
}
 