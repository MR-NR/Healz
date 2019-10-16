using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Healz.Areas.Identity.Pages.Account
{
    public class LoginAndRegisterModel : PageModel
    {
        [BindProperty]
        public LoginModel.InputModel LoginInput { get; set; }
        [BindProperty]
        public RegisterModel.InputModel RegisterInput { get; set; }
        public void OnGet()
        {
        }
    }
}