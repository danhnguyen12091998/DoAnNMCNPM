namespace QuanLiBanVang.Report
{
    partial class NhapSanPham_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapSanPham_Form));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlInfo = new DevExpress.XtraEditors.GroupControl();
            this.cboProductType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).BeginInit();
            this.groupControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(440, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập sản phẩm";
            // 
            // groupControlInfo
            // 
            this.groupControlInfo.Controls.Add(this.textEdit1);
            this.groupControlInfo.Controls.Add(this.cboProductType);
            this.groupControlInfo.Controls.Add(this.labelControl5);
            this.groupControlInfo.Controls.Add(this.txtWeight);
            this.groupControlInfo.Controls.Add(this.txtName);
            this.groupControlInfo.Controls.Add(this.labelControl4);
            this.groupControlInfo.Controls.Add(this.labelControl3);
            this.groupControlInfo.Controls.Add(this.labelControl2);
            this.groupControlInfo.Location = new System.Drawing.Point(12, 42);
            this.groupControlInfo.Name = "groupControlInfo";
            this.groupControlInfo.Size = new System.Drawing.Size(440, 141);
            this.groupControlInfo.TabIndex = 1;
            this.groupControlInfo.Text = "Thông tin sản phẩm";
            // 
            // cboProductType
            // 
            this.cboProductType.Location = new System.Drawing.Point(100, 48);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProductType.Size = new System.Drawing.Size(141, 20);
            this.cboProductType.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 108);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Đơn giá mua vào";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(100, 74);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Mask.EditMask = "[0-9]+(\\R.\\d{0,2})?";
            this.txtWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtWeight.Properties.MaxLength = 5;
            this.txtWeight.Size = new System.Drawing.Size(141, 20);
            this.txtWeight.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 23);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Mask.EditMask = "(\\p{L}|[0-9]|\\s){1,100}";
            this.txtName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Số lượng";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Loại sản phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tên sản phẩm";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(365, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(100, 105);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.EditMask = "[0-9]+(\\R.\\d{0,2})?";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit1.Properties.MaxLength = 5;
            this.textEdit1.Size = new System.Drawing.Size(141, 20);
            this.textEdit1.TabIndex = 7;
            // 
            // NhapSanPham_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 221);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControlInfo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "NhapSanPham_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sản phẩm";
            this.Load += new System.EventHandler(this.NhapSanPham_Form_Load);
            this.SizeChanged += new System.EventHandler(this.NhapSanPham_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInfo)).EndInit();
            this.groupControlInfo.ResumeLayout(false);
            this.groupControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cboProductType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}