using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Error
{
    public class AccessDeniedModel : PageModel
    {
        [BindProperty]
        public string Error { get; set; }
        public IActionResult OnGet(string errorMesseage)
        {
            Error = errorMesseage;
            return Page();
        }
    }
}