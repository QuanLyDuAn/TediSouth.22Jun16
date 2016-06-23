namespace TediSouth
{
    partial class FrmDangNhap
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
            this.lbLoiDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.lbLoiMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.lbLoiTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lbLoiDangNhap
            // 
            this.lbLoiDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoiDangNhap.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLoiDangNhap.Location = new System.Drawing.Point(54, 239);
            this.lbLoiDangNhap.Name = "lbLoiDangNhap";
            this.lbLoiDangNhap.Size = new System.Drawing.Size(0, 13);
            this.lbLoiDangNhap.TabIndex = 35;
            // 
            // lbLoiMatKhau
            // 
            this.lbLoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoiMatKhau.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLoiMatKhau.Location = new System.Drawing.Point(134, 219);
            this.lbLoiMatKhau.Name = "lbLoiMatKhau";
            this.lbLoiMatKhau.Size = new System.Drawing.Size(0, 13);
            this.lbLoiMatKhau.TabIndex = 34;
            // 
            // lbLoiTaiKhoan
            // 
            this.lbLoiTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoiTaiKhoan.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLoiTaiKhoan.Location = new System.Drawing.Point(134, 141);
            this.lbLoiTaiKhoan.Name = "lbLoiTaiKhoan";
            this.lbLoiTaiKhoan.Size = new System.Drawing.Size(0, 13);
            this.lbLoiTaiKhoan.TabIndex = 33;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.Location = new System.Drawing.Point(133, 178);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(250, 26);
            this.tbMatKhau.TabIndex = 2;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaiKhoan.Location = new System.Drawing.Point(133, 98);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(250, 26);
            this.tbTaiKhoan.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelControl2.Location = new System.Drawing.Point(54, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 18);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Mật Khẩu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.labelControl1.Location = new System.Drawing.Point(50, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 18);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Tài Khoản:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(274, 344);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.Click_Thoat);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(52, 344);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(125, 40);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.click_DangNhap);
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TediSouth.Properties.Resources._13116hinh_anh_back_ground_mau_xanh_nhe_nhang_cho_wedsite;
            this.ClientSize = new System.Drawing.Size(449, 483);
            this.Controls.Add(this.lbLoiDangNhap);
            this.Controls.Add(this.lbLoiMatKhau);
            this.Controls.Add(this.lbLoiTaiKhoan);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "FrmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbLoiDangNhap;
        private DevExpress.XtraEditors.LabelControl lbLoiMatKhau;
        private DevExpress.XtraEditors.LabelControl lbLoiTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
    }
}