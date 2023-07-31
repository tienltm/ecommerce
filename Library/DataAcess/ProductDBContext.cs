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
    public class ProductDBContext : BaseDAL
    {
        private static ProductDBContext instance;
        private static readonly object instanceLock = new object();
        public ProductDBContext() { }
        public static ProductDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetProductByKeyword(string tuKhoa)
        {
            IDataReader reader = null;
            string sql = "Select * from Product_table where ProductName like @ProductName or Note like @Note";
            var parameters = new List<SqlParameter>();
            var products = new List<Product>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@ProductName", 200,"%"+ tuKhoa+"%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Note", 500, "%" + tuKhoa + "%", DbType.String));
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, parameters.ToArray());
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Unit = reader.GetInt32(2),
                        PriceBuy = reader.GetDecimal(3),
                        PriceSale = reader.GetDecimal(4),
                        Picture = reader.GetString(5),
                        Note = reader.GetString(6),
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
            return products;
        }

        public IEnumerable<Product> GetProductList()
        {
            IDataReader reader = null;
            string sql = "Select * from Product_table";
            var products = new List<Product>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Unit = reader.GetInt32(2),
                        PriceBuy = reader.GetDecimal(3),
                        PriceSale = reader.GetDecimal(4),
                        Picture = reader.GetString(5),
                        Note = reader.GetString(6),
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
            return products;
        }

        public Product GetProductByID(int productID)
        {
            Product hh = null;
            IDataReader reader = null;
            string sql = "Select * from Product_table where ProductID= @ProductID";
            try
            {
                var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    hh = new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Unit = reader.GetInt32(2),
                        PriceBuy = reader.GetDecimal(3),
                        PriceSale = reader.GetDecimal(4),
                        Picture = reader.GetString(5),
                        Note = reader.GetString(6),
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
            return hh;
        }

        public void AddNew(Product hh)
        {
            try
            {
                Product h = GetProductByID(hh.ProductID);
                if (h == null)
                {
                    string sql = "INSERT INTO Product(ProductName, Unit, PriceBuy, PriceSale, Picture, Note) Values(@ProductName, @Unit, @PriceBuy, @PriceSale, @Picture, @Note)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 200, hh.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Unit", 4, hh.Unit, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@PriceBuy", 10, hh.PriceBuy, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@PriceSale", 10, hh.PriceSale, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Picture", 50, hh.Picture, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Note", 500, hh.Note, DbType.String));
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

        public void Update(Product hh)
        {
            try
            {
                Product h = GetProductByID(hh.ProductID);
                if (h != null)
                {
                    string sql = "UPDATE Product set ProductName=@ProductName, Unit=@Unit, PriceBuy=@PriceBuy, PriceSale=@PriceSale, Picture=@Picture, Note=@Note where ProductID=@ProductID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, hh.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 200, hh.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Unit", 4, hh.Unit, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@PriceBuy", 10, hh.PriceBuy, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@PriceSale", 10, hh.PriceSale, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Picture", 50, hh.Picture, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Note", 500, hh.Note, DbType.String));
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

        public void Delete(int productID)
        {
            try
            {
                Product k = GetProductByID(productID);
                if (k != null)
                {
                    string sql = "DELETE Product where ProductID=@ProductID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32));
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
