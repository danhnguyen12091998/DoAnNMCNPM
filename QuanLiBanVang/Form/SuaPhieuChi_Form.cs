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
    public partial class SuaPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {

       
        public SuaPhieuChi_Form()
        {
            InitializeComponent();
  
            
     
        }
        public SuaPhieuChi_Form(int id)
        {
            InitializeComponent();

            
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void SuaPhieuChi_Form_Load(object sender, EventArgs e)
        {
            

        }
        private bool CheckControlValidation()
        {
            if (this.txtPrice.Text == "")
                return false;
            if (this.txtContent.Text.Length == 0)
                return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}