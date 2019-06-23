using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLiBanVang.Report
{
    public partial class NhapPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {
       
        
        public NhapPhieuChi_Form()
        {
            InitializeComponent();
      
            
        }
        public NhapPhieuChi_Form(int staffid)
        {
      
           

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NhapPhieuChi_Form_Load(object sender, EventArgs e)
        {
            
            this.dtpkCreateDate.EditValue = DateTime.Now;
            this.dtpkCreateDate.Properties.MaxValue = DateTime.Now;
            this.dtpkCreateDate.Properties.MinValue = DateTime.Now;
            this.dtpkCreateDate.ReadOnly = true;
           
        }
        private bool CheckControlValidation()
        {
            if (txtContent.Text == "")
                return false;
            if (txtCost.Text == "")
                return false;
            if (dtpkCreateDate.EditValue.ToString() == "")
                return false;
            return true;
        }
        private void Clear()
        {
            this.txtContent.Text = "";
            this.txtCost.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void NhapPhieuChi_Form_SizeChanged(object sender, EventArgs e)
        {
            groupControlInfo.Left = (ClientSize.Width - groupControlInfo.Width) / 2;
            btnCancel.Left = groupControlInfo.Right - btnSave.Width;
            btnSave.Left = btnCancel.Left - btnSave.Width - 10; 
        }
    }
}