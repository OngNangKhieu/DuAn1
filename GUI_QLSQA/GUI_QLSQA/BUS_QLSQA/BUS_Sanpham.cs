using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLSQA;
using DAO_QLSQA;
using System.Data;
using DTO_QLSQA;
namespace BUS_QLSQA
{
    public class BUS_Sanpham
    {
        DAO_Sanpham daosanpham = new DAO_Sanpham();
        public bool ThemSP(DTO_Sanpham sp, string manv)
        {
            return daosanpham.ThemSP(sp, manv);
        }
        public DataTable hienthiDSSP()
        {
            return daosanpham.hienthiDSSP();
        }
        public DataTable hienthiDSSP_rutgon()
        {
            return daosanpham.hienthiDSSP_rutgon();
        }
        public List<DTO_Sanpham> LoadShowListImage()
        {
            return daosanpham.ShowListImage();
        }
        public DataTable hienthiCombobox()
        {
            return daosanpham.hienthiCombobox();
        }
        public DataTable hienthiComboboxMauSac()
        {
            return daosanpham.hienthiComboboxMauSac();

        }
        public List<DTO_Sanpham> ShowNameAndPriceItem(string masp)
        {
            return daosanpham.ShowNameAndPriceItem(masp);
        }
    }
}
