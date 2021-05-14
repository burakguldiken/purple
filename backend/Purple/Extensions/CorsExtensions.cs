using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Extensions
{
    public static class CorsExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers()
            .AddNewtonsoftJson(options =>
            {
               options.SerializerSettings.ContractResolver = new DefaultContractResolver();
             });
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });

            services.AddHttpContextAccessor();
            services.AddMemoryCache();
        }
    }
}
