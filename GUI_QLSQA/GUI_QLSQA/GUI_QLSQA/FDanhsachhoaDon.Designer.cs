
namespace GUI_QLSQA
{
    partial class FDanhsachhoaDon
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
            this.btnTailai = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaykt = new System.Windows.Forms.DateTimePicker();
            this.dtpngaybd = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(405, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 47);
            this.label3.TabIndex = 85;
            this.label3.Text = "HÓA ĐƠN MUA";
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
            this.btnTailai.Location = new System.Drawing.Point(889, 90);
            this.btnTailai.Name = "btnTailai";
            this.btnTailai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTailai.Size = new System.Drawing.Size(61, 34);
            this.btnTailai.TabIndex = 84;
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
            this.btnTim.Location = new System.Drawing.Point(807, 90);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTim.Size = new System.Drawing.Size(66, 34);
            this.btnTim.TabIndex = 83;
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 82;
            this.label1.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 81;
            this.label2.Text = "Từ ngày:";
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(574, 91);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgaykt.Size = new System.Drawing.Size(200, 33);
            this.dtpNgaykt.TabIndex = 80;
            // 
            // dtpngaybd
            // 
            this.dtpngaybd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaybd.Location = new System.Drawing.Point(246, 91);
            this.dtpngaybd.Name = "dtpngaybd";
            this.dtpngaybd.Size = new System.Drawing.Size(200, 33);
            this.dtpngaybd.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 404);
            this.dataGridView1.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 5);
            this.panel1.TabIndex = 86;
            // 
            // FDanhsachhoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTailai);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgaykt);
            this.Controls.Add(this.dtpngaybd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FDanhsachhoaDon";
            this.Text = "FDanhsachhoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnTailai;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.DateTimePicker dtpngaybd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}