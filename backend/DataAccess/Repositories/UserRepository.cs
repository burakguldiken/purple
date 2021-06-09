using Core.Contexts.Dapper;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : DbContext<User>, IUserRepository
    {
        public UserRepository()
        {
        }

        public User GetUserByEmail(string email)
        {
            string sql = @"SELECT * FROM User WHERE Email = @email AND StatusId = 2";
            return ExecuteCommand(sql, email).FirstOrDefault();
        }
    }
}
