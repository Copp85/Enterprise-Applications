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
        public Student Student { get; set; }
        public void OnGet()
        {

        }
    }
}