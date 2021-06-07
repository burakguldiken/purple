using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contexts.Dapper
{
    public interface IDbContext<T> where T : BaseEntity, new()
    {
        /// <summary>
        /// Insert operation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        long Insert(T item);
        /// <summary>
        /// Get item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(long id);
        /// <summary>
        /// Get all rows for current class
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Update current item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Update(T item);
        /// <summary>
        /// Delete current item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Delete(T item);
        /// <summary>
        /// Bulk insert operation
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        bool BulkInsert(IEnumerable<T> items);
        /// <summary>
        /// Bulk update operation
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        bool BulkUpdate(IEnumerable<T> items);
        /// <summary>
        /// Bulk delete operation
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        bool BulkDelete(IEnumerable<T> items);
        /// <summary>
        /// Query execute by parameters
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteCommand(string sql, params object[] args);
        /// <summary>
        /// Query execute by none parameter
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteCommand(string sql);
    }
}
