using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.CustomEntity.Request.User
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
