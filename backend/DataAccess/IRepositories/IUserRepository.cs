using Core.Context.Dapper;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Get user by email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User GetUserByEmail(string email);
    }
}
