using Core.Results;
using Core.Utilities.Security.Jwt;
using Entities.CustomEntity.Request.User;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IAuthService
    {
        /// <summary>
        /// User login operation
        /// </summary>
        /// <param name="userForLoginDto"></param>
        /// <returns></returns>
        IDataResult<User> Login(UserLoginRequestDto userForLoginDto);
        /// <summary>
        /// Create new a access token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        IDataResult<AccessToken> CreateAccessToken(User user);
        /// <summary>
        /// User exists control
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        IResult UserExists(string email);
        /// <summary>
        /// New register operation
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        IDataResult<User> Register(UserRegisterRequestDto userForRegisterDto);
    }
}
