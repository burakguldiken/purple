using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Purple.Extensions
{
    public static class BuilderExtensions
    {
        public static void Configure(this IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors(x => x
                           .AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
            app.UseSwagger()
            .UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/Purple/swagger.json", "Purple");
            });


            app.UseMvc();
        }
    }
}
