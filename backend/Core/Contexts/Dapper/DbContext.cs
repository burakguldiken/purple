using Business.Enums;
using Dapper;
using Dapper.Contrib.Extensions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Z.Dapper.Plus;

namespace Core.Context.Dapper
{
    public class DbContext : IDbContext
    {
        protected IDbTransaction _transaction;
        protected IDbConnection _connection 
        { 
            get 
            { 
                return _transaction.Connection; 
            } 
        }

        public DbContext(IDbTransaction transaction)
        {
            _transaction = transaction;
        }

        public IEnumerable<T> GetAll<T>() where T : BaseEntity, new()
        {
            try
            {
                return _connection.GetAll<T>().Where(x => x.StatusId == (int)EnumStatus.Active).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public T GetById<T>(long id) where T : class, new()
        {
            try
            {
                return _connection.Get<T>(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public bool Update<T>(T item) where T : class, new()
        {
            try
            {
                return _connection.Update(item, _transaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public bool Delete<T>(T item) where T : BaseEntity, new()
        {
            try
            {
                item.StatusId = (int)EnumStatus.Inactive;
                return _connection.Update(item, _transaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }


        public long Insert<T>(T item) where T : class, new()
        {
            try
            {
                return _connection.Insert(item, _transaction);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public IEnumerable<T> ExecuteCommand<T>(string sql, params object[] args)
        {
            try
            {
                return _connection.Query<T>(sql, CreateParams(GetMethodName(), args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public bool BulkInsert<T>(IEnumerable<T> items) where T : class, new()
        {
            try
            {
                return _connection.BulkInsert(items).Current.Any() ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool BulkUpdate<T>(IEnumerable<T> items) where T : class, new()
        {
            try
            {
                _connection.BulkUpdate(items);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool BulkDelete<T>(IEnumerable<T> items) where T : class, new()
        {
            try
            {
                _connection.BulkDelete(items);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public IEnumerable<T> ExecuteCommand<T>(string sql)
        {
            try
            {
                return _connection.Query<T>(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default;
        }

        public MethodInfo GetMethodName()
        {
            var trace = new StackTrace();
            return (MethodInfo)trace.GetFrame(2).GetMethod();
        }

        public DynamicParameters CreateParams(MethodInfo _Method, params object[] _Values)
        {
            DynamicParameters sqlParams = new DynamicParameters();
            int paramIndex = 0;
            ParameterInfo[] methodParameters = _Method.GetParameters();
            foreach (ParameterInfo paramInfo in methodParameters)
            {
                sqlParams.Add(paramInfo.Name, _Values[paramIndex]);
                paramIndex++;
            }
            return sqlParams;
        }
    }
}
