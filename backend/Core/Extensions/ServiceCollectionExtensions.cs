using Core.Context.Dapper;
using Core.CrossCuttingCorners.Cache.Redis;
using Core.CrossCuttingCorners.FileServer;
using Core.CrossCuttingCorners.Queue.RabbitMq;
using Core.Utilities.Security.Jwt;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCoreDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IDbContext), typeof(DbContext));
            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddScoped<IRedisService, RedisService>();
            services.AddScoped<IRabbitMqService, RabbitMqService>();
            services.AddScoped<IMinioService, MinioService>();
        }
    }
}
