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
    public class StaffDBContext: BaseDAL
    {
        private static StaffDBContext instance;
        private static readonly object instanceLock = new object();
        public StaffDBContext() { }
        public static StaffDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Staff> GetStaffByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "Select * from Staff_table where StaffName like @StaffName or StaffAdd like @StaffAdd";
            var parameters = new List<SqlParameter>();
            var nhanViens = new List<Staff>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@StaffName", 200,"%"+ tuKhoa+"%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@StaffAdd", 200, "%" + tuKhoa + "%", DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    nhanViens.Add(new Staff
                    {
                        StaffID = reader.GetInt32(0),
                        StaffName = reader.GetString(1),
                        StaffAdd = reader.GetString(3),
                        StaffPhone = reader.GetString(4),
                        StaffGender = reader.GetBoolean(2),
                        StaffDOB = reader.GetDateTime(5)
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
            return nhanViens;
        }

        public IEnumerable<Staff> GetStaffList()
        {
            IDataReader reader = null;
            string sql = "Select * from Staff_table";
            var nhanViens = new List<Staff>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    nhanViens.Add(new Staff
                    {
                        StaffID = reader.GetInt32(0),
                        StaffName = reader.GetString(1),
                        StaffAdd = reader.GetString(3),
                        StaffPhone = reader.GetString(4),
                        StaffGender = reader.GetBoolean(2),
                        StaffDOB = reader.GetDateTime(5)
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
            return nhanViens;
        }

        public Staff GetStaffByID(int nhanVienID)
        {
            Staff nv = null;
            IDataReader reader = null;
            string sql = "Select * from Staff_table where StaffID= @StaffID";
            try
            {
                var param = dataProvider.CreateParameter("@StaffID", 4, nhanVienID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    nv = new Staff
                    {
                        StaffID = reader.GetInt32(0),
                        StaffName = reader.GetString(1),
                        StaffAdd = reader.GetString(3),
                        StaffPhone = reader.GetString(4),
                        StaffGender = reader.GetBoolean(2),
                        StaffDOB = reader.GetDateTime(5)
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
            return nv;
        }

        public void AddNew(Staff nv)
        {
            try
            {
                Staff k = GetStaffByID(nv.StaffID);
                if (k == null)
                {
                    string sql = "INSERT INTO Staff(StaffName, StaffAdd, StaffPhone, StaffGender, StaffDOB) Values(@StaffName, @StaffAdd, @StaffPhone, @StaffGender, @StaffDOB)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@StaffName", 200, nv.StaffName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@StaffAdd", 200, nv.StaffAdd, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@StaffPhone", 50, nv.StaffPhone, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@StaffGender", 1, nv.StaffGender, DbType.Boolean));
                    parameters.Add(dataProvider.CreateParameter("@StaffDOB", 20, nv.StaffDOB, DbType.DateTime));
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

        public void Update(Staff nv)
        {
            try
            {
                Staff n = GetStaffByID(nv.StaffID);
                if (n != null)
                {
                    string sql = "UPDATE Staff set StaffName=@StaffName, StaffAdd=@StaffAdd, StaffPhone=@StaffPhone, StaffGender=@StaffGender, StaffDOB=@StaffDOB where StaffID=@StaffID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@StaffID", 4, nv.StaffID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@StaffName", 200, nv.StaffName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@StaffAdd", 200, nv.StaffAdd, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@StaffPhone", 50, nv.StaffPhone, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@StaffGender", 50, nv.StaffGender, DbType.Boolean));
                    parameters.Add(dataProvider.CreateParameter("@StaffDOB", 50, nv.StaffDOB, DbType.DateTime));
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

        public void Delete(int nhanVienID)
        {
            try
            {
                Staff k = GetStaffByID(nhanVienID);
                if (k != null)
                {
                    string sql = "DELETE Staff where StaffID=@StaffID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@StaffID", 4, nhanVienID, DbType.Int32));
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
