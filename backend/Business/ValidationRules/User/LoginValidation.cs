using Entities.CustomEntity.Request.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.User
{
    public class LoginValidation : AbstractValidator<UserLoginRequest>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Email).EmailAddress().MaximumLength(100);
            RuleFor(x => x.Password).NotNull().NotEmpty();
        }
    }
}
