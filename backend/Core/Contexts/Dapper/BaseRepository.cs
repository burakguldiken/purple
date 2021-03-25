using Core.Utilities.Connection;
using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Core.Context.Dapper
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        Connection _connection = Connection.Instance;

        public IEnumerable<object> User => throw new NotImplementedException();

        public T GetByID(long _ID)
        {
            T _Item = new T();
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _Item = _Conn.Get<T>(_ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Item;
        }

        public IEnumerable<T> GetList()
        {
            IEnumerable<T> _TList;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _TList = _Conn.GetAll<T>();
                }
            }
            catch (Exception ex)
            {
                _TList = new List<T>();
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _TList;
        }

        public long Insert(T _Item)
        {
            long _ID = 0;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _ID = _Conn.Insert(_Item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _ID;
        }

        public bool Update(T _Item)
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _Rtn = _Conn.Update(_Item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public bool Delete(T _Item)
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _Rtn = _Conn.Delete(_Item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public IEnumerable<TEntity> ExecuteCommand<TEntity>(string _Command, params object[] _Values)
        {
            IEnumerable<TEntity> _TList;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _TList = _Conn.Query<TEntity>(_Command, CreateParams(GetMethodName(), _Values));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
                _TList = new List<TEntity>();
            }
            return _TList;
        }

        public IEnumerable<TEntity> ExecuteCommand<TEntity>(string _Command)
        {
            IEnumerable<TEntity> _TList;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    _TList = _Conn.Query<TEntity>(_Command);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
                _TList = new List<TEntity>();
            }
            return _TList;
        }

        public bool BulkInsert<T>(List<T> _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    foreach (var item in _Item)
                    {
                        _Conn.Insert(item);
                    }
                    _Rtn = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public bool BulkUpdate<T>(List<T> _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    foreach (var item in _Item)
                    {
                        _Conn.Update(item);
                    }
                    _Rtn = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
        }

        public bool BulkDelete<T>(List<T> _Item) where T : class, new()
        {
            bool _Rtn = false;
            try
            {
                using (var _Conn = new MySqlConnection(_connection.connString))
                {
                    foreach (var item in _Item)
                    {
                        _Conn.Delete(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + GetMethodName());
            }
            return _Rtn;
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
