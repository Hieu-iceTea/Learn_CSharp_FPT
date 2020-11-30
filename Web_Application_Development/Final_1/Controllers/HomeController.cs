using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage mess = new AppMessage() { Message = "Hello MVC" };

            return View(mess);
        }

        [HttpPost]
        public IActionResult Index(AppMessage mess)
        {
            ViewBag.Message = "Message Changed";

            return View(mess);
        }
    }
}
