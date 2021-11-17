using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLSQA;
using BUS_QLSQA;
namespace GUI_QLSQA
{
    public partial class FKhachhang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        BUS_Nhanvien busnv = new BUS_Nhanvien();
        public FKhachhang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool checkdata;

            if (txtTenKH.Text.Trim().Length < 5 || txtTenKH.Text.Trim().Length > 30)
            {
                MessageBox.Show("Họ tên chỉ chứa 5 - 30 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
            }
            else if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số ĐT chỉ chứa 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
            }else if (busnv.checkcontainNumber(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Tên không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
            }else if (busnv.hasSpecialChar(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Tên không được chứa ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
            }
            else
            {
                DTO_KhachHang khach = new DTO_KhachHang(txtSDT.Text, txtTenKH.Text);
                if (buskh.themKH(khach))
                {
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    LoadGridview_Khachhang();
                }
                else
                {
                    MessageBox.Show("Thêm Khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FKhachhang_Load(object sender, EventArgs e)
        {
            LoadGridview_Khachhang();
            TurnOff();
        }
        private void LoadGridview_Khachhang()
        {
            dataGridView1.DataSource = buskh.getDanhSachKH();
            dataGridView1.Columns[0].HeaderText = "Số điện thoại";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderText = "Điểm tích lũy";
        }
        private void ResetValue()
        {
            txtSDT.Text = null;
            txtTenKH.Text = null;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Trim().Length < 5 || txtTenKH.Text.Trim().Length > 30)
            {
                MessageBox.Show("Họ tên chỉ chứa 5 - 30 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
            }
            else if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số ĐT chỉ chứa 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
            }
            else if (busnv.checkcontainNumber(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Tên không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
            }
            else if (busnv.hasSpecialChar(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Tên không được chứa ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
            }
            else
            {
                DTO_KhachHang khach = new DTO_KhachHang(txtSDT.Text, txtTenKH.Text);
                if (buskh.UpdateKH(khach))
                {
                    txtTenKH.Text = "";
                    txtSDT.Text = "";
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridview_Khachhang();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (buskh.XoaKH(sdt))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    ResetValue();
                    LoadGridview_Khachhang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                ResetValue();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSDT.Text = dataGridView1.CurrentRow.Cells["sdt"].Value?.ToString();
            txtTenKH.Text = dataGridView1.CurrentRow.Cells["tenkh"].Value?.ToString();
        }
        private void TurnOn()
        {
            txtSDT.Enabled = true;
            txtTenKH.Enabled = true;
        }
        private void TurnOff()
        {
            txtSDT.Enabled = false;
            txtTenKH.Enabled = false;
        }
        private void btnThem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnThem.Checked == true)
            {
                TurnOn();
                ResetValue();
            }
            else
            {
                TurnOff();
                ResetValue();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenkh = txtTim.Text;
            if (txtTim.Text.Length > 0)
            {
                dataGridView1.DataSource = buskh.TimKiemKH(tenkh);
                dataGridView1.Columns[0].HeaderText = "SĐT";
                dataGridView1.Columns[1].HeaderText = "Họ Tên";
               
            }
        }
    }
}
