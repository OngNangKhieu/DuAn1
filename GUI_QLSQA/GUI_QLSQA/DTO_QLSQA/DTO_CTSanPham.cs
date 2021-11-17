using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO_QLSQA
{
    public class DTO_CTSanPham
    {
        private string maSP;
        private int soLuong;
        private int size;
        private int maMau;
        public DTO_CTSanPham()
        {

        }
        public DTO_CTSanPham(DataRow row)
        {
            this.MaSP = row["MaSP"].ToString();
            this.Size = int.Parse(row["Size"].ToString());
            this.MaMau = int.Parse(row["MaMau"].ToString());
            this.SoLuong = int.Parse(row["SoLuong"].ToString());
        }
        public DTO_CTSanPham(DataRow row, bool size)
        {
                this.MaSP = row["MaSP"].ToString();
                this.Size = int.Parse(row["Size"].ToString());
                this.MaMau = int.Parse(row["MaMau"].ToString());
                this.SoLuong = int.Parse(row["SoLuong"].ToString());
        }
        public DTO_CTSanPham(DataRow row,bool color, bool size)
        {
            this.MaSP = row["MaSP"].ToString();
            if(color && size)
            {
                this.MaMau = int.Parse(row["MaMau"].ToString());
                this.Size = int.Parse(row["Size"].ToString());
            }
            else if(color && !size)
                this.MaMau = int.Parse(row["MaMau"].ToString());
            else if(!color && size)
                this.Size = int.Parse(row["Size"].ToString());
            else
            {
                this.MaSP = row["MaSP"].ToString();
                this.SoLuong = int.Parse(row["SoLuong"].ToString());
                this.Size = int.Parse(row["Size"].ToString());
                this.MaMau = int.Parse(row["MaMau"].ToString());
            }
        }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Size { get => size; set => size = value; }
        public int MaMau { get => maMau; set => maMau = value; }
    }
}
