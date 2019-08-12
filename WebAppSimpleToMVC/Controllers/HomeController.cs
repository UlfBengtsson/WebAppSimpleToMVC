using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppSimpleToMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cars()
        {
            return View();
        }

        public IActionResult Pets()
        {
            string[] pets = { "Cats", "Dogs", "Fish" };
            ViewBag.Pets = pets;

            return View();
        }

        [HttpGet]
        public IActionResult CurrencyConverter()
        {
            ViewBag.Color = BootColor();

            return View("Currency");
        }

        [HttpPost]
        public IActionResult CurrencyConverter(int skr)
        {
            ViewBag.Color = BootColor();

            ViewBag.SKR = skr;
            ViewBag.USD = skr * 0.1;

            return View("Currency");
        }

        [HttpGet]
        public IActionResult PickColor()
        {
            ViewBag.Color = BootColor();

            return View();
        }

        [HttpPost]
        public IActionResult PickColor(string SelectedColor)
        {
            if (SelectedColor == "Dark")
            {
                HttpContext.Session.SetString("BootColor", "Dark");
            }
            else if (SelectedColor == "Light")
            {
                HttpContext.Session.SetString("BootColor", "Light");
            }


            ViewBag.Color = BootColor();

            return View();
        }

        private string BootColor()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("BootColor")))
            {
                return "Dark";
            }
            else
            {
                return HttpContext.Session.GetString("BootColor");
            }
        }
    }
}