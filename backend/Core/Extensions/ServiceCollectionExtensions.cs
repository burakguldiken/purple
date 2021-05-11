using Core.Context.Dapper;
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
        }
    }
}
