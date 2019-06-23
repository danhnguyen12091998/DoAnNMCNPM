using System;
using System.Windows.Forms;

using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class NhapDichVu : DevExpress.XtraEditors.XtraForm
    {
        
        public NhapDichVu()
        {
            InitializeComponent();
            
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearForm()
        {
            textEditTenDV.Text = textEditTienCong.Text = null;
        }
        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NhapDichVu_SizeChanged(object sender, EventArgs e)
        {
            groupControl1.Left = (ClientSize.Width - groupControl1.Width) / 2;
            simpleButtonHuy.Left = groupControl1.Right - simpleButtonOK.Width;
            simpleButtonOK.Left = simpleButtonHuy.Left - simpleButtonOK.Width - 10; 
        }
    }
}