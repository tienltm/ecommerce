using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcess
{
    public class ecommerceDataProvider
    {
        public string ConnectionString { get; set; }
        public ecommerceDataProvider(string connectionString) => ConnectionString = connectionString;

        public SqlParameter CreateParameter (string parameterName, int size,  object value, DbType dbType, ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = parameterName,
                Size = size,
                Value = value,
                Direction = direction
            };
        }
        public void CloseConnection(SqlConnection connection)=>connection.Close();
        public IDataReader GetDataAdapter(string commandText, CommandType commandType, out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
        public void Insert(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using var connection = new SqlConnection(ConnectionString);
                connection.Open();
                using var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
