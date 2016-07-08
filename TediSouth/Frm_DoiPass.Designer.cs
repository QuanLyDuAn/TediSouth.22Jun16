namespace TediSouth
{
    partial class Frm_DoiPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DoiPass));
            this.tbMatKhauCu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhapLai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.lbLoiMatKhauCu = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbMatKhauCu
            // 
            this.tbMatKhauCu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMatKhauCu.Location = new System.Drawing.Point(215, 36);
            this.tbMatKhauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMatKhauCu.Name = "tbMatKhauCu";
            this.tbMatKhauCu.Size = new System.Drawing.Size(221, 22);
            this.tbMatKhauCu.TabIndex = 5;
            this.tbMatKhauCu.TextChanged += new System.EventHandler(this.tbMatKhauCu_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mật Khẩu Cũ :";
            // 
            // tbMatKhauMoi
            // 
            this.tbMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMatKhauMoi.Location = new System.Drawing.Point(215, 111);
            this.tbMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMatKhauMoi.Name = "tbMatKhauMoi";
            this.tbMatKhauMoi.Size = new System.Drawing.Size(221, 22);
            this.tbMatKhauMoi.TabIndex = 7;
            this.tbMatKhauMoi.TextChanged += new System.EventHandler(this.tbMatKhauMoi_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mật Khẩu Mới :";
            // 
            // tbNhapLai
            // 
            this.tbNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNhapLai.Location = new System.Drawing.Point(215, 178);
            this.tbNhapLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNhapLai.Name = "tbNhapLai";
            this.tbNhapLai.Size = new System.Drawing.Size(221, 22);
            this.tbNhapLai.TabIndex = 9;
            this.tbNhapLai.TextChanged += new System.EventHandler(this.tbNhapLai_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập Lại:";
            // 
            // btncapnhat
            // 
            this.btncapnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncapnhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Appearance.Options.UseFont = true;
            this.btncapnhat.AutoWidthInLayoutControl = true;
            this.btncapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncapnhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btncapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btncapnhat.Image")));
            this.btncapnhat.Location = new System.Drawing.Point(215, 252);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(184, 42);
            this.btncapnhat.TabIndex = 10;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // lbLoiMatKhauCu
            // 
            this.lbLoiMatKhauCu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoiMatKhauCu.AutoSize = true;
            this.lbLoiMatKhauCu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoiMatKhauCu.ForeColor = System.Drawing.Color.Red;
            this.lbLoiMatKhauCu.Location = new System.Drawing.Point(63, 71);
            this.lbLoiMatKhauCu.Name = "lbLoiMatKhauCu";
            this.lbLoiMatKhauCu.Size = new System.Drawing.Size(0, 23);
            this.lbLoiMatKhauCu.TabIndex = 11;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhauMoi.ForeColor = System.Drawing.Color.Red;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(63, 135);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(0, 23);
            this.lbMatKhauMoi.TabIndex = 12;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(444, 38);
            this.cb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(98, 21);
            this.cb1.TabIndex = 13;
            this.cb1.Text = "Show pass";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // Frm_DoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 322);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.lbLoiMatKhauCu);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.tbNhapLai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMatKhauMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatKhauCu);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_DoiPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.Frm_DoiPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMatKhauCu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMatKhauMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhapLai;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btncapnhat;
        private System.Windows.Forms.Label lbLoiMatKhauCu;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.CheckBox cb1;
    }
}