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
    public partial class SuaNhanVien_Form : DevExpress.XtraEditors.XtraForm
    {
       
        public SuaNhanVien_Form()
        {
            InitializeComponent();
        }
        public SuaNhanVien_Form(int id)
        {
            InitializeComponent();
           
            
        }
        public bool CheckControlValidation()
        {
            if (this.txtAddress.Text == "")
                return false;
            if (this.txtName.Text == "")
                return false;
            if (this.txtPassword.Text == "")
                return false;
            if (this.txtPhone.Text == "")
                return false;
            if (this.txtUsername.Text == "")
                return false;
            if (this.cboGroupUser.SelectedIndex == -1)
                return false;
            if (this.cboPosition.SelectedIndex == -1)
                return false;
            if (this.dtpkBirth.EditValue == null)
                return false;
            return true;
        }
        public void loadStaffInfo()
        {
          //  _bulStaff = new BUL.BUL_NhanVien();
          //  _bulGroupUser = new BUL.BUL_NhomNguoiDung();
         //   _bulPosition = new BUL.BUL_ChucVu();
          //  _staff = _bulStaff.getStaffById(4);
            
        }
        private void SuaNhanVien_Form_Load(object sender, EventArgs e)
        {
            this.loadStaffInfo();
            this.txtUsername.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
    
       
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void chkbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkbChangePassword.Checked == true)
            {
                this.txtPassword.ReadOnly = false;
            }
            else
            {
                this.txtPassword.ReadOnly = true;
            }
        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}