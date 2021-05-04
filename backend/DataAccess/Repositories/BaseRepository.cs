using Core.Context.Dapper;
using DataAccess.IRepositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Z.Dapper.Plus;

namespace DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        private IDbTransaction _transaction { get; set; }
        private IDbContext _instance { get; set; }

        protected IDbContext _connection
        {
            get
            {
                return _instance ?? (_instance = new DbContext(_transaction));
            }
        }

        public BaseRepository(IDbTransaction transaction)
        {
            _transaction = transaction;
        }

        public long Insert(T entity)
        {
            return _connection.Insert(entity);
        }

        public bool Update(T entity)
        {
            return _connection.Update(entity);
        }

        public bool Delete(T entity)
        {
            return _connection.Delete(entity);
        }

        public T GetById(long id)
        {
            return _connection.GetById<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _connection.GetAll<T>();
        }

        public bool BulkInsert(IEnumerable<T> items)
        {
            return _connection.BulkInsert(items);
        }

        public bool BulkUpdate(IEnumerable<T> items)
        {
            return _connection.BulkUpdate(items);
        }

        public bool BulkDelete(IEnumerable<T> items)
        {
            return _connection.BulkDelete(items);
        }
    }
}
