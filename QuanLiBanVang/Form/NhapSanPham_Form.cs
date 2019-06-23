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
using QuanLiBanVang.ExtendClass;
namespace QuanLiBanVang.Report
{
    public partial class NhapSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public NhapSanPham_Form()
        {
            InitializeComponent();
            
        }

        public bool CheckControlValidation()
        {
            if (this.txtName.Text == "")
                return false;
            if (this.txtWeight.Text == "")
                return false;
            if (this.cboProductType.SelectedIndex == -1)
                return false;
            return true;
        }
        private void Clear()
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void NhapSanPham_Form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NhapSanPham_Form_SizeChanged(object sender, EventArgs e)
        {
            groupControlInfo.Left = (ClientSize.Width - groupControlInfo.Width) / 2;
            btnCancel.Left = groupControlInfo.Right - btnSave.Width;
            btnSave.Left = btnCancel.Left - btnSave.Width - 10; 
        }
    }
}