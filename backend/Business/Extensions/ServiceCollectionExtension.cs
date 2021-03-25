using Business.Interfaces;
using Business.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddBusinessDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
