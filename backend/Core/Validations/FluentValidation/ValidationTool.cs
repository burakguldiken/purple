﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Validations.FluentValidation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
