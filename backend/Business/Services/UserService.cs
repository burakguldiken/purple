using AutoMapper;
using Business.Interfaces;
using DataAccess;
using Entities.CustomEntity.Request.User;
using Entities.Models;

namespace Business.Services
{
    public class UserService : BaseService,IUserService
    {
        public UserService(IUnitOfWork _unitOfWork,IMapper _mapper) : base(_unitOfWork,_mapper)
        {
        }

        public long AddUser()
        {            
            User req = new()
            {
                Id =5
            };

            var mappedObject = _mapper.Map<UserLoginRequest>(req);

            var all = _unitOfWork.UserRepository.GetAll();

            _unitOfWork.Commit();

            return default;
        }
    }
}
