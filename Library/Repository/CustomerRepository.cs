using Library.BussinessObject;
using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomers() => CustomerDBContext.Instance.GetCustomerList();
        public IEnumerable<Customer> GetCustomerByKeyword(string keyword) => CustomerDBContext.Instance.GetCustomerByKeyword(keyword);
        public Customer GetCustomerByID(int khachHangId) => CustomerDBContext.Instance.GetCustomerByID(khachHangId);
        public void InsertCustomer(Customer khachHang) => CustomerDBContext.Instance.AddNew(khachHang);
        public void UpdateCustomer(Customer khachHang) => CustomerDBContext.Instance.Update(khachHang);
        public void DeleteCustomer(int khachHangId) => CustomerDBContext.Instance.Delete(khachHangId);
    }
}
