﻿namespace QuanLiBanVang.Form
{
        partial class NhapPhieuBanHang_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapPhieuBanHang_Form));
            this.contextMenuStripUpdateGridData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSavingBackgrounWorker = new System.ComponentModel.BackgroundWorker();
            this.simpleButton_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaCTPBH = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.cboMaLoaiSp = new System.Windows.Forms.ComboBox();
            this.dtgvChiTietPBH = new System.Windows.Forms.DataGridView();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnThemPhieuBanHang = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerNgayBan = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieuBanHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStripUpdateGridData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuBanHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripUpdateGridData
            // 
            this.contextMenuStripUpdateGridData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.contextMenuStripUpdateGridData.Name = "contextMenuStripUpdateGridData";
            this.contextMenuStripUpdateGridData.Size = new System.Drawing.Size(95, 48);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // simpleButton_Huy
            // 
            this.simpleButton_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton_Huy.Location = new System.Drawing.Point(968, 550);
            this.simpleButton_Huy.Name = "simpleButton_Huy";
            this.simpleButton_Huy.Size = new System.Drawing.Size(87, 27);
            this.simpleButton_Huy.TabIndex = 4;
            this.simpleButton_Huy.Text = "Hủy";
            // 
            // simpleButton_Luu
            // 
            this.simpleButton_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton_Luu.Location = new System.Drawing.Point(875, 550);
            this.simpleButton_Luu.Name = "simpleButton_Luu";
            this.simpleButton_Luu.Size = new System.Drawing.Size(87, 27);
            this.simpleButton_Luu.TabIndex = 5;
            this.simpleButton_Luu.Text = "Lưu";
            this.simpleButton_Luu.Click += new System.EventHandler(this.simpleButton_Luu_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1043, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Phiếu bán hàng";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.txtMaCTPBH);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.btnCapNhat);
            this.groupControl3.Controls.Add(this.txtDonGia);
            this.groupControl3.Controls.Add(this.cboTenSP);
            this.groupControl3.Controls.Add(this.cboMaLoaiSp);
            this.groupControl3.Controls.Add(this.dtgvChiTietPBH);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.labelControl11);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.simpleButtonXoa);
            this.groupControl3.Controls.Add(this.simpleButtonSua);
            this.groupControl3.Controls.Add(this.txtTongTien);
            this.groupControl3.Controls.Add(this.txtSL);
            this.groupControl3.Controls.Add(this.simpleButtonThem);
            this.groupControl3.Location = new System.Drawing.Point(17, 139);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1033, 405);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Chi tiết";
            // 
            // txtMaCTPBH
            // 
            this.txtMaCTPBH.Location = new System.Drawing.Point(58, 25);
            this.txtMaCTPBH.Name = "txtMaCTPBH";
            this.txtMaCTPBH.Size = new System.Drawing.Size(110, 21);
            this.txtMaCTPBH.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Mã CTPBH";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(936, 344);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(87, 27);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(811, 25);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.Mask.EditMask = "[0-9]{1,3}";
            this.txtDonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 31;
            // 
            // cboTenSP
            // 
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(386, 25);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(240, 21);
            this.cboTenSP.TabIndex = 30;
            this.cboTenSP.SelectedIndexChanged += new System.EventHandler(this.cboTenSP_SelectedIndexChanged);
            // 
            // cboMaLoaiSp
            // 
            this.cboMaLoaiSp.FormattingEnabled = true;
            this.cboMaLoaiSp.Location = new System.Drawing.Point(214, 24);
            this.cboMaLoaiSp.Name = "cboMaLoaiSp";
            this.cboMaLoaiSp.Size = new System.Drawing.Size(107, 21);
            this.cboMaLoaiSp.TabIndex = 29;
            this.cboMaLoaiSp.SelectedIndexChanged += new System.EventHandler(this.cboMaLoaiSp_SelectedIndexChanged);
            // 
            // dtgvChiTietPBH
            // 
            this.dtgvChiTietPBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPBH.Location = new System.Drawing.Point(8, 54);
            this.dtgvChiTietPBH.Name = "dtgvChiTietPBH";
            this.dtgvChiTietPBH.Size = new System.Drawing.Size(924, 317);
            this.dtgvChiTietPBH.TabIndex = 28;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(174, 28);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Loại SP";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(333, 30);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "Sản phẩm";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(643, 28);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 13);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Số lượng";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(768, 28);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(37, 13);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "Đơn giá";
            this.labelControl11.Click += new System.EventHandler(this.labelControl11_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(793, 377);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Tổng tiền";
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonXoa.ImageOptions.Image")));
            this.simpleButtonXoa.Location = new System.Drawing.Point(938, 91);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonXoa.TabIndex = 14;
            this.simpleButtonXoa.Text = "Xóa";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSua.ImageOptions.Image")));
            this.simpleButtonSua.Location = new System.Drawing.Point(938, 58);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonSua.TabIndex = 13;
            this.simpleButtonSua.Text = "Sửa";
            this.simpleButtonSua.Click += new System.EventHandler(this.simpleButtonSua_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(858, 376);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTongTien.Properties.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(146, 20);
            this.txtTongTien.TabIndex = 11;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(697, 26);
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSL.Properties.Mask.EditMask = "[0-9]{1,3}";
            this.txtSL.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSL.Size = new System.Drawing.Size(65, 20);
            this.txtSL.TabIndex = 10;
            this.txtSL.EditValueChanged += new System.EventHandler(this.txtSL_EditValueChanged);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonThem.ImageOptions.Image")));
            this.simpleButtonThem.Location = new System.Drawing.Point(938, 24);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonThem.TabIndex = 8;
            this.simpleButtonThem.Text = "Thêm";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnThemPhieuBanHang);
            this.groupControl2.Controls.Add(this.dateTimePickerNgayBan);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtSoPhieuBanHang);
            this.groupControl2.Controls.Add(this.txtTenKH);
            this.groupControl2.Location = new System.Drawing.Point(17, 43);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1033, 90);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.TabStop = true;
            this.groupControl2.Text = "Thông tin";
            // 
            // btnThemPhieuBanHang
            // 
            this.btnThemPhieuBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemPhieuBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuBanHang.ImageOptions.Image")));
            this.btnThemPhieuBanHang.Location = new System.Drawing.Point(938, 27);
            this.btnThemPhieuBanHang.Name = "btnThemPhieuBanHang";
            this.btnThemPhieuBanHang.Size = new System.Drawing.Size(87, 27);
            this.btnThemPhieuBanHang.TabIndex = 25;
            this.btnThemPhieuBanHang.Text = "Thêm";
            this.btnThemPhieuBanHang.Click += new System.EventHandler(this.btnThemPhieuBanHang_Click);
            // 
            // dateTimePickerNgayBan
            // 
            this.dateTimePickerNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayBan.Location = new System.Drawing.Point(387, 28);
            this.dateTimePickerNgayBan.Name = "dateTimePickerNgayBan";
            this.dateTimePickerNgayBan.Size = new System.Drawing.Size(218, 21);
            this.dateTimePickerNgayBan.TabIndex = 24;
            this.dateTimePickerNgayBan.Value = new System.DateTime(2019, 7, 1, 13, 47, 26, 0);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(8, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "Số phiếu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Tên khách hàng";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(311, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Ngày lập";
            // 
            // txtSoPhieuBanHang
            // 
            this.txtSoPhieuBanHang.Location = new System.Drawing.Point(95, 29);
            this.txtSoPhieuBanHang.Name = "txtSoPhieuBanHang";
            this.txtSoPhieuBanHang.Size = new System.Drawing.Size(175, 20);
            this.txtSoPhieuBanHang.TabIndex = 11;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(95, 55);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(314, 20);
            this.txtTenKH.TabIndex = 11;
            // 
            // NhapPhieuBanHang_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton_Luu);
            this.Controls.Add(this.simpleButton_Huy);
            this.Name = "NhapPhieuBanHang_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Bán Hàng";
            this.contextMenuStripUpdateGridData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuBanHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.ContextMenuStrip contextMenuStripUpdateGridData;
            private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
            private System.ComponentModel.BackgroundWorker databaseSavingBackgrounWorker;
            private DevExpress.XtraEditors.SimpleButton simpleButton_Huy;
            private DevExpress.XtraEditors.SimpleButton simpleButton_Luu;
            private DevExpress.XtraEditors.LabelControl labelControl2;
            private DevExpress.XtraEditors.GroupControl groupControl3;
            private DevExpress.XtraEditors.TextEdit txtTongTien;
            private DevExpress.XtraEditors.TextEdit txtSL;
            private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
            private DevExpress.XtraEditors.GroupControl groupControl2;
            private DevExpress.XtraEditors.TextEdit txtTenKH;
            private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
            private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
            private DevExpress.XtraEditors.LabelControl labelControl1;
            private DevExpress.XtraEditors.LabelControl labelControl6;
            private DevExpress.XtraEditors.LabelControl labelControl4;
            private DevExpress.XtraEditors.LabelControl labelControl8;
            private DevExpress.XtraEditors.LabelControl labelControl9;
            private DevExpress.XtraEditors.LabelControl labelControl10;
            private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.DataGridView dtgvChiTietPBH;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSoPhieuBanHang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBan;
        private System.Windows.Forms.ComboBox cboMaLoaiSp;
        private System.Windows.Forms.ComboBox cboTenSP;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtMaCTPBH;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuBanHang;
    }
}