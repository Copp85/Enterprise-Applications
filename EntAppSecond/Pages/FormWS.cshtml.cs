using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {
        [BindProperty]
        public int Colour { get; set; }

        [BindProperty]
        public bool Consent { get; set; }

        
        public void OnGet()
        {

        }
    }
}