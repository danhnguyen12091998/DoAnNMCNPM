using System;
using System.Windows.Forms;

using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class SuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaKhachHang(int id)
        {
            InitializeComponent();
            
        }

        private void simpleButtonOk_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}