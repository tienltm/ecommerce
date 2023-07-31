using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.BussinessObject;
using Library.DataAcess;


namespace Library.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetUserLogin(string UserName, string UserPassword)
            =>UserDBContext.Instance.GetInfo(UserName, UserPassword);

        public IEnumerable<User> GetUserList()=>UserDBContext.Instance.GetUserList();
        public IEnumerable<User> GetUserByKeyword(string keyWord)=>UserDBContext.Instance.GetUserByKeyword(keyWord);
        public User GetUserByUserName(string userName)=> UserDBContext.Instance.GetUserByUserName(userName);
        public void AddNewUser(User info)=>UserDBContext.Instance.AddNew(info);
        public void UpdateUser(User info) => UserDBContext.Instance.Update(info);
        public void DeleteUser(string userName)=>UserDBContext.Instance.Delete(userName);

    }
}
