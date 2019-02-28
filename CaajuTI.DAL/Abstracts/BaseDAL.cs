using CaajuTI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace CaajuTI.DAL.Abstracts
{
    public abstract class BaseDAL : IBaseDAL,IDisposable
    {
        readonly IDbConnection _connection;
        public BaseDAL(IDbConnection connection, string connectionString)
        {
            _connection = connection;
            _connection.ConnectionString = GetConnectionString(connectionString);

            _connection.Open();

        }

        public void ExecuteCommand(string sql, IQueryParameter parameter)
        {
            using (var command=GetCommand())
            {
                command.Connection = _connection;
                command.CommandText = sql;
                foreach (var item in parameter.Get())
                {
                    command.Parameters.Add(GetParameter(item));
                }

                command.ExecuteNonQuery();
            }
        }

        public DataSet ExecuteQuery(string sql)
        {
            using (var command = GetCommand())
            {
                command.Connection = _connection;
                command.CommandText = sql;
                return FillDataSet(command);
            }
        }

        private DataSet FillDataSet(IDbCommand command)
        {
            DataSet ds=new DataSet();
            GetDataAdapter(command).Fill(ds);
            return ds;
        }

        public DataSet ExecuteQuery(string sql, IQueryParameter parameter)
        {
            using (var command = GetCommand())
            {
                command.Connection = _connection;
                command.CommandText = sql;
                foreach (var item in parameter.Get())
                {
                    command.Parameters.Add(GetParameter(item));
                }

                return FillDataSet(command);
            }
        }

        protected abstract object GetParameter(KeyValuePair<string, object> parameter);
        protected abstract IDbCommand GetCommand();
        protected abstract IDbDataAdapter GetDataAdapter(IDbCommand command);

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }

        private string GetConnectionString(string connectionString)
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ToString();
        }
    }
}
