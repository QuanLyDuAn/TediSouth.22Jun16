namespace TediSouth
{
    partial class FrmPhuLuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhuLuc));
            this.cbmahopdong = new System.Windows.Forms.ComboBox();
            this.linkFile = new System.Windows.Forms.LinkLabel();
            this.dgvhopDong = new System.Windows.Forms.DataGridView();
            this.tbmaphuluc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDuyetFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhopDong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmahopdong
            // 
            this.cbmahopdong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmahopdong.FormattingEnabled = true;
            this.cbmahopdong.Location = new System.Drawing.Point(172, 98);
            this.cbmahopdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmahopdong.Name = "cbmahopdong";
            this.cbmahopdong.Size = new System.Drawing.Size(244, 24);
            this.cbmahopdong.TabIndex = 77;
            // 
            // linkFile
            // 
            this.linkFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkFile.AutoSize = true;
            this.linkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFile.Location = new System.Drawing.Point(579, 53);
            this.linkFile.Name = "linkFile";
            this.linkFile.Size = new System.Drawing.Size(118, 20);
            this.linkFile.TabIndex = 92;
            this.linkFile.TabStop = true;
            this.linkFile.Text = "No File Select.";
            // 
            // dgvhopDong
            // 
            this.dgvhopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvhopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhopDong.Location = new System.Drawing.Point(43, 282);
            this.dgvhopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvhopDong.Name = "dgvhopDong";
            this.dgvhopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhopDong.Size = new System.Drawing.Size(1355, 222);
            this.dgvhopDong.TabIndex = 89;
            this.dgvhopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhopDong_CellContentClick);
            // 
            // tbmaphuluc
            // 
            this.tbmaphuluc.AcceptsReturn = true;
            this.tbmaphuluc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbmaphuluc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaphuluc.Location = new System.Drawing.Point(172, 53);
            this.tbmaphuluc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbmaphuluc.Name = "tbmaphuluc";
            this.tbmaphuluc.Size = new System.Drawing.Size(244, 26);
            this.tbmaphuluc.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(967, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(435, 160);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(141, 100);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(156, 42);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.ToolTip = "(none)";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AcceptsReturn = true;
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(93, 44);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(256, 26);
            this.tbTimKiem.TabIndex = 11;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(172, 150);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(244, 22);
            this.dtNgayLap.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Ngày Lập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "Nội Dung:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Phụ Lục:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Hợp Đồng:";
            // 
            // btnDuyetFile
            // 
            this.btnDuyetFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuyetFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetFile.Appearance.Options.UseFont = true;
            this.btnDuyetFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDuyetFile.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetFile.Image")));
            this.btnDuyetFile.Location = new System.Drawing.Point(483, 87);
            this.btnDuyetFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuyetFile.Name = "btnDuyetFile";
            this.btnDuyetFile.Size = new System.Drawing.Size(156, 31);
            this.btnDuyetFile.TabIndex = 79;
            this.btnDuyetFile.Text = "Duyệt File";
            this.btnDuyetFile.Click += new System.EventHandler(this.btnDuyetFile_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(788, 206);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 42);
            this.btnReset.TabIndex = 88;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(561, 206);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 42);
            this.btnXoa.TabIndex = 87;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(332, 206);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 42);
            this.btnLuu.TabIndex = 86;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnThem.Location = new System.Drawing.Point(104, 206);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 42);
            this.btnThem.TabIndex = 85;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmPhuLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 518);
            this.Controls.Add(this.cbmahopdong);
            this.Controls.Add(this.linkFile);
            this.Controls.Add(this.dgvhopDong);
            this.Controls.Add(this.tbmaphuluc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDuyetFile);
            this.Controls.Add(this.dtNgayLap);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPhuLuc";
            this.Text = "PHỤ LỤC HỢP ĐỒNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhopDong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.ComboBox cbmahopdong;
        private System.Windows.Forms.LinkLabel linkFile;
        private System.Windows.Forms.DataGridView dgvhopDong;
        private System.Windows.Forms.TextBox tbmaphuluc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnDuyetFile;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}