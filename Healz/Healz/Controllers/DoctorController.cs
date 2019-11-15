using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Healz.Models;
using Healz.Data;

namespace Healz.Controllers
{

    [Authorize(Roles = "Doctor,Admin") ]

    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext appplicationDbContext;
        public DoctorController(ApplicationDbContext _applicationDbContext)
        {
            appplicationDbContext = _applicationDbContext;
        }
       
            public IActionResult Insights()
            {
                return View();
            }
            public IActionResult InsightsTwo()
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
            }
            public IActionResult favoritlisting()
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
            public IActionResult ShowAppoinments()
            {
            return View();
            }

        
       
    }
}