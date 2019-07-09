namespace QuanLiBanVang.Report
{
    partial class NhapPhieuMua_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapPhieuMua_Form));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlGeneralInfo = new DevExpress.XtraEditors.GroupControl();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.btnAddPMH = new DevExpress.XtraEditors.SimpleButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoPMH = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerNgayBan = new System.Windows.Forms.DateTimePicker();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlDetail = new DevExpress.XtraEditors.GroupControl();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txtCTPMH = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.dtgvCTPMH = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGeneralInfo)).BeginInit();
            this.groupControlGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDetail)).BeginInit();
            this.groupControlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(924, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Phiếu mua hàng";
            // 
            // groupControlGeneralInfo
            // 
            this.groupControlGeneralInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlGeneralInfo.Controls.Add(this.cboNCC);
            this.groupControlGeneralInfo.Controls.Add(this.btnAddPMH);
            this.groupControlGeneralInfo.Controls.Add(this.txtSDT);
            this.groupControlGeneralInfo.Controls.Add(this.txtDiaChi);
            this.groupControlGeneralInfo.Controls.Add(this.txtSoPMH);
            this.groupControlGeneralInfo.Controls.Add(this.labelControl12);
            this.groupControlGeneralInfo.Controls.Add(this.dateTimePickerNgayBan);
            this.groupControlGeneralInfo.Controls.Add(this.labelControl9);
            this.groupControlGeneralInfo.Controls.Add(this.labelControl3);
            this.groupControlGeneralInfo.Controls.Add(this.labelControl4);
            this.groupControlGeneralInfo.Controls.Add(this.labelControl2);
            this.groupControlGeneralInfo.Location = new System.Drawing.Point(12, 42);
            this.groupControlGeneralInfo.Name = "groupControlGeneralInfo";
            this.groupControlGeneralInfo.Size = new System.Drawing.Size(999, 141);
            this.groupControlGeneralInfo.TabIndex = 1;
            this.groupControlGeneralInfo.Text = "Thông tin chung";
            // 
            // cboNCC
            // 
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(118, 55);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(155, 21);
            this.cboNCC.TabIndex = 32;
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // btnAddPMH
            // 
            this.btnAddPMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPMH.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPMH.Appearance.Options.UseFont = true;
            this.btnAddPMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPMH.ImageOptions.Image")));
            this.btnAddPMH.Location = new System.Drawing.Point(907, 27);
            this.btnAddPMH.Name = "btnAddPMH";
            this.btnAddPMH.Size = new System.Drawing.Size(87, 27);
            this.btnAddPMH.TabIndex = 31;
            this.btnAddPMH.Text = "Thêm";
            this.btnAddPMH.Click += new System.EventHandler(this.btnAddPMH_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(376, 54);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(157, 21);
            this.txtSDT.TabIndex = 30;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(117, 82);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(157, 21);
            this.txtDiaChi.TabIndex = 29;
            // 
            // txtSoPMH
            // 
            this.txtSoPMH.Location = new System.Drawing.Point(117, 25);
            this.txtSoPMH.Name = "txtSoPMH";
            this.txtSoPMH.Size = new System.Drawing.Size(157, 21);
            this.txtSoPMH.TabIndex = 28;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(294, 59);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(62, 13);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "Số điện thoại";
            // 
            // dateTimePickerNgayBan
            // 
            this.dateTimePickerNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayBan.Location = new System.Drawing.Point(376, 27);
            this.dateTimePickerNgayBan.Name = "dateTimePickerNgayBan";
            this.dateTimePickerNgayBan.Size = new System.Drawing.Size(218, 21);
            this.dateTimePickerNgayBan.TabIndex = 26;
            this.dateTimePickerNgayBan.Value = new System.DateTime(2019, 7, 1, 13, 47, 26, 0);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(294, 33);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "Ngày lập";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Địa Chỉ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Tên nhà cung cấp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số phiếu";
            // 
            // groupControlDetail
            // 
            this.groupControlDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlDetail.Controls.Add(this.txtTongTien);
            this.groupControlDetail.Controls.Add(this.label1);
            this.groupControlDetail.Controls.Add(this.btnrefresh);
            this.groupControlDetail.Controls.Add(this.txtCTPMH);
            this.groupControlDetail.Controls.Add(this.labelControl11);
            this.groupControlDetail.Controls.Add(this.cboSanPham);
            this.groupControlDetail.Controls.Add(this.cboLoaiSanPham);
            this.groupControlDetail.Controls.Add(this.btnDelete);
            this.groupControlDetail.Controls.Add(this.dtgvCTPMH);
            this.groupControlDetail.Controls.Add(this.txtDonGia);
            this.groupControlDetail.Controls.Add(this.labelControl8);
            this.groupControlDetail.Controls.Add(this.labelControl6);
            this.groupControlDetail.Controls.Add(this.txtSoLuong);
            this.groupControlDetail.Controls.Add(this.btnEdit);
            this.groupControlDetail.Controls.Add(this.btnAdd);
            this.groupControlDetail.Controls.Add(this.labelControl7);
            this.groupControlDetail.Controls.Add(this.labelControl5);
            this.groupControlDetail.Location = new System.Drawing.Point(12, 146);
            this.groupControlDetail.Name = "groupControlDetail";
            this.groupControlDetail.Size = new System.Drawing.Size(999, 349);
            this.groupControlDetail.TabIndex = 2;
            this.groupControlDetail.Text = "Chi tiết";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(800, 285);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(101, 21);
            this.txtTongTien.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tổng tiền";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Appearance.Options.UseFont = true;
            this.btnrefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.ImageOptions.Image")));
            this.btnrefresh.Location = new System.Drawing.Point(907, 252);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(87, 27);
            this.btnrefresh.TabIndex = 24;
            this.btnrefresh.Text = "Cập nhật";
            this.btnrefresh.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtCTPMH
            // 
            this.txtCTPMH.Location = new System.Drawing.Point(68, 32);
            this.txtCTPMH.Name = "txtCTPMH";
            this.txtCTPMH.Size = new System.Drawing.Size(108, 21);
            this.txtCTPMH.TabIndex = 23;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(5, 35);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Mã CT_PMH";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(460, 32);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(114, 21);
            this.cboSanPham.TabIndex = 21;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboTenSP_SelectedIndexChanged);
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(267, 32);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(114, 21);
            this.cboLoaiSanPham.TabIndex = 20;
            this.cboLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSanPham_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(907, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtgvCTPMH
            // 
            this.dtgvCTPMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTPMH.Location = new System.Drawing.Point(5, 62);
            this.dtgvCTPMH.Name = "dtgvCTPMH";
            this.dtgvCTPMH.Size = new System.Drawing.Size(896, 217);
            this.dtgvCTPMH.TabIndex = 17;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(791, 33);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Mask.EditMask = "[0-9]{1,8}";
            this.txtDonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDonGia.Size = new System.Drawing.Size(108, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(748, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Đơn giá";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(193, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Loại sản phẩm";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(634, 33);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Mask.EditMask = "[0-9]{1,2}";
            this.txtSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSoLuong.Size = new System.Drawing.Size(108, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(907, 62);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 27);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(907, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(586, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Số lượng";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(387, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tên sản phẩm";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(831, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(924, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NhapPhieuMua_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1023, 531);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControlDetail);
            this.Controls.Add(this.groupControlGeneralInfo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NhapPhieuMua_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập phiếu mua";
            this.Load += new System.EventHandler(this.NhapPhieuMua_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGeneralInfo)).EndInit();
            this.groupControlGeneralInfo.ResumeLayout(false);
            this.groupControlGeneralInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDetail)).EndInit();
            this.groupControlDetail.ResumeLayout(false);
            this.groupControlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTPMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlGeneralInfo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControlDetail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtSoPMH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridView dtgvCTPMH;
        private DevExpress.XtraEditors.SimpleButton btnAddPMH;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private System.Windows.Forms.TextBox txtCTPMH;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnrefresh;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
    }
}