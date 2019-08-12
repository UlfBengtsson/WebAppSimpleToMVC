using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppSimpleToMVC.Models;

namespace WebAppSimpleToMVC.Controllers
{
    public class CarsController : Controller
    {
        static List<Car> carList = new List<Car>();

        public IActionResult Index()
        {
            return View(carList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car)
        {
            if(ModelState.IsValid)
            {
                carList.Add(car);
                return RedirectToAction("Index");
            }

            return View(car);
        }
    }
}