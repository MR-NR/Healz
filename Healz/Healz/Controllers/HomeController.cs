using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Healz.Models;

namespace Healz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult HowItWorks()
        {
            return View();
        }
        public IActionResult Doctors()
        {
            return View();
        }
        public IActionResult Hospitals()
        {
            return View();
        }
        public IActionResult Spas()
        {
            return View();
        }
        public IActionResult Pharmacies()
        {
            return View();
        }
        public IActionResult Labs()
        {
            return View();
        }
        public IActionResult Fitness()
        {
            return View();
        }
        public IActionResult Clinics()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PrivacySetting()
        {
            return View();
        }
        public IActionResult securitysettings()
        {
            return View();
        }
       public IActionResult upgradepackage()
        {
            return View();
        }
        public IActionResult invoices()
        {
            return View();
        }   public IActionResult favoritlisting()
        {
            return View();
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
