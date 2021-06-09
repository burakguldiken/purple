using Core.CrossCuttingCorners.Cache.Redis;
using Core.CrossCuttingCorners.Caching.Microsoft;
using Core.CrossCuttingCorners.FileServer;
using Core.CrossCuttingCorners.Queue.RabbitMq;
using Core.Utilities.IoC;
using Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheService, MemoryCacheService>();
            serviceCollection.AddSingleton<IRabbitMqService, RabbitMqService>();
            serviceCollection.AddSingleton<IMinioService, MinioService>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
