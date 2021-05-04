using Core.Context.Dapper;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
