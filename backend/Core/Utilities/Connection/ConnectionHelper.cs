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
        private static IConfiguration configuration = null;
        private static volatile ConnectionHelper _connection = null;

        public ConnectionHelper()
        {
            EnvironmentManager environmentManager = EnvironmentManager.Instance;
            configuration = environmentManager.GetConfiguration();
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
        public IDbConnection MySqlConnection()
        {
            MySqlConnection mysqlConn = new((string)configuration.GetValue(typeof(string), "ConnString"));
            return mysqlConn;
        }

        /// <summary>
        /// Create rabbitmq connection
        /// </summary>
        /// <returns></returns>
        public IConnection RabbitMqConnection()
        {
            ConnectionFactory rabbitMqConnection = new()
            {
                HostName = (string)configuration.GetValue(typeof(string), "RabbitMqHost"),
                Port = (int)configuration.GetValue(typeof(int), "RabbitMqPort"),
                UserName = (string)configuration.GetValue(typeof(string), "RabbitMqUsername"),
                Password = (string)configuration.GetValue(typeof(string), "RabbitMqPassword")
            };

            return rabbitMqConnection.CreateConnection();
        }

        /// <summary>
        /// Create redis connection
        /// </summary>
        /// <returns></returns>
        public ConnectionMultiplexer RedisConnection()
        {
            string redisConn = (string)configuration.GetValue(typeof(string), "RedisConnString");
            return ConnectionMultiplexer.Connect(redisConn);
        }

        /// <summary>
        /// Create minio connection
        /// </summary>
        /// <returns></returns>
        public MinioClient MinioConnection()
        {
            MinioClient minioClient = new(
                (string)configuration.GetValue(typeof(string), "MinioIp"),
                (string)configuration.GetValue(typeof(string), "MinioSecretKey"),
                (string)configuration.GetValue(typeof(string), "MinioAccessKey")
            );

            return minioClient;
        }
    }
}
