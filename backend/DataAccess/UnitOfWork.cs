using Core.Utilities.Connection;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using System;
using System.Data;
using System.Text;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbTransaction _transaction;
        private IDbConnection _connection;
        private IUserRepository _userRepository;
        private bool _disposed;

        public UnitOfWork()
        {
            try
            {
                _connection = ConnectionHelper.Instance.MySqlConnection();
                _connection.Open();
                _transaction = _connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public IUserRepository UserRepository
        {
            get {return _userRepository ?? (_userRepository = new UserRepository(_transaction)); }
        }

        public bool Commit()
        {
            bool rtn = false;
            try
            {
                _transaction.Commit();
                rtn = true;
            }
            catch (Exception)
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
            return rtn;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void ResetRepositories()
        {
            _userRepository = null;
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_transaction != null)
                    {
                        _transaction.Dispose();
                        _transaction = null;
                    }

                    if (_connection != null)
                    {
                        _connection.Dispose();
                        _connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}
