using Business.Enums;
using Core.Entities;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace Core.Contexts.Dapper
{
    public class DbContext<T> : IDbContext<T> where T : BaseEntity, new()
    {
        readonly IDbTransaction _transaction;

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

        public IEnumerable<T> GetAll()
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

        public T GetById(long id)
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

        public bool Update(T item)
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

        public bool Delete(T item)
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


        public long Insert(T item)
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

        public IEnumerable<T> ExecuteCommand(string sql, params object[] args)
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

        public IEnumerable<T> ExecuteCommand(string sql)
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

        public bool BulkInsert(IEnumerable<T> items)
        {
            try
            {
                return _connection.BulkInsert(items).Current.Any();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool BulkUpdate(IEnumerable<T> items)
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

        public bool BulkDelete(IEnumerable<T> items)
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
