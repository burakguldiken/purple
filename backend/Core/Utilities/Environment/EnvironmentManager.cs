using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Environment
{
    public class EnvironmentManager
    {
        private IConfiguration _configuration = null;

        private static volatile EnvironmentManager _environmentManager;
        private static object lockObject = new object();

        private string _environmentName = "";
        private string _environmentVariableKey = "PURPLE_ENVIRONMENT";

        public bool IsDevelopment() => _environmentName == "Development" ? true : false;
        public bool IsProduction() => _environmentName == "Production" ? true : false;

        public EnvironmentManager()
        {
            GetEnvironmentName();
        }

        /// <summary>
        /// Create a new instance
        /// </summary>
        public static EnvironmentManager Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (_environmentManager == null)
                        _environmentManager = new EnvironmentManager();
                    return _environmentManager;
                }
            }
        }

        /// <summary>
        /// Get current environment name
        /// </summary>
        /// <returns></returns>
        public string GetEnvironmentName()
        {
            if (String.IsNullOrEmpty(_environmentName))
            {
                try
                {
                    _environmentName = System.Environment.GetEnvironmentVariable(_environmentVariableKey).ToLower();
                }
                catch (Exception)
                {
                    throw new Exception($"{_environmentVariableKey} değeri null");
                }
            }
            return _environmentName;
        }

        /// <summary>
        /// Create new configuration
        /// </summary>
        /// <returns></returns>
        public IConfiguration CreateConfiguration()
        {
            if (_configuration == null)
            {
                var builder = new ConfigurationBuilder().AddJsonFile($"{GetEnvironmentName()}.json", true, true);
                _configuration = builder.Build();
            }
            return _configuration;
        }

        /// <summary>
        /// Get current configuration
        /// </summary>
        /// <returns></returns>
        public IConfiguration GetConfiguration()
        {
            return _configuration = CreateConfiguration();
        }
    }
}
