using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{

    public class ws1Model : PageModel
    {
        public string Message { get; set; } = "";

        [BindProperty]
        public int Number1 { get; set; }
        public int Number2 {get; set;}

        public void OnGet()
        {

        }

        public void OnPost(string FirstName)
        {
            Message = string.Format("Hello {0}", FirstName);
        }

       

        public string[] MyTestArray { get; set; } = { "England", "Ireland", "Scotland", "Wales", "France", "Italy" };

        

    }
}