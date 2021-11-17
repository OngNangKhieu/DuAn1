using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLSQA
{
    public partial class FMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static string mailnv;
        private static FMain instance;
        public static FMain Instance
        {
            get { if (instance == null) instance = new FMain(); return FMain.instance; }
            private set { FMain.instance = value; }
        }

        public FMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region codeform
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.Black;
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 212, 59);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.Black;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 212, 59);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lblTitleChildForm.Text = "Trang chủ";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FNhanvien());
            lblTitleChildForm.Text = btnNhanvien.Text;
        }

        private void btnMucluc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FMucluc());
            lblTitleChildForm.Text = btnMucluc.Text;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FSanpham());
            lblTitleChildForm.Text = btnSanPham.Text;
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            lblTitleChildForm.Text = btnKhachhang.Text;
            OpenChildForm(new FKhachhang());
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnVanchuyen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FVanchuyen());
            lblTitleChildForm.Text = btnVanchuyen.Text;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FDanhsachhoaDon());
            lblTitleChildForm.Text = btnHoaDon.Text;
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FDoanhThu());
            lblTitleChildForm.Text = btnDoanhthu.Text;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FThanhToans());
            lblTitleChildForm.Text = btnThanhToan.Text;
        }
        private void iconuser_Click(object sender, EventArgs e)
        {
            Thongtinnv();
        }
        private void Thongtinnv()
        {
            FThongtinNV childForm = new FThongtinNV(mailnv);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSanPham_MouseHover(object sender, EventArgs e)
        {
           
        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }


        #endregion

        #region events
        public void FMain_Load(object sender, EventArgs e)
        {
            lblTennguoidung.Text = "Hiiiiii," + " " + mailnv;
            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region Codes
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            FLogin f = new FLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
