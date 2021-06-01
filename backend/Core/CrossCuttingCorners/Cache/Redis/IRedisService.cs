using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.Cache.Redis
{
    public interface IRedisService
    {
        /// <summary>
        /// Used to Provide Connection Information
        /// </summary>
        /// <returns></returns>
        ConnectionMultiplexer GetConnectionMultiplexer();
        /// <summary>
        /// Returns the Database Context to Connect to
        /// </summary>
        /// <param name="id">Database Id</param>
        /// <returns></returns>
        IDatabase GetDatabase(int id = 0);
        /// <summary>
        /// It Is Used To Get The Value Of A Key Found In The Redis
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="key">Redis Key</param>
        /// <returns></returns>
        Task<string> Get(string key, int db = 0);
        /// <summary>
        /// It Is Used To Get The Value Of A Key In The Redis As Class
        /// </summary>
        /// <typeparam name="T">Return class type</typeparam>
        /// <param name="db">Database Id</param>
        /// <param name="key">Redis Key</param>
        /// <returns></returns>
        Task<T> Get<T>(string key, int db = 0);
        /// <summary>
        /// It Is Used To Set A Value To Redis
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="key">Redis Key</param>
        /// <param name="value">Redis Value</param>
        /// <param name="expireDate">Expire Date(optional)</param>
        /// <returns></returns>
        Task<bool> Set(string key, string value, DateTime? expireDate, int db = 0);
        /// <summary>
        /// It Is Used To Set A Class To Redis
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="db">Database Id</param>
        /// <param name="key">Redis Key</param>
        /// <param name="value">Redis Value</param>
        /// <param name="expire_date">Expiration Time(optional)</param>
        /// <returns></returns>
        Task<bool> Set<T>(string key, T value, DateTime? expireDate, int db = 0);
        /// <summary>
        /// Used to Delete Key
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="key">Redis Key</param>
        /// <returns></returns>
        Task<bool> RemoveKey(string key, int db = 0);
        /// <summary>
        /// Gives Number of Keys Contained in Hash
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="key">Redis Key</param>
        /// <returns></returns>
        Task<long> HashCount(string key, int db = 0);
        /// <summary>
        /// Used To Insert Data Into Hash
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="hashKey">Hash Key</param>
        /// <param name="key">Key</param>
        /// <param name="value">Redis Value</param>
        /// <returns></returns>
        Task<bool> SetHash(string hashKey, string key, string value, int db = 0);
        /// <summary>
        /// Used To Insert Data Into Hash
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<bool> SetHash(string hashKey, string key, object value, int db = 0);
        /// <summary>
        /// It Is Used To Delete The Value In The Hash
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="hashKey">Hash Key</param>
        /// <param name="key">Redis Key</param>
        /// <returns></returns>
        Task<bool> DeleteHash(string hashKey, string key, int db = 0);
        /// <summary>
        /// Used To Retrieve The Value In The Hash
        /// </summary>
        /// <param name="db">Database Id</param>
        /// <param name="hashKey">Redis Key</param>
        /// <returns></returns>
        Task<HashEntry[]> GetHash(string hashKey, int db = 0);
        /// <summary>
        /// Cast the hashset in redis to the model
        /// </summary>
        /// <typeparam name="T">Return class type</typeparam>
        /// <param name="db">Database Id</param>
        /// <param name="hashKey">Hash Key</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        Task<T> GetHash<T>(string hashKey, string key, int db = 0);
        /// <summary>
        /// Fetches the hash string
        /// </summary>
        /// <param name="hash_key"></param>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        Task<string> GetHashString(string hashKey, string key, int db = 0);
    }
}
