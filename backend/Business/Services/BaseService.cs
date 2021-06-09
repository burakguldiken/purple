using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class BaseService
    {
        public readonly IMapper _mapper;
 
        public BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
