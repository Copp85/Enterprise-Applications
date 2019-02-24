using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Model
{
    public class HeightAttribute : ValidationAttribute, IClientModelValidator

    {
        protected override ValidationResult IsValid(object Height, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;
            if (student.Height > 50 && student.Height < 250)
            {
                return new ValidationResult("Please a valid height");
            }

            return ValidationResult.Success;

        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-height", "Please a valid height");
        }
    }
}
