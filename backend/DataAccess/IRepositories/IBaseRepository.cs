using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Z.Dapper.Plus;

namespace DataAccess.IRepositories
{
    public interface IBaseRepository<T> where T : class, new()
    {
        /// <summary>
        /// Insert a new item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public long Insert(T entity);
        /// <summary>
        /// Update current item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity);
        /// <summary>
        /// Delete current item
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(T entity);
        /// <summary>
        /// Get item by id value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(long id);
        /// <summary>
        /// Get all item for current class
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll();
        /// <summary>
        /// Bulk insert operation
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool BulkInsert(IEnumerable<T> items);
        /// <summary>
        /// Bulk update operation
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool BulkUpdate(IEnumerable<T> items);
        /// <summary>
        /// Bulk delete operation
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool BulkDelete(IEnumerable<T> items);
    }
}
