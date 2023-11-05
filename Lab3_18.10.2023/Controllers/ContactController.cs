﻿using Lab3_18._10._2023.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lab3_18._10._2023.Controllers
{
    public class ContactController : Controller
    {
        static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();

        public IActionResult Index()
        {
            return View(_contacts);
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
                int id = _contacts.Keys.Count != 0 ? _contacts.Keys.Max() : 0;
                model.Id = id + 1;
                _contacts.Add(model.Id, model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}

