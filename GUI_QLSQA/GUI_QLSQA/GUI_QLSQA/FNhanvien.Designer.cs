
namespace GUI_QLSQA
{
    partial class FNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTailai = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvdsNhanvien = new System.Windows.Forms.DataGridView();
            this.btnAnh = new FontAwesome.Sharp.IconButton();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new DemoCTControls.NAToggleButton();
            this.rdbNu = new DemoCTControls.NARadioButton();
            this.rdbNam = new DemoCTControls.NARadioButton();
            this.rdbNhanvien = new DemoCTControls.NARadioButton();
            this.rdbQuanly = new DemoCTControls.NARadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdsNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTailai);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgvdsNhanvien);
            this.panel1.Controls.Add(this.btnAnh);
            this.panel1.Controls.Add(this.pbAnh);
            this.panel1.Controls.Add(this.rdbNhanvien);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rdbQuanly);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtHoten);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 943);
            this.panel1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(476, 60);
            this.label7.TabIndex = 68;
            this.label7.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnTailai
            // 
            this.btnTailai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTailai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTailai.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnTailai.IconColor = System.Drawing.Color.Black;
            this.btnTailai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTailai.IconSize = 30;
            this.btnTailai.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTailai.Location = new System.Drawing.Point(681, 373);
            this.btnTailai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTailai.Size = new System.Drawing.Size(76, 41);
            this.btnTailai.TabIndex = 67;
            this.btnTailai.UseVisualStyleBackColor = true;
            this.btnTailai.Click += new System.EventHandler(this.btnTailai_Click);
            // 
            // btnTim
            // 
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTim.IconColor = System.Drawing.Color.Black;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 30;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTim.Location = new System.Drawing.Point(597, 373);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTim.Size = new System.Drawing.Size(76, 41);
            this.btnTim.TabIndex = 65;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(280, 373);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.MaxLength = 50;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(308, 39);
            this.txtTim.TabIndex = 64;
            this.txtTim.Text = "-- Nhập tên hoặc mã NV --";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 26;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1125, 320);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(141, 46);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSua.IconColor = System.Drawing.Color.Black;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 26;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(976, 320);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(141, 46);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Black;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 26;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(827, 320);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(141, 46);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(949, 180);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.MaxLength = 15;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(308, 39);
            this.txtSDT.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbNu);
            this.panel2.Controls.Add(this.rdbNam);
            this.panel2.Location = new System.Drawing.Point(957, 215);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 50);
            this.panel2.TabIndex = 58;
            // 
            // dtgvdsNhanvien
            // 
            this.dtgvdsNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvdsNhanvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvdsNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdsNhanvien.Location = new System.Drawing.Point(280, 421);
            this.dtgvdsNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvdsNhanvien.Name = "dtgvdsNhanvien";
            this.dtgvdsNhanvien.RowHeadersWidth = 51;
            this.dtgvdsNhanvien.Size = new System.Drawing.Size(1197, 351);
            this.dtgvdsNhanvien.TabIndex = 57;
            this.dtgvdsNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdsNhanvien_CellClick);
            // 
            // btnAnh
            // 
            this.btnAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnAnh.IconColor = System.Drawing.Color.Black;
            this.btnAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnh.IconSize = 26;
            this.btnAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnh.Location = new System.Drawing.Point(1284, 320);
            this.btnAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAnh.Size = new System.Drawing.Size(193, 46);
            this.btnAnh.TabIndex = 5;
            this.btnAnh.Text = "Tải ảnh lên";
            this.btnAnh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.BackColor = System.Drawing.Color.White;
            this.pbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnh.Location = new System.Drawing.Point(1284, 132);
            this.pbAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(193, 180);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh.TabIndex = 55;
            this.pbAnh.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 37);
            this.label6.TabIndex = 53;
            this.label6.Text = "Vai trò:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(820, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 37);
            this.label4.TabIndex = 48;
            this.label4.Text = "Số ĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 37);
            this.label3.TabIndex = 47;
            this.label3.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(465, 132);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 39);
            this.txtEmail.TabIndex = 1;
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(949, 132);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoten.MaxLength = 50;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(308, 39);
            this.txtHoten.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(465, 180);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachi.MaxLength = 50;
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(308, 78);
            this.txtDiachi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "Email: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1712, 6);
            this.panel3.TabIndex = 87;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(725, 325);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.OffBackColor = System.Drawing.Color.Gray;
            this.btnThem.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnThem.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.Size = new System.Drawing.Size(80, 37);
            this.btnThem.TabIndex = 59;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.CheckedChanged += new System.EventHandler(this.btnThem_CheckedChanged);
            this.btnThem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThem_MouseClick);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbNu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(188, 11);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNu.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbNu.Size = new System.Drawing.Size(73, 32);
            this.rdbNu.TabIndex = 51;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(9, 11);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNam.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbNam.Size = new System.Drawing.Size(88, 32);
            this.rdbNam.TabIndex = 49;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNhanvien
            // 
            this.rdbNhanvien.AutoSize = true;
            this.rdbNhanvien.Checked = true;
            this.rdbNhanvien.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbNhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNhanvien.Location = new System.Drawing.Point(629, 266);
            this.rdbNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNhanvien.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbNhanvien.Name = "rdbNhanvien";
            this.rdbNhanvien.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbNhanvien.Size = new System.Drawing.Size(134, 32);
            this.rdbNhanvien.TabIndex = 54;
            this.rdbNhanvien.TabStop = true;
            this.rdbNhanvien.Text = "Nhân viên";
            this.rdbNhanvien.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbNhanvien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanly
            // 
            this.rdbQuanly.AutoSize = true;
            this.rdbQuanly.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbQuanly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuanly.Location = new System.Drawing.Point(465, 266);
            this.rdbQuanly.Margin = new System.Windows.Forms.Padding(4);
            this.rdbQuanly.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbQuanly.Name = "rdbQuanly";
            this.rdbQuanly.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbQuanly.Size = new System.Drawing.Size(113, 32);
            this.rdbQuanly.TabIndex = 52;
            this.rdbQuanly.Text = "Quản lý";
            this.rdbQuanly.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbQuanly.UseVisualStyleBackColor = true;
            // 
            // FNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 943);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FNhanvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdsNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.DataGridView dtgvdsNhanvien;
        private FontAwesome.Sharp.IconButton btnAnh;
        private System.Windows.Forms.PictureBox pbAnh;
        private DemoCTControls.NARadioButton rdbNhanvien;
        private System.Windows.Forms.Label label6;
        private DemoCTControls.NARadioButton rdbQuanly;
        private DemoCTControls.NARadioButton rdbNu;
        private System.Windows.Forms.Label label5;
        private DemoCTControls.NARadioButton rdbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DemoCTControls.NAToggleButton btnThem;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private FontAwesome.Sharp.IconButton btnTailai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
    }
}