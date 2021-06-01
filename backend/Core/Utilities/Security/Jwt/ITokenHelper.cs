using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        /// <summary>
        /// Create a new jwt token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        AccessToken CreateToken(User user);
    }
}
