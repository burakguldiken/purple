using AutoMapper;
using Business.Interfaces;
using DataAccess;
using Entities.CustomEntity.Request.User;
using Entities.CustomEntity.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Purple.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(TokenValidationAttribute))]
    
    public class AuthController : BaseController
    {
        private readonly IAuthService _authService;

        public AuthController(IUnitOfWork _unitOfWork, IAuthService authService) 
            : base(_unitOfWork)
        {
            _authService = authService;
        }

        /// <summary>
        /// User login operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(UserLoginRequestDto request)
        {
            var userToLogin = _authService.Login(request);

            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            _unitOfWork.Commit();

            return Ok(result.Data);
        }

        /// <summary>
        /// New register operation
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("register")]
        public ActionResult Register(UserRegisterRequestDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);

            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto);

            var result = _authService.CreateAccessToken(registerResult.Data);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            _unitOfWork.Commit();

            return Ok(result.Data);
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            var users  = _authService.GetUsers(GetUserId());

            if(!users.Success)
            {
                return BadRequest(users.Message);
            }

            return Ok(users.Data);
        }
    }
}
