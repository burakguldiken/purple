using Core.Context.Dapper;
using DataAccess.IRepositories;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        IBaseRepository<User> _dbContext;

        public UserRepository(IBaseRepository<User> dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
