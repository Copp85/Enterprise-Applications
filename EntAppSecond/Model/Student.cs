using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Pages.Model
{
    

    public class Student
    {
        [Required (ErrorMessage ="Please enter a Student ID")]
        [Display(Name ="Student ID")]
        public string StudentID { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";
    }
}
