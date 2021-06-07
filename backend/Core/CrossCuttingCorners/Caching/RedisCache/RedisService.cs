using Core.Utilities.Connection;
using Core.Utilities.Environment;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.Cache.Redis
{
    public class RedisService : IRedisService
    {
        private readonly ConnectionMultiplexer _redis;

        public RedisService()
        {
            _redis = ConnectionHelper.RedisConnection();
        }

        public ConnectionMultiplexer GetConnectionMultiplexer()
        {
            return _redis;
        }

        /// <summary>
        /// It Is Used To Delete The Value In The Hash
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<bool> DeleteHash(string hashKey, string key, int db = 0)
        {
            bool rtn = true;
            try
            {
                IDatabase rdb = GetDatabase(db);
                await rdb.HashDeleteAsync(hashKey, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                rtn = false;
            }
            return rtn;
        }

        /// <summary>
        /// It Is Used To Get The Value Of A Key Found In The Redis
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<string> Get(string key, int db = 0)
        {
            string rtn = "";
            try
            {
                IDatabase rdb = GetDatabase(db);
                rtn = await rdb.StringGetAsync(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rtn;
        }

        /// <summary>
        /// It Is Used To Get The Value Of A Key In The Redis As Class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<T> Get<T>(string key, int db = 0)
        {
            T rtn = default;
            try
            {
                IDatabase rdb = GetDatabase(db);
                string value = await rdb.StringGetAsync(key);

                if (!String.IsNullOrEmpty(value))
                {
                    rtn = JsonConvert.DeserializeObject<T>(value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rtn;
        }

        /// <summary>
        /// Returns the Database Context to Connect to
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IDatabase GetDatabase(int id = 0)
        {
            IDatabase rtn = null;
            try
            {
                rtn = _redis.GetDatabase(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rtn;
        }

        /// <summary>
        /// Used To Retrieve The Value In The Hash
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<HashEntry[]> GetHash(string hashKey, int db = 0)
        {
            HashEntry[] rtn = null;
            try
            {
                IDatabase rdb = GetDatabase(db);
                rtn = await rdb.HashGetAllAsync(hashKey);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rtn;
        }

        /// <summary>
        /// Cast the hashset in redis to the model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="hashKey"></param>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<T> GetHash<T>(string hashKey, string key, int db = 0)
        {
            T result = (T)Activator.CreateInstance(typeof(T));
            try
            {
                IDatabase rdb = GetDatabase(db);
                string json = await rdb.HashGetAsync(hashKey, key);
                if (!String.IsNullOrEmpty(json))
                    result = JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Fetches the hash string
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<string> GetHashString(string hashKey, string key, int db = 0)
        {
            string result = null;
            try
            {
                IDatabase rdb = GetDatabase(db);
                result = await rdb.HashGetAsync(hashKey, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Gives Number of Keys Contained in Hash
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<long> HashCount(string key, int db = 0)
        {
            long rtn = 0;
            try
            {
                IDatabase rdb = GetDatabase(db);
                rtn = await rdb.HashLengthAsync(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rtn;
        }

        /// <summary>
        /// Used to Delete Key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<bool> RemoveKey(string key, int db = 0)
        {
            bool rtn = true;
            try
            {
                IDatabase rdb = GetDatabase(db);
                await rdb.KeyDeleteAsync(key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                rtn = false;
            }
            return rtn;
        }

        /// <summary>
        /// It Is Used To Set A Value To Redis
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expireDate"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<bool> Set(string key, string value, DateTime? expireDate, int db = 0)
        {
            bool rtn = true;
            try
            {
                IDatabase rdb = GetDatabase(db);
                if (expireDate != null)
                {
                    var expiryTimeSpan = expireDate.Value.Subtract(DateTime.UtcNow);
                    await rdb.StringSetAsync(key, value, expiryTimeSpan);
                }
                else
                {
                    await rdb.StringSetAsync(key, value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                rtn = false;
            }
            return rtn;
        }

        /// <summary>
        /// It Is Used To Set A Class To Redis
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expireDate"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<bool> Set<T>(string key, T value, DateTime? expireDate, int db = 0)
        {
            string serializeValue = JsonConvert.SerializeObject(value);
            return await Set(key, serializeValue, expireDate, db);
        }

        /// <summary>
        /// Used To Insert Data Into Hash
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<bool> SetHash(string hashKey, string key, string value, int db = 0)
        {
            bool rtn = true;
            try
            {
                IDatabase rdb = GetDatabase(db);
                await rdb.HashSetAsync(hashKey, key, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                rtn = false;
            }
            return rtn;
        }

        /// <summary>
        /// Used To Insert Data Into Hash
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public async Task<bool> SetHash(string hashKey, string key, object value, int db = 0)
        {
            return await SetHash(hashKey, key, JsonConvert.SerializeObject(value), db);
        }
    }
}
