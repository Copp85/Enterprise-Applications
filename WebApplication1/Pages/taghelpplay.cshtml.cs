using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public double Number3 { get; set; }

        [BindProperty]
        public double? Number4 { get; set; }

        [BindProperty]
        public decimal Number5 { get; set; }

        [BindProperty]
        public decimal? Number6 { get; set; }

        [BindProperty]
        public float Number7 { get; set; }

        [BindProperty]
        public float? Number8 { get; set; }

        [BindProperty]
        public String SomeString { get; set; }

        [BindProperty]
        public DateTime? TheDate { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }

       
        public string Message { get; set; }
        [BindProperty]
        public int Season{ get; set; }
        public void OnGet()
        {

        }

        public void OnPost ()
        {
            //Message = string.Format("You selected {0}", Season);
            if (Request.Form["Season"] == "Spring")
                Message = "You selected Spring";
            if (Request.Form["Season"] == "Summer")
                Message = "You selected Summer";
            if (Request.Form["Season"] == "Autumn")
                Message = "You selected Autumn";
            if (Request.Form["Season"] == "Winter")
                Message = "You selected Winter";
        }
    }
}