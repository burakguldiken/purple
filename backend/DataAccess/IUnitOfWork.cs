using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        bool Commit();
    }
}
