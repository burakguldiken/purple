using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Connection
{
    public class Connection
    {
        private static Connection _connection = null;

        public static Connection Instance
        {
            get
            {
                if (_connection == null)
                    _connection = new Connection();
                return _connection;
            }
        }

        public string connString { get; set; }

        public Connection()
        {
            EnvironmentManager.EnvironmentManager environmentManager = EnvironmentManager.EnvironmentManager.Instance;
            IConfiguration configuration = environmentManager.Get_Configuration();

            connString = (string)configuration.GetValue(typeof(string), "ConnString");
        }
    }
}
