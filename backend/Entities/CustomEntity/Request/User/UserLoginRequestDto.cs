using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.CustomEntity.Request.User
{
    public class UserLoginRequestDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
