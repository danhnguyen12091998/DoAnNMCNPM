using System;
using System.Windows.Forms;
using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class SuaDichVu : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaDichVu(int id)
        {
            InitializeComponent();
           
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}