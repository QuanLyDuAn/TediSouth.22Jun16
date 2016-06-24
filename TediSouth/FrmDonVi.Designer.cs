namespace TediSouth
{
    partial class FrmDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonVi));
            this.tbGioiThieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaLV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbTenCongTy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNgDD = new System.Windows.Forms.TextBox();
            this.tbMaDV = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGioiThieu
            // 
            this.tbGioiThieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGioiThieu.Location = new System.Drawing.Point(680, 182);
            this.tbGioiThieu.Margin = new System.Windows.Forms.Padding(4);
            this.tbGioiThieu.Multiline = true;
            this.tbGioiThieu.Name = "tbGioiThieu";
            this.tbGioiThieu.Size = new System.Drawing.Size(431, 24);
            this.tbGioiThieu.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Giới Thiệu:";
            // 
            // tbMaLV
            // 
            this.tbMaLV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLV.Location = new System.Drawing.Point(255, 182);
            this.tbMaLV.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaLV.Name = "tbMaLV";
            this.tbMaLV.Size = new System.Drawing.Size(244, 26);
            this.tbMaLV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Lĩnh vực chính:";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(42, 55);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(327, 26);
            this.tbTimKiem.TabIndex = 11;
            this.tbTimKiem.Text = "Nhập mã hoặc tên đơn vị để tìm kiếm...";
            this.tbTimKiem.Click += new System.EventHandler(this.tbTimKiem_Click);
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // dgvDV
            // 
            this.dgvDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(17, 321);
            this.dgvDV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV.Size = new System.Drawing.Size(1491, 255);
            this.dgvDV.TabIndex = 58;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_cell);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(1120, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(388, 126);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(680, 85);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(431, 26);
            this.tbDiaChi.TabIndex = 4;
            // 
            // tbWeb
            // 
            this.tbWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeb.Location = new System.Drawing.Point(680, 129);
            this.tbWeb.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(431, 26);
            this.tbWeb.TabIndex = 6;
            // 
            // tbSDT
            // 
            this.tbSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(255, 137);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(244, 26);
            this.tbSDT.TabIndex = 5;
            // 
            // tbTenCongTy
            // 
            this.tbTenCongTy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenCongTy.Location = new System.Drawing.Point(680, 39);
            this.tbTenCongTy.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenCongTy.Multiline = true;
            this.tbTenCongTy.Name = "tbTenCongTy";
            this.tbTenCongTy.Size = new System.Drawing.Size(431, 24);
            this.tbTenCongTy.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Điện Thoại:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "WebSite:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Người Đại Diện:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã Số Đơn Vị:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên Đơn Vị:";
            // 
            // tbNgDD
            // 
            this.tbNgDD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNgDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgDD.Location = new System.Drawing.Point(255, 89);
            this.tbNgDD.Margin = new System.Windows.Forms.Padding(4);
            this.tbNgDD.Name = "tbNgDD";
            this.tbNgDD.Size = new System.Drawing.Size(244, 26);
            this.tbNgDD.TabIndex = 3;
            // 
            // tbMaDV
            // 
            this.tbMaDV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDV.Location = new System.Drawing.Point(255, 43);
            this.tbMaDV.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaDV.Name = "tbMaDV";
            this.tbMaDV.Size = new System.Drawing.Size(244, 26);
            this.tbMaDV.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1141, 250);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(156, 39);
            this.simpleButton2.TabIndex = 65;
            this.simpleButton2.Text = "Phòng Ban";
            this.simpleButton2.Click += new System.EventHandler(this.click_PhongBan);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(919, 250);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 39);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.click_Reset);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(692, 250);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 39);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.click_Delete);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(463, 250);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 39);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.click_Update);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.AutoWidthInLayoutControl = true;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(235, 250);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 39);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.click_Add);
            // 
            // FrmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 591);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.tbGioiThieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbMaLV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbWeb);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbTenCongTy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNgDD);
            this.Controls.Add(this.tbMaDV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDonVi";
            this.Text = "ĐƠN VỊ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox tbGioiThieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaLV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView dgvDV;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbTenCongTy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNgDD;
        private System.Windows.Forms.TextBox tbMaDV;
    }
}