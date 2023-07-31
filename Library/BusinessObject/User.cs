using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BussinessObject
{
    public class User
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserType { get; set; }
        public int? UserID { get; set; }
    }
}
