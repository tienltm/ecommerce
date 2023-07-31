using Library.BussinessObject;
using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public IEnumerable<Staff> GetStaffs() => StaffDBContext.Instance.GetStaffList();
        public IEnumerable<Staff> GetStaffByKeyword(string keyword) => StaffDBContext.Instance.GetStaffByKeyword(keyword);
        public Staff GetStaffByID(int nhanVienId) => StaffDBContext.Instance.GetStaffByID(nhanVienId);
        public void InsertStaff(Staff nhanVien) => StaffDBContext.Instance.AddNew(nhanVien);
        public void UpdateStaff(Staff nhanVien) => StaffDBContext.Instance.Update(nhanVien);
        public void DeleteStaff(int nhanVienId) => StaffDBContext.Instance.Delete(nhanVienId);
    }
}
