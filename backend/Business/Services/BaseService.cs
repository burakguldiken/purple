using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class BaseService
    {
        public readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
