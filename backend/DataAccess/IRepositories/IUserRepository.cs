using Core.Context.Dapper;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
