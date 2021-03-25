using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
