namespace TediSouth
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.label9 = new System.Windows.Forms.Label();
            this.cbdonvi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.QDChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHinhAnhPath = new System.Windows.Forms.TextBox();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.tbSDT1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(961, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 115;
            this.label9.Text = "Bộ Phận:";
            // 
            // cbdonvi
            // 
            this.cbdonvi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbdonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdonvi.FormattingEnabled = true;
            this.cbdonvi.Location = new System.Drawing.Point(553, 16);
            this.cbdonvi.Margin = new System.Windows.Forms.Padding(4);
            this.cbdonvi.Name = "cbdonvi";
            this.cbdonvi.Size = new System.Drawing.Size(400, 28);
            this.cbdonvi.TabIndex = 7;
            this.cbdonvi.SelectedIndexChanged += new System.EventHandler(this.cbdonvi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 111;
            this.label7.Text = "Hình Ảnh:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 345);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1341, 209);
            this.dgvNhanVien.TabIndex = 109;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(37, 23);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(465, 28);
            this.tbTimKiem.TabIndex = 11;
            this.tbTimKiem.Text = "Nhập ID hoặc tên nhân viên để tìm kiếm...";
            this.tbTimKiem.Click += new System.EventHandler(this.tbTimKiem_Click);
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(840, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(521, 64);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(169, 201);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 26);
            this.tbEmail.TabIndex = 5;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(169, 156);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(244, 26);
            this.tbDiaChi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Điện Thoại:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Đơn Vị:";
            // 
            // tbhoten
            // 
            this.tbhoten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhoten.Location = new System.Drawing.Point(169, 62);
            this.tbhoten.Margin = new System.Windows.Forms.Padding(4);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(244, 26);
            this.tbhoten.TabIndex = 2;
            // 
            // tbmanv
            // 
            this.tbmanv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmanv.Location = new System.Drawing.Point(169, 16);
            this.tbmanv.Margin = new System.Windows.Forms.Padding(4);
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(244, 26);
            this.tbmanv.TabIndex = 1;
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbHinhAnh.Location = new System.Drawing.Point(535, 79);
            this.pbHinhAnh.Margin = new System.Windows.Forms.Padding(4);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(140, 176);
            this.pbHinhAnh.TabIndex = 117;
            this.pbHinhAnh.TabStop = false;
            // 
            // QDChucVu
            // 
            this.QDChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QDChucVu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QDChucVu.Appearance.Options.UseFont = true;
            this.QDChucVu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.QDChucVu.Image = ((System.Drawing.Image)(resources.GetObject("QDChucVu.Image")));
            this.QDChucVu.Location = new System.Drawing.Point(1020, 277);
            this.QDChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.QDChucVu.Name = "QDChucVu";
            this.QDChucVu.Size = new System.Drawing.Size(175, 39);
            this.QDChucVu.TabIndex = 113;
            this.QDChucVu.Text = "QĐ Chức Vụ:";
            this.QDChucVu.Click += new System.EventHandler(this.QDChucVu_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(683, 79);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(112, 64);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.AddHinhAnh_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(797, 277);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 39);
            this.btnReset.TabIndex = 108;
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
            this.btnXoa.Location = new System.Drawing.Point(571, 277);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 39);
            this.btnXoa.TabIndex = 107;
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
            this.btnLuu.Location = new System.Drawing.Point(341, 277);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 39);
            this.btnLuu.TabIndex = 106;
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
            this.btnThem.Location = new System.Drawing.Point(113, 277);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 39);
            this.btnThem.TabIndex = 105;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.click_Add);
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtngaysinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaysinh.Location = new System.Drawing.Point(169, 246);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(244, 25);
            this.dtngaysinh.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 118;
            this.label8.Text = "Ngày Sinh:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(679, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Đường Dẫn Hình Ảnh:";
            // 
            // txtHinhAnhPath
            // 
            this.txtHinhAnhPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHinhAnhPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhAnhPath.Location = new System.Drawing.Point(885, 183);
            this.txtHinhAnhPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtHinhAnhPath.Name = "txtHinhAnhPath";
            this.txtHinhAnhPath.Size = new System.Drawing.Size(465, 26);
            this.txtHinhAnhPath.TabIndex = 120;
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(1073, 16);
            this.cbBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(288, 28);
            this.cbBoPhan.TabIndex = 114;
            // 
            // tbSDT1
            // 
            this.tbSDT1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT1.Location = new System.Drawing.Point(169, 110);
            this.tbSDT1.Margin = new System.Windows.Forms.Padding(4);
            this.tbSDT1.Mask = "000-000-0000";
            this.tbSDT1.Name = "tbSDT1";
            this.tbSDT1.Size = new System.Drawing.Size(244, 26);
            this.tbSDT1.TabIndex = 122;
            this.tbSDT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSDT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSDT1_KeyPress);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 566);
            this.Controls.Add(this.tbSDT1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHinhAnhPath);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbHinhAnh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbBoPhan);
            this.Controls.Add(this.cbdonvi);
            this.Controls.Add(this.QDChucVu);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.tbmanv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbdonvi;
        private DevExpress.XtraEditors.SimpleButton QDChucVu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHinhAnhPath;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private System.Windows.Forms.MaskedTextBox tbSDT1;
    }
}