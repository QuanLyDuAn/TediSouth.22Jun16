namespace TediSouth
{
    partial class FrmQuyetDinhCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuyetDinhCongViec));
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQDChucVu = new System.Windows.Forms.DataGridView();
            this.tbMaQD = new System.Windows.Forms.TextBox();
            this.GbNVCoChucVu = new System.Windows.Forms.GroupBox();
            this.GbNVChuaCoCV = new System.Windows.Forms.GroupBox();
            this.dgvNVChuaCV = new System.Windows.Forms.DataGridView();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDChucVu)).BeginInit();
            this.GbNVCoChucVu.SuspendLayout();
            this.GbNVChuaCoCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVChuaCV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaNV
            // 
            this.cbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(330, 145);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(152, 24);
            this.cbMaNV.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Nhân Viên:";
            // 
            // cbChucVu
            // 
            this.cbChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(561, 146);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(126, 24);
            this.cbChucVu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 93;
            this.label4.Text = "Chức Vụ:";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(403, 71);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(184, 20);
            this.dtNgayLap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Ngày Lập:";
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDung.Location = new System.Drawing.Point(403, 104);
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(184, 22);
            this.tbNoiDung.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "Nội Dung:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã Quyết Định:";
            // 
            // dgvQDChucVu
            // 
            this.dgvQDChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQDChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQDChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQDChucVu.Location = new System.Drawing.Point(2, 15);
            this.dgvQDChucVu.Name = "dgvQDChucVu";
            this.dgvQDChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQDChucVu.Size = new System.Drawing.Size(538, 284);
            this.dgvQDChucVu.TabIndex = 89;
            this.dgvQDChucVu.Click += new System.EventHandler(this.dgvQDChucVu_Click);
            // 
            // tbMaQD
            // 
            this.tbMaQD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaQD.Location = new System.Drawing.Point(403, 36);
            this.tbMaQD.Name = "tbMaQD";
            this.tbMaQD.Size = new System.Drawing.Size(184, 22);
            this.tbMaQD.TabIndex = 1;
            // 
            // GbNVCoChucVu
            // 
            this.GbNVCoChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbNVCoChucVu.Controls.Add(this.dgvQDChucVu);
            this.GbNVCoChucVu.Location = new System.Drawing.Point(9, 234);
            this.GbNVCoChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbNVCoChucVu.Name = "GbNVCoChucVu";
            this.GbNVCoChucVu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbNVCoChucVu.Size = new System.Drawing.Size(542, 301);
            this.GbNVCoChucVu.TabIndex = 97;
            this.GbNVCoChucVu.TabStop = false;
            this.GbNVCoChucVu.Text = "Nhân Viên Đã Có Chức Vụ";
            // 
            // GbNVChuaCoCV
            // 
            this.GbNVChuaCoCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbNVChuaCoCV.Controls.Add(this.dgvNVChuaCV);
            this.GbNVChuaCoCV.Location = new System.Drawing.Point(554, 234);
            this.GbNVChuaCoCV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbNVChuaCoCV.Name = "GbNVChuaCoCV";
            this.GbNVChuaCoCV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GbNVChuaCoCV.Size = new System.Drawing.Size(349, 301);
            this.GbNVChuaCoCV.TabIndex = 97;
            this.GbNVChuaCoCV.TabStop = false;
            this.GbNVChuaCoCV.Text = "Nhân Viên Chưa Có Chức Vụ";
            // 
            // dgvNVChuaCV
            // 
            this.dgvNVChuaCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNVChuaCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVChuaCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNVChuaCV.Location = new System.Drawing.Point(2, 15);
            this.dgvNVChuaCV.Name = "dgvNVChuaCV";
            this.dgvNVChuaCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNVChuaCV.Size = new System.Drawing.Size(345, 284);
            this.dgvNVChuaCV.TabIndex = 89;
            this.dgvNVChuaCV.Click += new System.EventHandler(this.dgvNVChuaChucVu_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(580, 188);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 40);
            this.btnReset.TabIndex = 88;
            this.btnReset.Text = "ReSet";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(465, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 40);
            this.btnXoa.TabIndex = 87;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Location = new System.Drawing.Point(238, 188);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 40);
            this.btnThem.TabIndex = 85;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(352, 188);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 40);
            this.btnLuu.TabIndex = 86;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmQuyetDinhCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 540);
            this.Controls.Add(this.GbNVChuaCoCV);
            this.Controls.Add(this.GbNVCoChucVu);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNgayLap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbMaQD);
            this.Name = "FrmQuyetDinhCongViec";
            this.Text = "QUYẾT ĐỊNH CÔNG VIỆC";
            this.Load += new System.EventHandler(this.FrmQuyetDinhCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDChucVu)).EndInit();
            this.GbNVCoChucVu.ResumeLayout(false);
            this.GbNVChuaCoCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVChuaCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNoiDung;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQDChucVu;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox tbMaQD;
        private System.Windows.Forms.GroupBox GbNVCoChucVu;
        private System.Windows.Forms.GroupBox GbNVChuaCoCV;
        private System.Windows.Forms.DataGridView dgvNVChuaCV;
    }
}