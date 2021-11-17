using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLSQA;
namespace DAO_QLSQA
{
    public class DAO_Sanpham
    {
        // Thêm sản phẩm
        public bool ThemSP(DTO_Sanpham sp,string manv)
        {
            string query = "sp_themSP @masp , @tensp , @dgn , @dgb , @doituong , @hinhanhtrc , @hinhanhsau , @maloai , @soluong  , @size , @mamau , @manv ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { sp.MaSP, sp.TenSP, sp.DongiaNhap, sp.DongiaBan, sp.DoiTuong, sp.HinhAnhtrc, sp.HinhAnhsau, sp.MaLoai, sp.SoLuong, sp.Size, sp.Mamau, manv });
            if (result > 0) 
                return true;
            return false;
        }
        // hiển thị dssp chi tiết
        public DataTable hienthiDSSP()
        {
            DataTable dt = new DataTable();
            string query = "sp_danhsachchitietsp";
           dt =  DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        // hiển thị dssp rút gọn
        public DataTable hienthiDSSP_rutgon()
        {
            DataTable dt = new DataTable();
            string query = "sp_danhsachsp";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        // hiển thị ảnh sản phẩm
        public List<DTO_Sanpham> ShowListImage()
        {
            List<DTO_Sanpham> listsp = new List<DTO_Sanpham>();
            string query = "sp_loadImage";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_Sanpham sp = new DTO_Sanpham(item);
                listsp.Add(sp);
            }
            return listsp;
        }
        // hiển thị các loại mặt hàng lên combo box
        public DataTable hienthiCombobox()
        {
            string query = "select * from PHANLOAISP";
            DataTable tb = DataProvider.Instance.ExecuteQuery(query);
            return tb;
        }
        // hiển thị các loại màu sắc lên combo box
        public DataTable hienthiComboboxMauSac()
        {
            string query = "select * from Mausac";
            DataTable tb = DataProvider.Instance.ExecuteQuery(query);
            return tb;
        }
        // hiển thị giá và tên sp
        public List<DTO_Sanpham> ShowNameAndPriceItem(string masp)
        {
            List<DTO_Sanpham> listsp = new List<DTO_Sanpham>();
            string query = "sp_danhsachsp @masp";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { masp });
            foreach (DataRow item in dt.Rows)
            {
                DTO_Sanpham sp = new DTO_Sanpham(item);
                listsp.Add(sp);
            }
            return listsp;
        }
    }
}
