using Library.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> GetStaffs();
        IEnumerable<Staff> GetStaffByKeyword(string keyword);
        Staff GetStaffByID(int nhanVienId);
        void InsertStaff(Staff nhanVien);
        void UpdateStaff(Staff nhanVien);
        void DeleteStaff(int nhanVienId);
    }
}
