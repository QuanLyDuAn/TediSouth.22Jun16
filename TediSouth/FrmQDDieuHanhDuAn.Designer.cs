namespace TediSouth
{
    partial class FrmQDDieuHanhDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQDDieuHanhDuAn));
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dgvQDDH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaQD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkFile = new System.Windows.Forms.LinkLabel();
            this.cbDuAn = new System.Windows.Forms.ComboBox();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuyetFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaCTDH = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaCTDH = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCTDH = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhanCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNVKhac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDDH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AcceptsReturn = true;
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(605, 13);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(426, 28);
            this.tbTimKiem.TabIndex = 75;
            this.tbTimKiem.Text = "Vui lòng nhập thông tin để tìm kiếm...";
            this.tbTimKiem.Click += new System.EventHandler(this.tbTimKiem_Click);
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayKy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKy.Location = new System.Drawing.Point(165, 171);
            this.dtNgayKy.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(177, 22);
            this.dtNgayKy.TabIndex = 4;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(165, 134);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(177, 22);
            this.dtNgayLap.TabIndex = 3;
            // 
            // dgvQDDH
            // 
            this.dgvQDDH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQDDH.Location = new System.Drawing.Point(13, 266);
            this.dgvQDDH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQDDH.Name = "dgvQDDH";
            this.dgvQDDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQDDH.Size = new System.Drawing.Size(684, 327);
            this.dgvQDDH.TabIndex = 88;
            this.dgvQDDH.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Ngày Ký:";
            // 
            // tbMaQD
            // 
            this.tbMaQD.AcceptsReturn = true;
            this.tbMaQD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaQD.Location = new System.Drawing.Point(165, 18);
            this.tbMaQD.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaQD.Name = "tbMaQD";
            this.tbMaQD.Size = new System.Drawing.Size(251, 26);
            this.tbMaQD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Ngày Lập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nội Dung:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Dự Án:";
            // 
            // linkFile
            // 
            this.linkFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkFile.AutoSize = true;
            this.linkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFile.Location = new System.Drawing.Point(163, 95);
            this.linkFile.Name = "linkFile";
            this.linkFile.Size = new System.Drawing.Size(118, 20);
            this.linkFile.TabIndex = 105;
            this.linkFile.TabStop = true;
            this.linkFile.Text = "No File Select.";
            this.linkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFile_LinkClicked);
            // 
            // cbDuAn
            // 
            this.cbDuAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDuAn.FormattingEnabled = true;
            this.cbDuAn.Location = new System.Drawing.Point(165, 50);
            this.cbDuAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDuAn.Name = "cbDuAn";
            this.cbDuAn.Size = new System.Drawing.Size(251, 24);
            this.cbDuAn.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(523, 217);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 42);
            this.btnReset.TabIndex = 87;
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
            this.btnXoa.Location = new System.Drawing.Point(364, 217);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 42);
            this.btnXoa.TabIndex = 86;
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
            this.btnLuu.Location = new System.Drawing.Point(195, 217);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(161, 42);
            this.btnLuu.TabIndex = 85;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDuyetFile
            // 
            this.btnDuyetFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuyetFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetFile.Appearance.Options.UseFont = true;
            this.btnDuyetFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDuyetFile.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetFile.Image")));
            this.btnDuyetFile.Location = new System.Drawing.Point(351, 130);
            this.btnDuyetFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyetFile.Name = "btnDuyetFile";
            this.btnDuyetFile.Size = new System.Drawing.Size(163, 31);
            this.btnDuyetFile.TabIndex = 5;
            this.btnDuyetFile.Text = "Duyệt File";
            this.btnDuyetFile.Click += new System.EventHandler(this.btnDuyetFile_Click);
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
            this.btnThem.Location = new System.Drawing.Point(21, 217);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 42);
            this.btnThem.TabIndex = 84;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnXoaCTDH);
            this.groupBox2.Controls.Add(this.btnSuaCTDH);
            this.groupBox2.Controls.Add(this.btnThemCTDH);
            this.groupBox2.Controls.Add(this.txtPhanCong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbMaNV);
            this.groupBox2.Controls.Add(this.lbChucVu);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbNVKhac);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvNV);
            this.groupBox2.Location = new System.Drawing.Point(704, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 545);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều Hành Nhân Viên";
            // 
            // btnXoaCTDH
            // 
            this.btnXoaCTDH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaCTDH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTDH.Appearance.Options.UseFont = true;
            this.btnXoaCTDH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoaCTDH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTDH.Image")));
            this.btnXoaCTDH.Location = new System.Drawing.Point(369, 165);
            this.btnXoaCTDH.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaCTDH.Name = "btnXoaCTDH";
            this.btnXoaCTDH.Size = new System.Drawing.Size(112, 42);
            this.btnXoaCTDH.TabIndex = 103;
            this.btnXoaCTDH.Text = "Xóa";
            this.btnXoaCTDH.Click += new System.EventHandler(this.btnXoaCTDH_Click);
            // 
            // btnSuaCTDH
            // 
            this.btnSuaCTDH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaCTDH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCTDH.Appearance.Options.UseFont = true;
            this.btnSuaCTDH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSuaCTDH.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCTDH.Image")));
            this.btnSuaCTDH.Location = new System.Drawing.Point(215, 165);
            this.btnSuaCTDH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaCTDH.Name = "btnSuaCTDH";
            this.btnSuaCTDH.Size = new System.Drawing.Size(112, 42);
            this.btnSuaCTDH.TabIndex = 102;
            this.btnSuaCTDH.Text = "Lưu";
            this.btnSuaCTDH.Click += new System.EventHandler(this.btnSuaCTDH_Click);
            // 
            // btnThemCTDH
            // 
            this.btnThemCTDH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemCTDH.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTDH.Appearance.Options.UseFont = true;
            this.btnThemCTDH.AutoWidthInLayoutControl = true;
            this.btnThemCTDH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemCTDH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThemCTDH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTDH.Image")));
            this.btnThemCTDH.Location = new System.Drawing.Point(65, 167);
            this.btnThemCTDH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemCTDH.Name = "btnThemCTDH";
            this.btnThemCTDH.Size = new System.Drawing.Size(112, 39);
            this.btnThemCTDH.TabIndex = 101;
            this.btnThemCTDH.Text = "Thêm";
            this.btnThemCTDH.Click += new System.EventHandler(this.btnThemCTDH_Click);
            // 
            // txtPhanCong
            // 
            this.txtPhanCong.AcceptsReturn = true;
            this.txtPhanCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanCong.Location = new System.Drawing.Point(197, 131);
            this.txtPhanCong.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanCong.Name = "txtPhanCong";
            this.txtPhanCong.Size = new System.Drawing.Size(239, 26);
            this.txtPhanCong.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 99;
            this.label7.Text = "Vị Trí Phân Công:";
            // 
            // cbMaNV
            // 
            this.cbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(197, 24);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(239, 28);
            this.cbMaNV.TabIndex = 6;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // lbChucVu
            // 
            this.lbChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.Location = new System.Drawing.Point(459, 90);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(24, 20);
            this.lbChucVu.TabIndex = 97;
            this.lbChucVu.Text = "...";
            // 
            // lbHoTen
            // 
            this.lbHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(115, 90);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(24, 20);
            this.lbHoTen.TabIndex = 97;
            this.lbHoTen.Text = "...";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 97;
            this.label10.Text = "Mã Nhân Viên:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(365, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "Chức Vụ:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Họ Tên:";
            // 
            // dgvNV
            // 
            this.dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(7, 217);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(517, 327);
            this.dgvNV.TabIndex = 90;
            this.dgvNV.Click += new System.EventHandler(this.dgvNV_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "QĐ Điều Hành:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // lbNVKhac
            // 
            this.lbNVKhac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNVKhac.AutoSize = true;
            this.lbNVKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVKhac.ForeColor = System.Drawing.Color.Crimson;
            this.lbNVKhac.Location = new System.Drawing.Point(92, 61);
            this.lbNVKhac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNVKhac.Name = "lbNVKhac";
            this.lbNVKhac.Size = new System.Drawing.Size(0, 20);
            this.lbNVKhac.TabIndex = 97;
            // 
            // FrmQDDieuHanhDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbDuAn);
            this.Controls.Add(this.linkFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDuyetFile);
            this.Controls.Add(this.dtNgayKy);
            this.Controls.Add(this.dtNgayLap);
            this.Controls.Add(this.dgvQDDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaQD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQDDieuHanhDuAn";
            this.Text = "ĐIỀU HÀNH DỰ ÁN";
            this.Load += new System.EventHandler(this.FrmQDDieuHanhDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQDDH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox tbTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnDuyetFile;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.DataGridView dgvQDDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaQD;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkFile;
        private System.Windows.Forms.ComboBox cbDuAn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhanCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnXoaCTDH;
        private DevExpress.XtraEditors.SimpleButton btnSuaCTDH;
        private DevExpress.XtraEditors.SimpleButton btnThemCTDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbNVKhac;
    }
}