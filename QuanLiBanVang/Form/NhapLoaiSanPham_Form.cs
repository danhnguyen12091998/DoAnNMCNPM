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
    public partial class NhapLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
       
        public NhapLoaiSanPham_Form()
        {
            InitializeComponent();
            
        }
        
        private void Clear()
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NhapLoaiSanPham_Form_SizeChanged(object sender, EventArgs e)
        {
            groupControlInfo.Left = (ClientSize.Width - groupControlInfo.Width) / 2;
            btnCancel.Left = groupControlInfo.Right - btnCancel.Width;
            btnSave.Left = btnCancel.Left - btnSave.Width - 10; 
        }
    }
}