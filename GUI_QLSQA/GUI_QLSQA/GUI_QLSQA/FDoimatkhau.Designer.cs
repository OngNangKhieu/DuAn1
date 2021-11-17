
namespace GUI_QLSQA
{
    partial class FDoimatkhau
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
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.btnExits = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDmk = new FontAwesome.Sharp.IconButton();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLai.Location = new System.Drawing.Point(89, 420);
            this.txtNhapLai.MaxLength = 50;
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '*';
            this.txtNhapLai.Size = new System.Drawing.Size(319, 33);
            this.txtNhapLai.TabIndex = 7;
            this.txtNhapLai.Text = "1234";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nhập lại:";
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMkMoi.Location = new System.Drawing.Point(89, 330);
            this.txtMkMoi.MaxLength = 50;
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.PasswordChar = '*';
            this.txtMkMoi.Size = new System.Drawing.Size(319, 33);
            this.txtMkMoi.TabIndex = 6;
            this.txtMkMoi.Text = "1234";
            // 
            // btnExits
            // 
            this.btnExits.BackColor = System.Drawing.Color.Transparent;
            this.btnExits.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExits.FlatAppearance.BorderSize = 0;
            this.btnExits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExits.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExits.IconColor = System.Drawing.Color.White;
            this.btnExits.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExits.IconSize = 40;
            this.btnExits.Location = new System.Drawing.Point(160, 0);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(40, 42);
            this.btnExits.TabIndex = 14;
            this.btnExits.UseVisualStyleBackColor = false;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 42);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnExits);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(298, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNhapLai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMkMoi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnDmk);
            this.panel1.Controls.Add(this.txtMKCu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 687);
            this.panel1.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(89, 165);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 33);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "long@gmail.com";
            // 
            // btnDmk
            // 
            this.btnDmk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDmk.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDmk.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnDmk.IconColor = System.Drawing.Color.Black;
            this.btnDmk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDmk.IconSize = 37;
            this.btnDmk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDmk.Location = new System.Drawing.Point(91, 488);
            this.btnDmk.Name = "btnDmk";
            this.btnDmk.Size = new System.Drawing.Size(318, 39);
            this.btnDmk.TabIndex = 8;
            this.btnDmk.Text = "Đổi mật khẩu";
            this.btnDmk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDmk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDmk.UseVisualStyleBackColor = true;
            this.btnDmk.Click += new System.EventHandler(this.btnDmk_Click);
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(90, 246);
            this.txtMKCu.MaxLength = 50;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(319, 33);
            this.txtMKCu.TabIndex = 5;
            this.txtMKCu.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 687);
            this.panel2.TabIndex = 7;
            // 
            // FDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 687);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDoimatkhau";
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMkMoi;
        private FontAwesome.Sharp.IconButton btnExits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnDmk;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}