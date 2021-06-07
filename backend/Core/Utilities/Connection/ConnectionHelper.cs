using Core.Utilities.Environment;
using Microsoft.Extensions.Configuration;
using Minio;
using MySql.Data.MySqlClient;
using RabbitMQ.Client;
using StackExchange.Redis;
using System;
using System.Data;
using System.Text;

namespace Core.Utilities.Connection
{
    public class ConnectionHelper
    {
        private IConfiguration _configuration = null;
        private static volatile ConnectionHelper _connection = null;

        public ConnectionHelper()
        {
            EnvironmentManager environmentManager = EnvironmentManager.Instance;
            _configuration = environmentManager.GetConfiguration();
        }

        /// <summary>
        /// Create a new instance
        /// </summary>
        public static ConnectionHelper Instance
        {
            get
            {
                if (_connection == null)
                    _connection = new ConnectionHelper();
                return _connection;
            }
        }

        /// <summary>
        /// Create a new mysql connection
        /// </summary>
        /// <returns></returns>
        public static IDbConnection MySqlConnection()
        {
            MySqlConnection mysqlConn = new((string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "ConnString"));
            return mysqlConn;
        }

        /// <summary>
        /// Create rabbitmq connection
        /// </summary>
        /// <returns></returns>
        public static IConnection RabbitMqConnection()
        {
            ConnectionFactory rabbitMqConnection = new()
            {
                HostName = (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "RabbitMqHost"),
                Port = (int)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(int), "RabbitMqPort"),
                UserName = (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "RabbitMqUsername"),
                Password = (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "RabbitMqPassword")
            };

            return rabbitMqConnection.CreateConnection();
        }

        /// <summary>
        /// Create redis connection
        /// </summary>
        /// <returns></returns>
        public static ConnectionMultiplexer RedisConnection()
        {
            string redisConn = (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "RedisConnString");
            return ConnectionMultiplexer.Connect(redisConn);
        }

        /// <summary>
        /// Create minio connection
        /// </summary>
        /// <returns></returns>
        public static MinioClient MinioConnection()
        {
            MinioClient minioClient = new(
                (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "MinioIp"),
                (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "MinioSecretKey"),
                (string)EnvironmentManager.Instance.GetConfiguration().GetValue(typeof(string), "MinioAccessKey")
            );

            return minioClient;
        }
    }
}
