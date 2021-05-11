using Core.Context.Dapper;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : BaseRepository<User>,IUserRepository
    {
        public UserRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public User GetUserByEmail(string email)
        {
            string sql = @"SELECT * FROM User WHERE Email = @email AND StatusId = 2";
            return _connection.ExecuteCommand<User>(sql, email).FirstOrDefault();
        }
    }
}
