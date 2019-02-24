using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.Students
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (Student.Email != Student.EmailConfirmation)
                ModelState.AddModelError("Student.Email", "emails don't match");
        }
    }
}