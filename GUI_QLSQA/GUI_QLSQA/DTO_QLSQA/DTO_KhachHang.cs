using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSQA
{
    public class DTO_KhachHang
    {
        private string sDT;
        private string tEn;
        public DTO_KhachHang()
        {

        }
        public DTO_KhachHang(string sdt , string ten)
        {
            this.SDT = sdt;
            this.TEn = ten;
        }
        public string SDT { get => sDT; set => sDT = value; }
        public string TEn { get => tEn; set => tEn = value; }
    }
}
