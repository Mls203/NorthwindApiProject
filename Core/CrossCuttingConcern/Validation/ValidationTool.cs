
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace Core.CrossCuttingConcern.Validation
{
    public static class ValidationTool
    {

        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
           
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(
             string.Join(", ", result.Errors.Select(x => x.ErrorMessage))
         );
            }
        }
    }
}
