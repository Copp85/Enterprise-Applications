using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Model
{
    public class ModulesAttribute : ValidationAttribute, IClientModelValidator
    {
            
        
            protected override ValidationResult IsValid(object NoOfModules, ValidationContext validationContext)
        {
            Student student = (Student)validationContext.ObjectInstance;
            if (student.NoOfModules < 1)
            {
                return new ValidationResult("Please enter your number of modules");
            }

            return ValidationResult.Success;

        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-modules", "Please enter your number of modules");
        }
    }
}
