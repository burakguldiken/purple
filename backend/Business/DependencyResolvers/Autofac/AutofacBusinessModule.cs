using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Interfaces;
using Business.Services;
using Castle.DynamicProxy;
using Core.Contexts.Dapper;
using Core.CrossCuttingCorners.Cache.Redis;
using Core.CrossCuttingCorners.FileServer;
using Core.CrossCuttingCorners.Queue.RabbitMq;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthService>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserService>().As<IUserService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
