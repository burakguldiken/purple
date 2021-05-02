using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Z.Dapper.Plus;

namespace Core.Context.Dapper
{
    public interface IDbContext
    {
        /// <summary>
        /// Insert operation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        long Insert<T>(T item) where T : class, new();
        /// <summary>
        /// Get item by id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById<T>(long id) where T : class, new();
        /// <summary>
        /// Get all rows for current class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<T> GetAll<T>() where T : BaseEntity, new();
        /// <summary>
        /// Update current item
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Update<T>(T item) where T : class, new();
        /// <summary>
        /// Delete current item
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Delete<T>(T item) where T : BaseEntity, new();
        /// <summary>
        /// Bulk insert operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        bool BulkInsert<T>(IEnumerable<T> items) where T : class, new();
        /// <summary>
        /// Bulk update operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        bool BulkUpdate<T>(IEnumerable<T> items) where T : class, new();
        /// <summary>
        /// Bulk delete operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        bool BulkDelete<T>(IEnumerable<T> items) where T : class, new();
        /// <summary>
        /// Query execute by parameters
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteCommand<T>(string sql, params object[] args);
        /// <summary>
        /// Query execute by none parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteCommand<T>(string sql);
    }
}
