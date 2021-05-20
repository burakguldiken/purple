using Core.Utilities.Environment;
using Microsoft.Extensions.Configuration;
using Minio;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Connection
{
    public class Connections
    {
        private static Connections _connection = null;
        public ConnectionFactory _rabbitMqConnection { get; set; }
        public MinioClient _minioClient { get; set; }
        public string _connString { get; set; }
        public string _redisConnection { get; set; }

        public static Connections Instance
        {
            get
            {
                if (_connection == null)
                    _connection = new Connections();
                return _connection;
            }
        }

        public Connections()
        {
            EnvironmentManager environmentManager = EnvironmentManager.Instance;
            IConfiguration configuration = environmentManager.Get_Configuration();

            _connString = (string)configuration.GetValue(typeof(string), "ConnString");

            _redisConnection = (string)configuration.GetValue(typeof(string), "RedisConnString");

            _rabbitMqConnection = new ()
            {
                HostName = (string)configuration.GetValue(typeof(string), "RabbitMqHost"),
                Port = (int)configuration.GetValue(typeof(int), "RabbitMqPort"),
                UserName = (string)configuration.GetValue(typeof(string), "RabbitMqUsername"),
                Password = (string)configuration.GetValue(typeof(string), "RabbitMqPassword")
            };

            _minioClient = new(
                (string)configuration.GetValue(typeof(string), "MinioIp"),
                (string)configuration.GetValue(typeof(string), "MinioSecretKey"),
                (string)configuration.GetValue(typeof(string), "MinioAccessKey")
            );
        }
    }
}
