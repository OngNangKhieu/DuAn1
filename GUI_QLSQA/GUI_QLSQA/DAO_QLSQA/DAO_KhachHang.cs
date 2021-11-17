using DTO_QLSQA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QLSQA
{
    public class DAO_KhachHang
    {
        public DataTable getDanhSachKH()
        {
            string query = "select sdt,tenkh,diemtichluy from khachhang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public bool themKH(DTO_KhachHang kh)
        {
            string query = "exec sp_insertKh @sdt , @tenkh";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            { kh.SDT  , kh.TEn });
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateKH(DTO_KhachHang kh)
        {
            string query = "sp_updateKh @sdt , @tenkh";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]{kh.SDT,kh.TEn});
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool XoaKH(string sdt)
        {
            string query = "sp_XoaKH @DIENTHOAI";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sdt });
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable TimKiemKH(string tenkh)
        {
            DataTable dt = new DataTable();
            string query = "sp_TimkiemKH @tenkh";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tenkh });
            return dt;
        }
    }
}
