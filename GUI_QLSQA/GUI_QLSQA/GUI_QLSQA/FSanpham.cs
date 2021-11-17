using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLSQA;
using DTO_QLSQA;
namespace GUI_QLSQA
{
    public partial class FSanpham : Form
    {
        BUS_DanhMucSP busdmsp = new BUS_DanhMucSP();
        BUS_Nhanvien nv = new BUS_Nhanvien();
        BUS_Sanpham bussp = new BUS_Sanpham();
        BUS_DonVanChuyen busdvc = new BUS_DonVanChuyen();
        string fileName;// tên file
        string fileName1;// tên file
        string emailnv ="Long@gmail.com";
        string manv;
        string fileAddress; // url load images
        string hinhanhtrc;
        string hinhanhsau;
        string sourceDirFore;
        string backupDir = Application.StartupPath + @"\Resources";
        string sourceDirBack;
        int doituong;
        int size;
        string loadanhtruoc;
        string loadanhsau;
        public FSanpham()
        {
            InitializeComponent();

        }

        // Tải lại form

        #region code
        public void LoadForm()
        {
            if (btnChitiet.Checked)
                dtgvdsSanpham.DataSource = bussp.hienthiDSSP();
            else
                dtgvdsSanpham.DataSource = bussp.hienthiDSSP_rutgon();
            manv = nv.LayMaNV(emailnv).ToString();
        }
        public void LoadCombobox()
        {
            cbTenloai.DataSource = bussp.hienthiCombobox();
            cbTenloai.DisplayMember = "TenLoai";
            cbTenloai.ValueMember = "MaLoai";
            cbMausac.DataSource = bussp.hienthiComboboxMauSac();
            cbMausac.DisplayMember = "tenmau";
            cbMausac.ValueMember = "mamau";
        }
        #endregion
        #region EVents
        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            FDSSanpham.Instance.ShowDialog();
        }
        // btn add ảnh phía trước của sản phẩm
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|JPEG Image(*.jfif)|*.jfif|PNG(*.png)|*.png|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 5;
            dlgOpen.Title = "Chọn ảnh sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pbAnh1.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                // lấy đường dẫn file chứa ảnh
                string FolderPathContainsImg = "";
                string[] spFile = fileAddress.Split('\\');
                hinhanhtrc = spFile[spFile.Length - 1];
                foreach (string item in spFile)
                {
                    if (!item.Contains(spFile[spFile.Length - 1]))
                    {
                        FolderPathContainsImg += item + "\\";
                    }
                }
                sourceDirFore = FolderPathContainsImg;
            }
           
        }
        // btn add ảnh phía sau của sản phẩm
        private void btnAnhsau_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|JPEG Image(*.jfif)|*.jfif|PNG(*.png)|*.png|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 5;
            dlgOpen.Title = "Chọn ảnh sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pbAnh2.Image = Image.FromFile(fileAddress);
                fileName1 = Path.GetFileName(dlgOpen.FileName);
                // lấy đường dẫn file chứa ảnh
                string FolderPathContainsImg = "";
                string[] spFile = fileAddress.Split('\\');
                hinhanhsau = spFile[spFile.Length - 1];
                foreach (string item in spFile)
                {
                    if (!item.Contains(spFile[spFile.Length - 1]))
                    {
                        FolderPathContainsImg += item + "\\";
                    }
                }
                sourceDirBack = FolderPathContainsImg;
            }
        }

        public void FSanpham_Load(object sender, EventArgs e)
        {
            LoadForm();
            LoadCombobox();
            btnThem.Checked = false;
            TurnOff();
        }

        private void btnChitiet_CheckedChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nv.checkData(new string[] { txtMasp.Text.Trim(), txtTensp.Text.Trim(), txtGiaNhap.Text.Trim(), txtGiaBan.Text.Trim(), txtSl.Text.Trim() }))
            {
                bool checkdata;
                if (nv.hasSpecialChar(txtMasp.Text) || nv.hasSpecialChar(txtTensp.Text))
                    checkdata = false;
                else if (!nv.checkisNumber(txtGiaBan.Text) || !nv.checkisNumber(txtGiaNhap.Text) || !nv.checkisNumber(txtSl.Text))
                    checkdata = false;
                else
                    checkdata = true;
                if (checkdata)
                {
                    if( txtMasp.Text.Trim().Length > 5)
                    {
                        MessageBox.Show("Mã sp chỉ từ 1 - 5 ký tự", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if(txtTensp.Text.Trim().Length > 30)
                        MessageBox.Show("Tên sp quá dài", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if(float.Parse(txtGiaNhap.Text)>10000000 || float.Parse(txtGiaBan.Text) > 10000000)
                        MessageBox.Show("Giá không hợp lệ", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (int.Parse(txtSl.Text)>1000)
                        MessageBox.Show("Vượt quá số lượng nhập hàng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if(sourceDirFore != null && sourceDirBack != null)
                         {
                            if (rdbNam.Checked) doituong = 0;
                            else if (rdbNu.Checked) doituong = 1;
                            else doituong = 2;
                            if (rdbSizeS.Checked) size = 1;
                            else if (rdbSizeM.Checked) size = 2;
                            else if (rdbSizeL.Checked) size = 3;
                            else if (rdbSizeXL.Checked) size = 4;
                            else size = 5;
                            DTO_Sanpham sp = new DTO_Sanpham();
                            sp.DoiTuong = doituong;
                            sp.DongiaBan = float.Parse(txtGiaBan.Text);
                            sp.DongiaNhap = float.Parse(txtGiaNhap.Text);
                            sp.HinhAnhsau = hinhanhsau;
                            sp.HinhAnhtrc = hinhanhtrc;
                            sp.MaLoai = cbTenloai.SelectedValue.ToString();
                            sp.Mamau = int.Parse(cbMausac.SelectedValue.ToString());
                            sp.MaSP = txtMasp.Text;
                            sp.Size = size;
                            sp.SoLuong = int.Parse(txtSl.Text);
                            sp.TenSP = txtTensp.Text.Trim();
                            if (bussp.ThemSP(sp, manv))
                            {
                                nv.LuuAnh(fileName, sourceDirFore, backupDir);
                                nv.LuuAnh(fileName1, sourceDirBack, backupDir);
                                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Không thêm được rồi đại vương ơi", "Báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin mời bạn chọn ảnh", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nhập đầy đủ dữ liệu", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadForm();
        }

        private void btnThem_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void TurnOn()
        {
            txtGiaNhap.Enabled = true;
            txtMasp.Enabled = true;
            txtTensp.Enabled = true;
            txtGiaBan.Enabled = true;
            txtSl.Enabled = true;
            cbTenloai.Enabled = true;
            cbMausac.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            rdbNamvaNu.Enabled = true;
            rdbSizeL.Enabled = true;
            rdbSizeM.Enabled = true;
            rdbSizeS.Enabled = true;
            rdbSizeXL.Enabled = true;
            rdbSizeXXL.Enabled = true;
            btnAnhtrc.Enabled = true;
            btnAnhsau.Enabled = true;
        }
        private void TurnOff()
        {
            txtGiaNhap.Enabled = false;
            txtMasp.Enabled = false;
            txtTensp.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSl.Enabled = false;
            cbTenloai.Enabled = false;
            cbMausac.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            rdbNamvaNu.Enabled = false;
            rdbSizeL.Enabled = false;
            rdbSizeM.Enabled = false;
            rdbSizeS.Enabled = false;
            rdbSizeXL.Enabled = false;
            rdbSizeXXL.Enabled = false;
            btnAnhtrc.Enabled = false;
            btnAnhsau.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            busdvc.XoaBillVC();
            if (!btnThem.Checked)
            {
                if (MessageBox.Show("Bạn có muốn BẬT chế độ nhập sản phẩm ?", "Tớ hỏi cậu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnThem.Checked = true;
                    TurnOn();
                    busdvc.ThemBillVC();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn TẮT chế độ nhập sản phẩm ?", "Tớ hỏi cậu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnThem.Checked = false;
                    TurnOff();
                    busdvc.XoaBillVC();
                }
            }
        }

        private void cbTenloai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckThayDoiCbLoaiSP(cbTenloai.SelectedValue.ToString()))
            {
                MessageBox.Show("có");
            }
            else
            {
                MessageBox.Show("không");
            }
        }
        private bool CheckThayDoiCbLoaiSP(string value)
        {
            List<DTO_Loaisp> listloaisp = busdmsp.loadCBLoaisp();
            foreach (DTO_Loaisp item in listloaisp)
            {
                if (item.MaLoai.Contains(value))
                {
                    return true; break;
                }
            }
            return false;
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
            {

            }
            else 
            {
                rdbNam.Checked = true;
            }
        }

        private void dtgvdsSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.Text = dtgvdsSanpham.CurrentRow.Cells["masp"].Value?.ToString();
            txtTensp.Text = dtgvdsSanpham.CurrentRow.Cells["tensp"].Value?.ToString();
            txtGiaNhap.Text = dtgvdsSanpham.CurrentRow.Cells["dongianhap"].Value?.ToString();
            txtGiaBan.Text = dtgvdsSanpham.CurrentRow.Cells["dongiaban"].Value?.ToString();
            txtSl.Text = dtgvdsSanpham.CurrentRow.Cells["tongsoluong"].Value?.ToString();
            loadanhtruoc = dtgvdsSanpham.CurrentRow.Cells["hinhanhtrc"].Value.ToString();
            loadanhsau = dtgvdsSanpham.CurrentRow.Cells["hinhanhsau"].Value.ToString();


            //rdbNam.DataBindings.Add(new Binding("Checked", dtgvdsSanpham.DataSource, "doituong", true, DataSourceUpdateMode.Never));
            // rdbSizeS.DataBindings.Add(new Binding("Checked", dtgvdsSanpham.DataSource, "Size", true, DataSourceUpdateMode.Never));
            pbAnh1.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + loadanhtruoc);
            pbAnh2.Image = Image.FromFile(Application.StartupPath + "\\Resources\\" + loadanhsau);
        }
        private void LoadSanPham()
        {
            
        }
    }
    #endregion
}
