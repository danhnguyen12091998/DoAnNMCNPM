namespace QuanLiBanVang.Form
{
    partial class SuaNhaCungCap_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaNhaCungCap_Form));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiaChiNCC = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNCC = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMaNCC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlCaption = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtSDTNCC = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDTNCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSDTNCC);
            this.groupControl1.Controls.Add(this.txtDiaChiNCC);
            this.groupControl1.Controls.Add(this.txtMaNCC);
            this.groupControl1.Controls.Add(this.txtTenNCC);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControlMaNCC);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(311, 138);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Location = new System.Drawing.Point(99, 79);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Properties.Mask.EditMask = "[0-9]";
            this.txtDiaChiNCC.Properties.MaxLength = 11;
            this.txtDiaChiNCC.Size = new System.Drawing.Size(207, 20);
            this.txtDiaChiNCC.TabIndex = 3;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(99, 27);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(120, 20);
            this.txtMaNCC.TabIndex = 1;
            this.txtMaNCC.EditValueChanged += new System.EventHandler(this.textEditMaNCC_EditValueChanged);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(99, 53);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(207, 20);
            this.txtTenNCC.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // labelControlMaNCC
            // 
            this.labelControlMaNCC.Location = new System.Drawing.Point(11, 28);
            this.labelControlMaNCC.Name = "labelControlMaNCC";
            this.labelControlMaNCC.Size = new System.Drawing.Size(81, 13);
            this.labelControlMaNCC.TabIndex = 0;
            this.labelControlMaNCC.Text = "Mã nhà cung cập";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên nhà cung cấp";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControlCaption
            // 
            this.labelControlCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControlCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControlCaption.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControlCaption.Appearance.Options.UseFont = true;
            this.labelControlCaption.Appearance.Options.UseForeColor = true;
            this.labelControlCaption.Appearance.Options.UseTextOptions = true;
            this.labelControlCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlCaption.Location = new System.Drawing.Point(12, 12);
            this.labelControlCaption.Name = "labelControlCaption";
            this.labelControlCaption.Size = new System.Drawing.Size(312, 29);
            this.labelControlCaption.TabIndex = 1;
            this.labelControlCaption.Text = "Sửa nhà cung cấp";
            // 
            // simpleButtonThoat
            // 
            this.simpleButtonThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonThoat.ImageOptions.Image")));
            this.simpleButtonThoat.Location = new System.Drawing.Point(236, 224);
            this.simpleButtonThoat.Name = "simpleButtonThoat";
            this.simpleButtonThoat.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonThoat.TabIndex = 6;
            this.simpleButtonThoat.Text = "Thoát";
            this.simpleButtonThoat.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLuu.ImageOptions.Image")));
            this.simpleButtonLuu.Location = new System.Drawing.Point(12, 224);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(87, 27);
            this.simpleButtonLuu.TabIndex = 5;
            this.simpleButtonLuu.Text = "Lưu";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Location = new System.Drawing.Point(99, 105);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.Size = new System.Drawing.Size(207, 20);
            this.txtSDTNCC.TabIndex = 4;
            // 
            // SuaNhaCungCap_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 260);
            this.Controls.Add(this.simpleButtonLuu);
            this.Controls.Add(this.simpleButtonThoat);
            this.Controls.Add(this.labelControlCaption);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.Name = "SuaNhaCungCap_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa nhà cung cấp";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.SizeChanged += new System.EventHandler(this.SuaNhaCungCap_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDTNCC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControlCaption;
        private DevExpress.XtraEditors.TextEdit txtDiaChiNCC;
        private DevExpress.XtraEditors.TextEdit txtTenNCC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.TextEdit txtMaNCC;
        private DevExpress.XtraEditors.LabelControl labelControlMaNCC;
        private DevExpress.XtraEditors.TextEdit txtSDTNCC;
    }
}