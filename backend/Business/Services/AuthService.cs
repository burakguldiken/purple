using AutoMapper;
using Business.Constant.Messages;
using Business.Enums;
using Business.Interfaces;
using Business.ValidationRules.User;
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
    public class AuthService : BaseService,IAuthService
    {
        private ITokenHelper _tokenHelper;

        public AuthService(IUnitOfWork _unitOfWork,IMapper _mapper,ITokenHelper tokenHelper) 
            : base(_unitOfWork,_mapper)
        {
            _tokenHelper = tokenHelper;
        }

        /// <summary>
        /// User login operation
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public IDataResult<User> Login(UserLoginRequestDto request)
        {
            ValidationTool.Validate(new LoginValidation(), request);

            var userToCheck = _unitOfWork.UserRepository.GetUserByEmail(request.Email);

            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(ErrorMessages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(request.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(ErrorMessages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, SuccessMessages.SuccessfulLogin);
        }

        /// <summary>
        /// User register operation
        /// </summary>
        /// <param name="userForRegisterDto"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IDataResult<User> Register(UserRegisterRequestDto request)
        {
            ValidationTool.Validate(new RegisterValidation(), request);

            byte[] passwordHash, passwordSalt;

            HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

            var user = new User
            {
                Email = request.Email,
                FirstName = request.FirstName,
                Surname = request.Surname,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                StatusId = (int)EnumStatus.Active
            };

             if(_unitOfWork.UserRepository.Insert(user) <= 0)
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
            if(user is null)
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
            if (_unitOfWork.UserRepository.GetUserByEmail(email) != null)
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
        public IDataResult<List<UserListResponseDto>> GetUsers(long userId)
        {
            var currentUser = _unitOfWork.UserRepository.GetById(userId);
            
            if(currentUser is null)
            {
                return new ErrorDataResult<List<UserListResponseDto>>(ErrorMessages.UserNotFound);
            }

            if(currentUser.UserRole != (int)EnumUserRole.Admin)
            {
                return new ErrorDataResult<List<UserListResponseDto>>(ErrorMessages.Unauthorized);
            }

            var users = _mapper.Map<List<UserListResponseDto>>(_unitOfWork.UserRepository.GetAll());

            return new SuccessDataResult<List<UserListResponseDto>>(users);
        }
    }
}
