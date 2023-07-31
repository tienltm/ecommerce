using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BussinessObject
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public decimal PriceBuy { get; set; }
        public decimal PriceSale { get; set; }
        public string Picture { get; set; }
        public string Note { get; set; }
    }
}
