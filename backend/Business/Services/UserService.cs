using Business.Enums;
using Business.Interfaces;
using Business.ValidationRules.User;
using Core.Validations.FluentValidation;
using DataAccess;
using Entities.CustomEntity.Request.User;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class UserService : BaseService,IUserService
    {

        public UserService(IUnitOfWork _unitOfWork) : base(_unitOfWork)
        {
        }

        public long AddUser()
        {
            UserLoginRequest request = new()
            {
                Email = "burak",
            };

            ValidationTool.Validate(new LoginValidation(), request);
            
            User user = new User()
            {
                Id = 27,
                Email="burak",
                CreationDate = DateTime.Now,
                StatusId = (int)EnumStatus.Active
            };


            User user2 = new User()
            {
                Id = 28,
                Email = "burak2",
                CreationDate = DateTime.Now,
                StatusId = (int)EnumStatus.Active
            };

            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user2);

            var all = _unitOfWork.UserRepository.GetAll();


            _unitOfWork.Commit();

            return default;
        }
    }
}
