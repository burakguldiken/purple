using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Connection
{
    public class Connections
    {
        private static Connections _connection = null;

        public static Connections Instance
        {
            get
            {
                if (_connection == null)
                    _connection = new Connections();
                return _connection;
            }
        }

        public string connString { get; set; }

        public Connections()
        {
            EnvironmentManager.EnvironmentManager environmentManager = EnvironmentManager.EnvironmentManager.Instance;
            IConfiguration configuration = environmentManager.Get_Configuration();

            connString = (string)configuration.GetValue(typeof(string), "ConnString");
        }
    }
}
