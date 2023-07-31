using Library.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductByKeyword(string keyword);
        Product GetProductByID(int productId);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
