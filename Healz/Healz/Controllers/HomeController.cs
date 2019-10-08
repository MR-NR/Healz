using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Healz.Models;
using Microsoft.AspNetCore.Authorization;

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
        public IActionResult Insights()
        {
            return View();
        }
   
        public IActionResult ProfileSettings()
        {
            return View();
        }
        
        public IActionResult JobLocations()
        {
            return View();
        }

        public IActionResult PrivateMasseges()
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
        

        public IActionResult Appointments()
        {
            return View();
        }
        public IActionResult Appoinmentsetting()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
     
       
        public ActionResult blogpostlist()
        {
            return View();
        }
        public ActionResult blogpostgrid()
        {
            return View();
        }
        public ActionResult blogpostdetail()
        {
            return View();
        }
        public ActionResult doctor_overview_detail()
        {
            return View();
        }
        public ActionResult E_404()
        {
            return View();
        }
        public ActionResult commingsoon()
        {
            return PartialView();
        }
        public ActionResult signin_signup()
        {
            return View();
        }

    }
}
