using AutoMapper;
using Business.Constant.Messages;
using Business.Enums;
using Business.Interfaces;
using Business.ValidationRules.User;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingCorners.Cache.Redis;
using Core.CrossCuttingCorners.Caching.Microsoft;
using Core.Enums;
using Core.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Core.Validations.FluentValidation;
using DataAccess;
using DataAccess.IRepositories;
using Entities.CustomEntity.Request.User;
using Entities.CustomEntity.Response;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly ITokenHelper _tokenHelper;
        private readonly IUserRepository _userRepository;

        public AuthService(IMapper _mapper, ITokenHelper tokenHelper,IUserRepository userRepository)
            : base(_mapper)
        {
            _tokenHelper = tokenHelper;
            _userRepository = userRepository;
        }

        /// <summary>
        /// User login operation
        /// </summary>
        /// <param name="userForLoginDto"></param>
        /// <returns></returns>
        //[PerformanceAspect(5)]
        public IDataResult<User> Login(UserLoginRequestDto userForLoginDto)
        {
            ValidationTool.Validate(new LoginValidation(), userForLoginDto);

            var userToCheck = _userRepository.GetUserByEmail(userForLoginDto.Email);

            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(ErrorMessages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(ErrorMessages.PassError);
            }

            return new SuccessDataResult<User>(userToCheck, SuccessMessages.SuccessfulLogin);
        }

        /// <summary>
        /// User register operation
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <returns></returns>
        [ValidationAspect(typeof(RegisterValidation))]
        [TransactionScopeAspect]
        public IDataResult<User> Register(UserRegisterRequestDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);

            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                Surname = userForRegisterDto.Surname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                StatusId = (int)EnumStatus.Active
            };

            if (_userRepository.Insert(user) <= 0)
            {
                return new ErrorDataResult<User>(ErrorMessages.RegisterError);
            }

            return new SuccessDataResult<User>(user, SuccessMessages.UserRegistered);
        }

        /// <summary>
        /// Create a new access token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            if (user is null)
            {
                return new ErrorDataResult<AccessToken>(ErrorMessages.TokenCreateError);
            }

            var accessToken = _tokenHelper.CreateToken(user);

            return new SuccessDataResult<AccessToken>(accessToken, SuccessMessages.AccessTokenCreated);
        }

        /// <summary>
        /// User control by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public IResult UserExists(string email)
        {
            if (_userRepository.GetUserByEmail(email) != null)
            {
                return new ErrorResult(ErrorMessages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [CacheAspect]
        //[CacheRemoveAspect("IAuthService.GetUsers")]
        public IDataResult<List<UserListResponseDto>> GetUsers(long userId)
        {
            var currentUser = _userRepository.GetById(userId);

            if (currentUser is null)
            {
                return new ErrorDataResult<List<UserListResponseDto>>(ErrorMessages.UserNotFound);
            }

            if (currentUser.UserRole != (int)EnumUserRole.Admin)
            {
                return new ErrorDataResult<List<UserListResponseDto>>(ErrorMessages.Unauthorized);
            }

            var users = _mapper.Map<List<UserListResponseDto>>(_userRepository.GetAll());

            return new SuccessDataResult<List<UserListResponseDto>>(users);
        }
    }
}
