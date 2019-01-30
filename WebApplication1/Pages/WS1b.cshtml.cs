using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class WS1bModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {

        }

        public void OnPost (int Number1, int Number2)
        {
            //int total = Number1 + Number2;
            //Message = string.Format("The sum of {0} and {1} is {2}", Number1, Number2, total);

            if (Request.Form["sums"] == "add")
                Message = "The total of " + Number1 + " and " + Number2 + " is " + (Number1 + Number2);
            if (Request.Form["sums"] == "minus")
                Message = "The total of " + Number1 + " minus " + Number2 + " is " + (Number1 - Number2);
            if (Request.Form["sums"] == "multiply")
                Message = "The total of " + Number1 + " by " + Number2 + " is " + (Number1 * Number2);
            if (Request.Form["sums"] == "division")
                Message = "The total of " + Number1 + " divided by " + Number2 + " is " + (Number1 / Number2);
        }

    }
}