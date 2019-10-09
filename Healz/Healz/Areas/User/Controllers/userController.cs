using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Healz.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace Healz.Areas.user.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
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

        public IActionResult Appointments()
        {
            return View();
        }
        public IActionResult Appoinmentsetting()
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



        [HttpGet]
        public IActionResult ExternalLogin(string provider)
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("ExternalLoginCallback"),
                Items = { { "Scheme", provider } }
            };
            return Challenge(properties, provider);
        }
        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback()
        {
            var result = await HttpContext.AuthenticateAsync(IdentityConstants.ExternalScheme);
            var externalUserId = result.Principal.FindFirstValue("sub")
                ?? result.Principal.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? throw new Exception("Cannot find External user id");
            var provider = result.Properties.Items["Scheme"];
            var user = await userManager.FindByLoginAsync(provider, externalUserId);
            if (user == null)
            {
                var email = result.Principal.FindFirstValue("email")
                    ?? result.Principal.FindFirstValue(ClaimTypes.Email);
                if (email != null)
                {
                    user = await userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new ApplicationUser { UserName = email, Email = email };
                        await userManager.CreateAsync(user);

                    }
                    await userManager.AddLoginAsync(user, new UserLoginInfo(provider, externalUserId, provider));
                }
            }
            if (user == null) return View("Error");
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            //var ClaimPrinciple = await ClaimsPrincipalFactory.CreateAsync(user);
            //await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, ClaimPrinciple);
            return RedirectToAction("Index");
        }





    }
}