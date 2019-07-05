namespace QuanLiBanVang.Form
{
        partial class ChiTietPhieuBanHang_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhieuBanHang_Form));
            this.contextMenuStripUpdateGridData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSavingBackgrounWorker = new System.ComponentModel.BackgroundWorker();
            this.simpleButton_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvChiTietPBH = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayLap = new DevExpress.XtraEditors.TextEdit();
            this.btnThemPhieuBanHang = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoPhieuBanHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStripUpdateGridData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).BeginInit();
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
            this.simpleButton_Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Huy.ImageOptions.Image")));
            this.simpleButton_Huy.Location = new System.Drawing.Point(968, 550);
            this.simpleButton_Huy.Name = "simpleButton_Huy";
            this.simpleButton_Huy.Size = new System.Drawing.Size(87, 27);
            this.simpleButton_Huy.TabIndex = 4;
            this.simpleButton_Huy.Text = "OK";
            this.simpleButton_Huy.Click += new System.EventHandler(this.simpleButton_Huy_Click);
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
            this.labelControl2.Location = new System.Drawing.Point(-6, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1043, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Chi tiết phiếu bán hàng";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.dtgvChiTietPBH);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.txtTongTien);
            this.groupControl3.Location = new System.Drawing.Point(17, 139);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1033, 405);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Chi tiết";
            // 
            // dtgvChiTietPBH
            // 
            this.dtgvChiTietPBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPBH.Location = new System.Drawing.Point(8, 24);
            this.dtgvChiTietPBH.Name = "dtgvChiTietPBH";
            this.dtgvChiTietPBH.Size = new System.Drawing.Size(924, 317);
            this.dtgvChiTietPBH.TabIndex = 28;
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
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.txtNgayLap);
            this.groupControl2.Controls.Add(this.btnThemPhieuBanHang);
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
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(480, 55);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(187, 20);
            this.txtNgayLap.TabIndex = 26;
            // 
            // btnThemPhieuBanHang
            // 
            this.btnThemPhieuBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemPhieuBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuBanHang.ImageOptions.Image")));
            this.btnThemPhieuBanHang.Location = new System.Drawing.Point(938, 27);
            this.btnThemPhieuBanHang.Name = "btnThemPhieuBanHang";
            this.btnThemPhieuBanHang.Size = new System.Drawing.Size(87, 27);
            this.btnThemPhieuBanHang.TabIndex = 25;
            this.btnThemPhieuBanHang.Text = "Xem";
            this.btnThemPhieuBanHang.Click += new System.EventHandler(this.btnThemPhieuBanHang_Click);
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
            this.labelControl4.Location = new System.Drawing.Point(432, 58);
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
            // ChiTietPhieuBanHang_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton_Huy);
            this.Name = "ChiTietPhieuBanHang_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu Bán Hàng";
            this.contextMenuStripUpdateGridData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLap.Properties)).EndInit();
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
            private DevExpress.XtraEditors.LabelControl labelControl2;
            private DevExpress.XtraEditors.GroupControl groupControl3;
            private DevExpress.XtraEditors.TextEdit txtTongTien;
            private DevExpress.XtraEditors.GroupControl groupControl2;
            private DevExpress.XtraEditors.TextEdit txtTenKH;
            private DevExpress.XtraEditors.LabelControl labelControl1;
            private DevExpress.XtraEditors.LabelControl labelControl6;
            private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DataGridView dtgvChiTietPBH;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtSoPhieuBanHang;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuBanHang;
        private DevExpress.XtraEditors.TextEdit txtNgayLap;
    }
}