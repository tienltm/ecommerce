using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.BussinessObject;

namespace Library.Repository
{
    public interface IUserRepository
    {
        User GetUserLogin(string UserName, string UserPassword);
        IEnumerable<User> GetUserList();
        IEnumerable<User> GetUserByKeyword(string keyWord);
        User GetUserByUserName(string userName);
        void AddNewUser(User info);
        void UpdateUser(User info);
        void DeleteUser(string userName);

    }
}
