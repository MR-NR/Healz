using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Healz.Models;
using Healz.Data;

using Healz.Data;
using Healz.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;


namespace Healz.Areas.Doctor.Controllers
{


    [Authorize(Roles = "Doctor,Admin")]

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

        [Authorize(Roles = "Doctor")]
        public class DoctorController : Controller
        {
            private readonly ApplicationDbContext _context;
            private readonly IHostingEnvironment hostingEnvironment;
            public DoctorController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)


            {
                _context = context;
                this.hostingEnvironment = hostingEnvironment;

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

            [HttpPost]
            [ValidateAntiForgeryToken]

            public async Task<IActionResult> ProfileSettings(DoctorProfileViewModel model)
            {

                if (ModelState.IsValid)
                {
                    string uniqueFileName = null;

                    if (model.ProfilePhoto != null)
                    {
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        //uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfilePhoto.FileName;
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.ProfilePhoto.FileName);
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        model.ProfilePhoto.CopyTo(new FileStream(filePath, FileMode.Create));
                    }

                    DoctorProfile dp = new DoctorProfile
                    {
                        id = model.id,
                        Title = model.Title,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        SubTitle = model.SubTitle,
                        ProfilePhoto = uniqueFileName,
                        facebooklink = model.facebooklink,
                        twitterlink = model.twitterlink,
                        linkedin = model.linkedin,
                        googlepluslink = model.googlepluslink,
                        rsslink = model.rsslink,
                        youtubelink = model.youtubelink,
                        Specializations = model.Specializations,
                        Designation = model.Designation,
                        CompanyName = model.CompanyName,
                        startingDateExperience = model.startingDateExperience,
                        EndingDateExperience = model.EndingDateExperience,
                        DegreeName = model.DegreeName,
                        InstituteName = model.InstituteName,
                        StartingDateStudy = model.StartingDateStudy,
                        EndingDateStudy = model.EndingDateStudy,
                        Languages = model.Languages,
                        AwardTitle = model.AwardTitle,
                        AwardOccasion = model.AwardOccasion,
                        AwardDate = model.AwardDate,
                        MembershipTitle = model.MembershipTitle,
                        MembershipLocation = model.MembershipLocation,
                        MembershipDate = model.MembershipDate,
                        RegistrationID = model.RegistrationID,
                        RegistrationLocation = model.RegistrationLocation,
                        RegistrationDate = model.RegistrationDate,
                        AcceptedInsurance = model.AcceptedInsurance,
                        VideoIntroduction = model.VideoIntroduction
                    };

                    //DoctorProfile dc=new DoctorProfile { }
                    _context.Add(dp);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Insights));
                }
                return View(model);
            }
            public IActionResult ShowAppoinments()
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


        }
    }
}