using AutoMapper;
using Entities.CustomEntity.Request.User;
using Entities.CustomEntity.Response;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Utilities.Mapper.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserLoginRequestDto>();
            CreateMap<User, UserListResponseDto>();
        }
    }
}
