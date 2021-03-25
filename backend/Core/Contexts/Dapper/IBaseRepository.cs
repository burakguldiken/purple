using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Context.Dapper
{
    public interface IBaseRepository<T> where T : class, new()
    {
        /// <summary>
        /// Get operation by id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_ID"></param>
        /// <returns></returns>
        T GetByID(long _ID);
        /// <summary>
        /// Get list by object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IEnumerable<T> GetList();
        /// <summary>
        /// Insert operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_Item"></param>
        /// <returns></returns>
        long Insert(T _Item);
        /// <summary>
        /// Update operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_Item"></param>
        /// <returns></returns>
        bool Update(T _Item);
        /// <summary>
        /// Delete operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_Item"></param>
        /// <returns></returns>
        bool Delete(T _Item);
        /// <summary>
        /// Query execute operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_Command"></param>
        /// <param name="_Values"></param>
        /// <returns></returns>
        IEnumerable<TEntity> ExecuteCommand<TEntity>(string _Command, params object[] _Values);
        /// <summary>
        /// Query execute operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_Command"></param>
        /// <returns></returns>
        IEnumerable<TEntity> ExecuteCommand<TEntity>(string _Command);
    }
}
