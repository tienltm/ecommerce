using Library.BussinessObject;
using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts() => ProductDBContext.Instance.GetProductList();
        public IEnumerable<Product> GetProductByKeyword(string keyword) => ProductDBContext.Instance.GetProductByKeyword(keyword);
        public Product GetProductByID(int productId) => ProductDBContext.Instance.GetProductByID(productId);
        public void InsertProduct(Product product) => ProductDBContext.Instance.AddNew(product);
        public void UpdateProduct(Product product) => ProductDBContext.Instance.Update(product);
        public void DeleteProduct(int productId) => ProductDBContext.Instance.Delete(productId);
    }
}
