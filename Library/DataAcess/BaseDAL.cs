using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;



namespace Library.DataAcess
{
    public class BaseDAL
    {
        public ecommerceDataProvider dataProvider {  get; set; }
        public SqlConnection connection = null;
        public BaseDAL() {
            var connectionString = GetConnectionString();
            dataProvider = new ecommerceDataProvider(connectionString);
                }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            return config["ConnectionStrings:EcommerceDB"];

        }
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
