using Core.CrossCuttingCorners.Caching.Microsoft;
using Core.Utilities.Connection;
using Core.Utilities.Environment;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.CrossCuttingCorners.Cache.Redis
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _redisServer;

        public RedisService()
        {
            _redisServer = ConnectionHelper.RedisConnection();
        }

        public IDatabase GetDatabase(int db = 0)
        {
            return _redisServer.GetDatabase(db);
        }

        public void Add(string key, object data, int duration)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            _redisServer.GetDatabase(0).StringSet(key, jsonData, TimeSpan.FromMinutes(duration));
        }

        public T Get<T>(string key)
        {
            if (IsAdd(key))
            {
                string jsonData = _redisServer.GetDatabase(0).StringGet(key);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }

            return default(T);
        }

        public object Get(string key)
        {
            return Get<object>(key);
        }

        public bool IsAdd(string key)
        {
            return _redisServer.GetDatabase(0).KeyExists(key);
        }

        public void Remove(string key)
        {
            if (IsAdd(key))
            {
                _redisServer.GetDatabase(0).KeyDelete(key);
            }
        }
    }
}
