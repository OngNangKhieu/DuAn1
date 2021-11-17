
namespace GUI_QLSQA
{
    partial class FSanpham
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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.dtgvdsSanpham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnChitiet = new DemoCTControls.NAToggleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAnhsau = new FontAwesome.Sharp.IconButton();
            this.pbAnh2 = new System.Windows.Forms.PictureBox();
            this.cbMausac = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbSizeXXL = new DemoCTControls.NARadioButton();
            this.rdbSizeXL = new DemoCTControls.NARadioButton();
            this.rdbSizeL = new DemoCTControls.NARadioButton();
            this.rdbSizeM = new DemoCTControls.NARadioButton();
            this.rdbSizeS = new DemoCTControls.NARadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbNamvaNu = new DemoCTControls.NARadioButton();
            this.rdbNu = new DemoCTControls.NARadioButton();
            this.rdbNam = new DemoCTControls.NARadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTenloai = new System.Windows.Forms.ComboBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTailai = new FontAwesome.Sharp.IconButton();
            this.btnDanhsach = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new DemoCTControls.NAToggleButton();
            this.btnAnhtrc = new FontAwesome.Sharp.IconButton();
            this.pbAnh1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdsSanpham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(213, 367);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(316, 39);
            this.txtTim.TabIndex = 64;
            this.txtTim.Text = "-- Nhập tên hoặc mã SP --";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(767, 153);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaBan.MaxLength = 50;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(308, 39);
            this.txtGiaBan.TabIndex = 4;
            // 
            // dtgvdsSanpham
            // 
            this.dtgvdsSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvdsSanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvdsSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdsSanpham.Location = new System.Drawing.Point(163, 429);
            this.dtgvdsSanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvdsSanpham.Name = "dtgvdsSanpham";
            this.dtgvdsSanpham.RowHeadersWidth = 51;
            this.dtgvdsSanpham.Size = new System.Drawing.Size(1374, 475);
            this.dtgvdsSanpham.TabIndex = 57;
            this.dtgvdsSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdsSanpham_CellClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnChitiet);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAnhsau);
            this.panel1.Controls.Add(this.pbAnh2);
            this.panel1.Controls.Add(this.cbMausac);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbTenloai);
            this.panel1.Controls.Add(this.txtSl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnTailai);
            this.panel1.Controls.Add(this.btnDanhsach);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(this.dtgvdsSanpham);
            this.panel1.Controls.Add(this.btnAnhtrc);
            this.panel1.Controls.Add(this.pbAnh1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMasp);
            this.panel1.Controls.Add(this.txtTensp);
            this.panel1.Controls.Add(this.txtGiaNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 943);
            this.panel1.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(543, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(465, 60);
            this.label13.TabIndex = 88;
            this.label13.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(169, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 28);
            this.label12.TabIndex = 87;
            this.label12.Text = "Chế độ xem chi tiết";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.AutoSize = true;
            this.btnChitiet.Location = new System.Drawing.Point(412, 322);
            this.btnChitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChitiet.MinimumSize = new System.Drawing.Size(80, 37);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.OffBackColor = System.Drawing.Color.Gray;
            this.btnChitiet.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnChitiet.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChitiet.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnChitiet.Size = new System.Drawing.Size(80, 37);
            this.btnChitiet.TabIndex = 86;
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.CheckedChanged += new System.EventHandler(this.btnChitiet_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 904);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1712, 39);
            this.panel5.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(647, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 28);
            this.label11.TabIndex = 84;
            this.label11.Text = "Màu sắc:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1387, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 28);
            this.label10.TabIndex = 83;
            this.label10.Text = "Mặt sau áo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1173, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 28);
            this.label9.TabIndex = 82;
            this.label9.Text = "Mặt trước áo";
            // 
            // btnAnhsau
            // 
            this.btnAnhsau.Enabled = false;
            this.btnAnhsau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnhsau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnhsau.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnAnhsau.IconColor = System.Drawing.Color.Black;
            this.btnAnhsau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnhsau.IconSize = 26;
            this.btnAnhsau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnhsau.Location = new System.Drawing.Point(1344, 292);
            this.btnAnhsau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnhsau.Name = "btnAnhsau";
            this.btnAnhsau.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAnhsau.Size = new System.Drawing.Size(193, 46);
            this.btnAnhsau.TabIndex = 9;
            this.btnAnhsau.Text = "Tải ảnh lên";
            this.btnAnhsau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnhsau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnhsau.UseVisualStyleBackColor = true;
            this.btnAnhsau.Click += new System.EventHandler(this.btnAnhsau_Click);
            // 
            // pbAnh2
            // 
            this.pbAnh2.BackColor = System.Drawing.Color.DimGray;
            this.pbAnh2.Location = new System.Drawing.Point(1344, 103);
            this.pbAnh2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAnh2.Name = "pbAnh2";
            this.pbAnh2.Size = new System.Drawing.Size(193, 181);
            this.pbAnh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh2.TabIndex = 80;
            this.pbAnh2.TabStop = false;
            // 
            // cbMausac
            // 
            this.cbMausac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMausac.Enabled = false;
            this.cbMausac.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMausac.FormattingEnabled = true;
            this.cbMausac.Location = new System.Drawing.Point(767, 247);
            this.cbMausac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMausac.Name = "cbMausac";
            this.cbMausac.Size = new System.Drawing.Size(184, 40);
            this.cbMausac.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(637, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 28);
            this.label7.TabIndex = 78;
            this.label7.Text = "Kích cỡ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbSizeXXL);
            this.panel4.Controls.Add(this.rdbSizeXL);
            this.panel4.Controls.Add(this.rdbSizeL);
            this.panel4.Controls.Add(this.rdbSizeM);
            this.panel4.Controls.Add(this.rdbSizeS);
            this.panel4.Location = new System.Drawing.Point(744, 292);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 50);
            this.panel4.TabIndex = 77;
            // 
            // rdbSizeXXL
            // 
            this.rdbSizeXXL.AutoSize = true;
            this.rdbSizeXXL.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbSizeXXL.Enabled = false;
            this.rdbSizeXXL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeXXL.Location = new System.Drawing.Point(297, 11);
            this.rdbSizeXXL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeXXL.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbSizeXXL.Name = "rdbSizeXXL";
            this.rdbSizeXXL.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbSizeXXL.Size = new System.Drawing.Size(79, 32);
            this.rdbSizeXXL.TabIndex = 54;
            this.rdbSizeXXL.Text = "XXL";
            this.rdbSizeXXL.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbSizeXXL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeXL
            // 
            this.rdbSizeXL.AutoSize = true;
            this.rdbSizeXL.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbSizeXL.Enabled = false;
            this.rdbSizeXL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeXL.Location = new System.Drawing.Point(216, 11);
            this.rdbSizeXL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeXL.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbSizeXL.Name = "rdbSizeXL";
            this.rdbSizeXL.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbSizeXL.Size = new System.Drawing.Size(67, 32);
            this.rdbSizeXL.TabIndex = 53;
            this.rdbSizeXL.Text = "XL";
            this.rdbSizeXL.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbSizeXL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeL
            // 
            this.rdbSizeL.AutoSize = true;
            this.rdbSizeL.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbSizeL.Enabled = false;
            this.rdbSizeL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeL.Location = new System.Drawing.Point(156, 11);
            this.rdbSizeL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeL.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbSizeL.Name = "rdbSizeL";
            this.rdbSizeL.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbSizeL.Size = new System.Drawing.Size(55, 32);
            this.rdbSizeL.TabIndex = 52;
            this.rdbSizeL.Text = "L";
            this.rdbSizeL.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbSizeL.UseVisualStyleBackColor = true;
            // 
            // rdbSizeM
            // 
            this.rdbSizeM.AutoSize = true;
            this.rdbSizeM.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbSizeM.Enabled = false;
            this.rdbSizeM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeM.Location = new System.Drawing.Point(84, 11);
            this.rdbSizeM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeM.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbSizeM.Name = "rdbSizeM";
            this.rdbSizeM.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbSizeM.Size = new System.Drawing.Size(64, 32);
            this.rdbSizeM.TabIndex = 51;
            this.rdbSizeM.Text = "M";
            this.rdbSizeM.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbSizeM.UseVisualStyleBackColor = true;
            // 
            // rdbSizeS
            // 
            this.rdbSizeS.AutoSize = true;
            this.rdbSizeS.Checked = true;
            this.rdbSizeS.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbSizeS.Enabled = false;
            this.rdbSizeS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSizeS.Location = new System.Drawing.Point(20, 11);
            this.rdbSizeS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSizeS.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbSizeS.Name = "rdbSizeS";
            this.rdbSizeS.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbSizeS.Size = new System.Drawing.Size(57, 32);
            this.rdbSizeS.TabIndex = 49;
            this.rdbSizeS.TabStop = true;
            this.rdbSizeS.Text = "S";
            this.rdbSizeS.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbSizeS.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbNamvaNu);
            this.panel3.Controls.Add(this.rdbNu);
            this.panel3.Controls.Add(this.rdbNam);
            this.panel3.Location = new System.Drawing.Point(295, 248);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 50);
            this.panel3.TabIndex = 76;
            // 
            // rdbNamvaNu
            // 
            this.rdbNamvaNu.AutoSize = true;
            this.rdbNamvaNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbNamvaNu.Enabled = false;
            this.rdbNamvaNu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNamvaNu.Location = new System.Drawing.Point(177, 10);
            this.rdbNamvaNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNamvaNu.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbNamvaNu.Name = "rdbNamvaNu";
            this.rdbNamvaNu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbNamvaNu.Size = new System.Drawing.Size(108, 27);
            this.rdbNamvaNu.TabIndex = 52;
            this.rdbNamvaNu.Text = "Nam,Nữ";
            this.rdbNamvaNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbNamvaNu.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Checked = true;
            this.rdbNu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbNu.Enabled = false;
            this.rdbNu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(4, 9);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNu.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbNu.Size = new System.Drawing.Size(67, 27);
            this.rdbNu.TabIndex = 51;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdbNam.Enabled = false;
            this.rdbNam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(88, 9);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNam.MinimumSize = new System.Drawing.Size(0, 26);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.rdbNam.Size = new System.Drawing.Size(81, 27);
            this.rdbNam.TabIndex = 49;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 72;
            this.label8.Text = "Dành cho:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 71;
            this.label6.Text = "Tên loại:";
            // 
            // cbTenloai
            // 
            this.cbTenloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenloai.Enabled = false;
            this.cbTenloai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenloai.FormattingEnabled = true;
            this.cbTenloai.Location = new System.Drawing.Point(767, 201);
            this.cbTenloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenloai.Name = "cbTenloai";
            this.cbTenloai.Size = new System.Drawing.Size(308, 40);
            this.cbTenloai.TabIndex = 6;
            this.cbTenloai.SelectedIndexChanged += new System.EventHandler(this.cbTenloai_SelectedIndexChanged);
            // 
            // txtSl
            // 
            this.txtSl.Enabled = false;
            this.txtSl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSl.Location = new System.Drawing.Point(295, 201);
            this.txtSl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSl.MaxLength = 50;
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(308, 39);
            this.txtSl.TabIndex = 5;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 69;
            this.label5.Text = "Số lượng:";
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
            this.btnTailai.Location = new System.Drawing.Point(623, 367);
            this.btnTailai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTailai.Size = new System.Drawing.Size(76, 41);
            this.btnTailai.TabIndex = 67;
            this.btnTailai.UseVisualStyleBackColor = true;
            this.btnTailai.Click += new System.EventHandler(this.btnTailai_Click);
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhsach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsach.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnDanhsach.IconColor = System.Drawing.Color.Black;
            this.btnDanhsach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhsach.IconSize = 26;
            this.btnDanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.Location = new System.Drawing.Point(1292, 364);
            this.btnDanhsach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnDanhsach.Size = new System.Drawing.Size(245, 43);
            this.btnDanhsach.TabIndex = 66;
            this.btnDanhsach.Text = "Danh sách";
            this.btnDanhsach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhsach.UseVisualStyleBackColor = true;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
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
            this.btnTim.Location = new System.Drawing.Point(539, 367);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTim.Size = new System.Drawing.Size(76, 41);
            this.btnTim.TabIndex = 65;
            this.btnTim.UseVisualStyleBackColor = true;
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
            this.btnXoa.Location = new System.Drawing.Point(1125, 362);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(141, 46);
            this.btnXoa.TabIndex = 63;
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
            this.btnSua.Location = new System.Drawing.Point(976, 362);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(141, 46);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
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
            this.btnLuu.Location = new System.Drawing.Point(827, 362);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(141, 46);
            this.btnLuu.TabIndex = 61;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoCheck = false;
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(725, 367);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnAnhtrc
            // 
            this.btnAnhtrc.Enabled = false;
            this.btnAnhtrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnhtrc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnhtrc.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnAnhtrc.IconColor = System.Drawing.Color.Black;
            this.btnAnhtrc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnhtrc.IconSize = 26;
            this.btnAnhtrc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnhtrc.Location = new System.Drawing.Point(1143, 292);
            this.btnAnhtrc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnhtrc.Name = "btnAnhtrc";
            this.btnAnhtrc.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAnhtrc.Size = new System.Drawing.Size(193, 46);
            this.btnAnhtrc.TabIndex = 8;
            this.btnAnhtrc.Text = "Tải ảnh lên";
            this.btnAnhtrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnhtrc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnhtrc.UseVisualStyleBackColor = true;
            this.btnAnhtrc.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // pbAnh1
            // 
            this.pbAnh1.BackColor = System.Drawing.Color.DimGray;
            this.pbAnh1.Location = new System.Drawing.Point(1143, 103);
            this.pbAnh1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAnh1.Name = "pbAnh1";
            this.pbAnh1.Size = new System.Drawing.Size(193, 181);
            this.pbAnh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnh1.TabIndex = 55;
            this.pbAnh1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(646, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tên sp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Giá nhập:";
            // 
            // txtMasp
            // 
            this.txtMasp.Enabled = false;
            this.txtMasp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(295, 105);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMasp.MaxLength = 50;
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(308, 39);
            this.txtMasp.TabIndex = 1;
            // 
            // txtTensp
            // 
            this.txtTensp.Enabled = false;
            this.txtTensp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Location = new System.Drawing.Point(767, 105);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTensp.MaxLength = 50;
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(308, 39);
            this.txtTensp.TabIndex = 2;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Enabled = false;
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(295, 153);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaNhap.MaxLength = 50;
            this.txtGiaNhap.Multiline = true;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(308, 40);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã sp:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1712, 6);
            this.panel2.TabIndex = 87;
            // 
            // FSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1712, 943);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FSanpham";
            this.Text = "FSanpham";
            this.Load += new System.EventHandler(this.FSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdsSanpham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTim;
        private FontAwesome.Sharp.IconButton btnTailai;
        private FontAwesome.Sharp.IconButton btnDanhsach;
        private FontAwesome.Sharp.IconButton btnTim;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLuu;
        private DemoCTControls.NAToggleButton btnThem;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.DataGridView dtgvdsSanpham;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAnhtrc;
        private System.Windows.Forms.PictureBox pbAnh1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTenloai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DemoCTControls.NARadioButton rdbNamvaNu;
        private DemoCTControls.NARadioButton rdbNu;
        private DemoCTControls.NARadioButton rdbNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private DemoCTControls.NARadioButton rdbSizeXL;
        private DemoCTControls.NARadioButton rdbSizeL;
        private DemoCTControls.NARadioButton rdbSizeM;
        private DemoCTControls.NARadioButton rdbSizeS;
        private System.Windows.Forms.ComboBox cbMausac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnAnhsau;
        private System.Windows.Forms.PictureBox pbAnh2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private DemoCTControls.NAToggleButton btnChitiet;
        private DemoCTControls.NARadioButton rdbSizeXXL;
        private System.Windows.Forms.Label label13;
    }
}