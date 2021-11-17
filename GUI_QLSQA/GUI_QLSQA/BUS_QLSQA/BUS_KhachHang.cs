using DTO_QLSQA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QLSQA;
using DTO_QLSQA;
namespace BUS_QLSQA
{
    public class BUS_KhachHang
    {
        DAO_KhachHang daokh = new DAO_KhachHang();
        
        public DataTable getDanhSachKH()
        {
            return daokh.getDanhSachKH();
        }
        public bool themKH(DTO_KhachHang kh)
        {
            return daokh.themKH(kh);
        }
        public bool UpdateKH(DTO_KhachHang kh)
        {
            return daokh.UpdateKH(kh);
        }
        public bool XoaKH(string sdt)
        {
            return daokh.XoaKH(sdt);
        }
        public DataTable TimKiemKH(string tenkh)
        {
            return daokh.TimKiemKH(tenkh);
        }
    }
}
