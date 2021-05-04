using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class BaseService
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
 
        public BaseService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
