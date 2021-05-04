using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppSherzan.Models;

namespace FirstResponsiveWebAppSherzan.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(EndBirthdateModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateEndBirthdate();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}