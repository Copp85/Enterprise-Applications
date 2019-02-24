using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Model
{
    public class FirstNameAttribute : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object FirstName, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;
            if (student.FirstName != "[\\w’-]{2,}")
            {
                return new ValidationResult("Please enter a valid first name");
            }

            return ValidationResult.Success;

        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-firstName", "Please enter a valid first name");
        }
    }
}
