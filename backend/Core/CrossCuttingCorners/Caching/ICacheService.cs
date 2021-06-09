using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.Caching.Microsoft
{
    public interface ICacheService
    {
        /// <summary>
        /// Get generic data by key
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        T Get<T>(string key);
        /// <summary>
        /// Get object by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object Get(string key);
        /// <summary>
        /// Add new data
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="duration"></param>
        void Add(string key, object data, int duration);
        /// <summary>
        /// Is exists control
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool IsAdd(string key);
        /// <summary>
        /// Remove to cache by key
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);
        /// <summary>
        /// Remove to cache by pattern
        /// </summary>
        /// <param name="pattern"></param>
        void RemoveByPattern(string pattern);
    }
}
