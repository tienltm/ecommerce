using Library.BussinessObject;
using Library.DataAcess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class CustomerDBContext: BaseDAL
    {
        private static CustomerDBContext instance;
        private static readonly object instanceLock = new object();
        public CustomerDBContext() { }
        public static CustomerDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Customer> GetCustomerByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "Select * from Customer_table where CustomerName like @CustomerName or CustomerAdd like @CustomerAdd";
            var parameters = new List<SqlParameter>();
            var khachHangs = new List<Customer>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@CustomerName", 200,"%"+ tuKhoa+"%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@CustomerAdd", 200, "%" + tuKhoa + "%", DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    khachHangs.Add(new Customer
                    {
                        CustomerID = reader.GetInt32(0),
                        CustomerName = reader.GetString(1),
                        CustomerAdd = reader.GetString(2),
                        CustomerPhone = reader.GetString(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return khachHangs;
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            IDataReader reader = null;
            string sql = "Select * from Customer_table";
            var khachHangs = new List<Customer>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    khachHangs.Add(new Customer
                    {
                        CustomerID = reader.GetInt32(0),
                        CustomerName = reader.GetString(1),
                        CustomerAdd = reader.GetString(2),
                        CustomerPhone = reader.GetString(3),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return khachHangs;
        }

        public Customer GetCustomerByID(int khachHangID)
        {
            Customer kh = null;
            IDataReader reader = null;
            string sql = "Select * from Customer_table where CustomerID= @CustomerID";
            try
            {
                var param = dataProvider.CreateParameter("@CustomerID", 4, khachHangID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    kh = new Customer
                    {
                        CustomerID = reader.GetInt32(0),
                        CustomerName = reader.GetString(1),
                        CustomerAdd = reader.GetString(2),
                        CustomerPhone = reader.GetString(3)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return kh;
        }

        public void AddNew(Customer kh)
        {
            try
            {
                Customer k = GetCustomerByID(kh.CustomerID);
                if (k == null)
                {
                    string sql = "INSERT INTO Customer(CustomerName, CustomerAdd, CustomerPhone) Values(@CustomerName, @CustomerAdd, @CustomerPhone)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CustomerName", 200, kh.CustomerName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CustomerAdd", 200, kh.CustomerAdd, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CustomerPhone", 50, kh.CustomerPhone, DbType.String));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Customer kh)
        {
            try
            {
                Customer k = GetCustomerByID(kh.CustomerID);
                if (k != null)
                {
                    string sql = "UPDATE Customer set CustomerName=@CustomerName, CustomerAdd=@CustomerAdd, CustomerPhone=@CustomerPhone where CustomerID=@CustomerID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CustomerID", 4, kh.CustomerID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CustomerName", 200, kh.CustomerName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CustomerAdd", 200, kh.CustomerAdd, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CustomerPhone", 50, kh.CustomerPhone, DbType.String));
                    dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int khachHangID)
        {
            try
            {
                Customer k = GetCustomerByID(khachHangID);
                if (k != null)
                {
                    string sql = "DELETE Customer where CustomerID=@CustomerID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CustomerID", 4, khachHangID, DbType.Int32));
                    dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
