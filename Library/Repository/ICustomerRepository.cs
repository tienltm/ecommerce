using Library.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> GetCustomerByKeyword(string keyword);
        Customer GetCustomerByID(int khachHangId);
        void InsertCustomer(Customer khachHang);
        void UpdateCustomer(Customer khachHang);
        void DeleteCustomer(int khachHangId);
    }
}
