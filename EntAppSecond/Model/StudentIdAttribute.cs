using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Model
{
    public class StudentIdAttribute : ValidationAttribute, IClientModelValidator

    {
        protected override ValidationResult IsValid(object StudentId, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;
            if (student.StudentID != @"^[Ss][0-9]{4}$")
            {
                return new ValidationResult("Please enter a valid ID");
            }

            return ValidationResult.Success;
            //if (student.StudentID != "S\\d\\d\\d\\d\\d\\d\\d")
            //{
            //    return new ValidationResult("Please enter a valid result");
            //}
            //return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-studentid", "Please enter a valid ID");
        }
    }

}
