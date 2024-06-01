using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppCustomDataAnnotation.ArrtibuteValidation
{

    public class UniqueEmailAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object _value, ValidationContext validationContext)
        {

            if (_value != null && _value.ToString() == "name@company.com")
            {
                return new ValidationResult(ErrorMessage = "Email address already exist");
            }

            return ValidationResult.Success;
        }
    }
}