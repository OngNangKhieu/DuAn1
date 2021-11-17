
namespace GUI_QLSQA
{
    partial class FMucluc
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.txtTenloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTailai = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new DemoCTControls.NAToggleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 37);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tên loại:";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaloai.Location = new System.Drawing.Point(327, 79);
            this.txtMaloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaloai.MaxLength = 50;
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(308, 39);
            this.txtMaloai.TabIndex = 44;
            // 
            // txtTenloai
            // 
            this.txtTenloai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenloai.Location = new System.Drawing.Point(327, 127);
            this.txtTenloai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenloai.MaxLength = 50;
            this.txtTenloai.Name = "txtTenloai";
            this.txtTenloai.Size = new System.Drawing.Size(308, 39);
            this.txtTenloai.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã loại:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnTailai);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaloai);
            this.panel1.Controls.Add(this.txtTenloai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 943);
            this.panel1.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(768, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(479, 610);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.btnTailai.Location = new System.Drawing.Point(1171, 30);
            this.btnTailai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTailai.Size = new System.Drawing.Size(76, 41);
            this.btnTailai.TabIndex = 67;
            this.btnTailai.UseVisualStyleBackColor = true;
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
            this.btnTim.Location = new System.Drawing.Point(1085, 30);
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
            this.txtTim.Location = new System.Drawing.Point(768, 30);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.MaxLength = 50;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(308, 39);
            this.txtTim.TabIndex = 64;
            this.txtTim.Text = "-- Nhập tên loại --";
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
            this.btnXoa.Location = new System.Drawing.Point(593, 197);
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
            this.btnSua.Location = new System.Drawing.Point(444, 197);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(141, 46);
            this.btnSua.TabIndex = 62;
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
            this.btnLuu.Location = new System.Drawing.Point(295, 197);
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
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(203, 204);
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
            this.btnThem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThem_MouseClick);
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
            // FMucluc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1712, 943);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FMucluc";
            this.Text = "FMucluc";
            this.Load += new System.EventHandler(this.FMucluc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.TextBox txtTenloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnTailai;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLuu;
        private DemoCTControls.NAToggleButton btnThem;
        private System.Windows.Forms.Panel panel2;
    }
}