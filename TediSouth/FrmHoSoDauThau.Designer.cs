namespace TediSouth
{
    partial class FrmHoSoDauThau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoSoDauThau));
            this.dtngaylap = new System.Windows.Forms.DateTimePicker();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.dgvHSDT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMucGia = new System.Windows.Forms.TextBox();
            this.btnDuyetFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.LinkFile = new System.Windows.Forms.LinkLabel();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.cbDuAn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtngaylap
            // 
            this.dtngaylap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtngaylap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaylap.Location = new System.Drawing.Point(251, 170);
            this.dtngaylap.Margin = new System.Windows.Forms.Padding(4);
            this.dtngaylap.Name = "dtngaylap";
            this.dtngaylap.Size = new System.Drawing.Size(249, 22);
            this.dtngaylap.TabIndex = 4;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.AcceptsReturn = true;
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(21, 27);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(501, 28);
            this.tbTimKiem.TabIndex = 11;
            this.tbTimKiem.Text = "Nhập Mã Đơn Vị hoặc Mã Dự Án để tìm...";
            this.tbTimKiem.Click += new System.EventHandler(this.tbTimKiem_Click);
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // dgvHSDT
            // 
            this.dgvHSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHSDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHSDT.Location = new System.Drawing.Point(25, 324);
            this.dgvHSDT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHSDT.Name = "dgvHSDT";
            this.dgvHSDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHSDT.Size = new System.Drawing.Size(1341, 247);
            this.dgvHSDT.TabIndex = 52;
            this.dgvHSDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click_cell);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.tbTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(768, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 75);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ngày Lập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nội Dung:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dự Án:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Đơn Vị:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mức Giá:";
            // 
            // tbMucGia
            // 
            this.tbMucGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMucGia.Location = new System.Drawing.Point(251, 123);
            this.tbMucGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbMucGia.Name = "tbMucGia";
            this.tbMucGia.Size = new System.Drawing.Size(249, 26);
            this.tbMucGia.TabIndex = 3;
            this.tbMucGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMucGia_KeyPress);
            // 
            // btnDuyetFile
            // 
            this.btnDuyetFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDuyetFile.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetFile.Appearance.Options.UseFont = true;
            this.btnDuyetFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDuyetFile.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetFile.Image")));
            this.btnDuyetFile.Location = new System.Drawing.Point(528, 74);
            this.btnDuyetFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyetFile.Name = "btnDuyetFile";
            this.btnDuyetFile.Size = new System.Drawing.Size(156, 31);
            this.btnDuyetFile.TabIndex = 5;
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
            this.btnReset.Location = new System.Drawing.Point(767, 245);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 42);
            this.btnReset.TabIndex = 51;
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
            this.btnXoa.Location = new System.Drawing.Point(540, 245);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(144, 42);
            this.btnXoa.TabIndex = 50;
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
            this.btnLuu.Location = new System.Drawing.Point(311, 245);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 42);
            this.btnLuu.TabIndex = 49;
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
            this.btnThem.Location = new System.Drawing.Point(83, 245);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 42);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.click_Add);
            // 
            // LinkFile
            // 
            this.LinkFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LinkFile.AutoSize = true;
            this.LinkFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkFile.Location = new System.Drawing.Point(632, 42);
            this.LinkFile.Name = "LinkFile";
            this.LinkFile.Size = new System.Drawing.Size(111, 20);
            this.LinkFile.TabIndex = 56;
            this.LinkFile.TabStop = true;
            this.LinkFile.Text = "No file select.";
            this.LinkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFile_LinkClicked);
            // 
            // cbDonVi
            // 
            this.cbDonVi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Location = new System.Drawing.Point(251, 38);
            this.cbDonVi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(249, 24);
            this.cbDonVi.TabIndex = 1;
            // 
            // cbDuAn
            // 
            this.cbDuAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDuAn.FormattingEnabled = true;
            this.cbDuAn.Location = new System.Drawing.Point(251, 80);
            this.cbDuAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDuAn.Name = "cbDuAn";
            this.cbDuAn.Size = new System.Drawing.Size(249, 24);
            this.cbDuAn.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "Tỷ VNĐ";
            // 
            // FrmHoSoDauThau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 586);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDuAn);
            this.Controls.Add(this.cbDonVi);
            this.Controls.Add(this.LinkFile);
            this.Controls.Add(this.btnDuyetFile);
            this.Controls.Add(this.dtngaylap);
            this.Controls.Add(this.dgvHSDT);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMucGia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoSoDauThau";
            this.Text = "HỒ SƠ ĐẤU THẦU";
            this.Load += new System.EventHandler(this.FrmHoSoDauThau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDuyetFile;
        private System.Windows.Forms.DateTimePicker dtngaylap;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView dgvHSDT;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMucGia;
        private System.Windows.Forms.LinkLabel LinkFile;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.ComboBox cbDuAn;
        private System.Windows.Forms.Label label8;
    }
}