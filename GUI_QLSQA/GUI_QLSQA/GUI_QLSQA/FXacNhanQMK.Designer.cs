
namespace GUI_QLSQA
{
    partial class FXacNhanQMK
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
            this.txtXacnhan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconNo = new FontAwesome.Sharp.IconPictureBox();
            this.iconYes = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconYes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtXacnhan
            // 
            this.txtXacnhan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacnhan.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtXacnhan.Location = new System.Drawing.Point(56, 34);
            this.txtXacnhan.MaxLength = 20;
            this.txtXacnhan.Name = "txtXacnhan";
            this.txtXacnhan.Size = new System.Drawing.Size(319, 33);
            this.txtXacnhan.TabIndex = 10;
            this.txtXacnhan.Text = "--Nhập mã xác thực--";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconNo);
            this.panel1.Controls.Add(this.txtXacnhan);
            this.panel1.Controls.Add(this.iconYes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 108);
            this.panel1.TabIndex = 11;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(382, 34);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(92, 33);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Xác nhận";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconNo
            // 
            this.iconNo.BackColor = System.Drawing.Color.White;
            this.iconNo.ForeColor = System.Drawing.Color.Red;
            this.iconNo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconNo.IconColor = System.Drawing.Color.Red;
            this.iconNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNo.IconSize = 33;
            this.iconNo.Location = new System.Drawing.Point(480, 34);
            this.iconNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.iconNo.Name = "iconNo";
            this.iconNo.Rotation = 45D;
            this.iconNo.Size = new System.Drawing.Size(38, 33);
            this.iconNo.TabIndex = 11;
            this.iconNo.TabStop = false;
            this.iconNo.Visible = false;
            // 
            // iconYes
            // 
            this.iconYes.BackColor = System.Drawing.Color.White;
            this.iconYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconYes.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconYes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconYes.IconSize = 33;
            this.iconYes.Location = new System.Drawing.Point(480, 34);
            this.iconYes.Name = "iconYes";
            this.iconYes.Size = new System.Drawing.Size(38, 33);
            this.iconYes.TabIndex = 13;
            this.iconYes.TabStop = false;
            this.iconYes.Visible = false;
            // 
            // FXacNhanQMK
            // 
            this.AcceptButton = this.iconButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 108);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FXacNhanQMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FXacNhanQMK";
            this.Load += new System.EventHandler(this.FXacNhanQMK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconYes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtXacnhan;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconNo;
        private FontAwesome.Sharp.IconPictureBox iconYes;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}