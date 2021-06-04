using Autofac;
using Business.Interfaces;
using Business.Services;
using Core.Contexts.Dapper;
using Core.CrossCuttingCorners.Cache.Redis;
using Core.CrossCuttingCorners.FileServer;
using Core.CrossCuttingCorners.Queue.RabbitMq;
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

            builder.RegisterType<RedisService>().As<IRedisService>();
            builder.RegisterType<RabbitMqService>().As<IRabbitMqService>();
            builder.RegisterType<MinioService>().As<IMinioService>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
