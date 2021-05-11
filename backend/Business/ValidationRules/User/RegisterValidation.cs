using Entities.CustomEntity.Request.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.User
{
    public class RegisterValidation : AbstractValidator<UserRegisterRequestDto>
    {
        public RegisterValidation()
        {
            RuleFor(x => x.Email).EmailAddress().MaximumLength(100);
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.Surname).NotNull();
        }
    }
}
