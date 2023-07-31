using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library.BussinessObject;
using Microsoft.Data.SqlClient;

namespace Library.DataAcess
{
    public class UserDBContext : BaseDAL
    {
        private static UserDBContext instance;
        private static readonly object instanceLock = new object();
        public UserDBContext() { }
        public static UserDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDBContext();
                    }
                    return instance;
                }
            }
        }
        public User GetInfo(string UserName, string UserPassword)
        {
            User user = null;
            IDataReader? reader = null;
            var parameters = new List<SqlParameter>();
            string sql = "Select * from Login_table where UserName like @UserName and UserPassword like @UserPassword";
            try
            {
                parameters.Add(dataProvider.CreateParameter("@UserName", 50, UserName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@UserPassword", 50, UserPassword, DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                if (reader.Read())
                {
                    user = new User
                    {
                        UserName = reader.GetString(0),
                        UserPassword = reader.GetString(1),
                        UserType = reader.GetInt32(2),
                        UserID = reader.GetInt32(3)
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
            return user;
        }

        public IEnumerable<User> GetUserList()
        {
            IDataReader? reader = null;
            string sql = "Select * from Login_table";
            var Users = new List<User>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    Users.Add(new User
                    {
                        UserName = reader.GetString(0),
                        UserPassword = reader.GetString(1),
                        UserType = reader.GetInt32(2),
                        UserID = reader.GetInt32(3),
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
            return Users;
        }

        public IEnumerable<User> GetUserByKeyword(string keyWord)
        {
            IDataReader reader = null;
            string sql = "Select * from Login_table where UserName like @UserName";
            var parameters = new List<SqlParameter>();
            var Users = new List<User>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@UserName", 50, "%" + keyWord + "%", DbType.String));
                //parameters.Add(dataProvider.CreateParameter("@UserType", 4, keyWord, DbType.Int32));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    Users.Add(new User
                    {
                        UserName = reader.GetString(0),
                        UserPassword = reader.GetString(1),
                        UserType = reader.GetInt32(2),
                        UserID = reader.GetInt32(3),
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
            return Users;
        }

        public User GetUserByUserName(string userName)
        {
            User nd = null;
            IDataReader reader = null;
            string sql = "Select * from Login_table where UserName like @UserName";
            try
            {
                var param = dataProvider.CreateParameter("@UserName", 50, userName, DbType.String);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    nd = new User
                    {
                        UserName = reader.GetString(0),
                        UserPassword = reader.GetString(1),
                        UserType = reader.GetInt32(2),
                        UserID = reader.GetInt32(3)
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
            return nd;
        }

        public void AddNew(User info)
        {
            try
            {
                User k = GetUserByUserName(info.UserName);
                if (k == null)
                {
                    string sql = "INSERT INTO User(UserName, UserPassword, UserType, UserID) Values(@UserName, @UserPassword, @UserType, @UserID)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@UserName", 50, info.UserName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UserPassword", 50, info.UserPassword, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UserType", 4, info.UserType, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UserID", 4, info.UserID, DbType.Int32));
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

        public void Update(User info)
        {
            try
            {
                User k = GetUserByUserName(info.UserName);
                if (k != null)
                {
                    string sql = "UPDATE User set UserName=@UserName, UserPassword=@UserPassword, UserType=@UserType, UserID=@UserID where UserName like @UserName";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@UserName", 50, info.UserName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UserPassword", 50, info.UserPassword, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UserType", 4, info.UserType, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@UserID", 4, info.UserID, DbType.Int32));
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

        public void Delete(string userName)
        {
            try
            {
                User nd = GetUserByUserName(userName);
                if (nd != null)
                {
                    string sql = "DELETE User where UserName like @UserName";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@UserName", 4, userName, DbType.Int32));
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
