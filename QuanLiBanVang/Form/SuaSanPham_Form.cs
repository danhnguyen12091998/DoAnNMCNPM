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
    public partial class SuaSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaSanPham_Form()
        {
            InitializeComponent();
            
        }
        public SuaSanPham_Form(int id)
        {
            InitializeComponent();
            
        }
        private void SuaSanPham_Form_Load(object sender, EventArgs e)
        {
           
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
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}