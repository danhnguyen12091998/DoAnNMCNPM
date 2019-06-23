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
    public partial class SuaLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaLoaiSanPham_Form()
        {
            InitializeComponent();
            
        }
        public SuaLoaiSanPham_Form(int id)
        {
            InitializeComponent();
            
        }
        private void SuaLoaiSanPham_Form_Load(object sender, EventArgs e)
        {
            

        }
        public bool CheckControlValidation()
        {
            foreach (Control control in this.groupControlInfo.Controls)
            {
                if (control is TextEdit)
                {
                    if ((control as TextEdit).Text == "")
                    {
                        return false;
                    }
                }
                if (control is ComboBoxEdit)
                {
                    if ((control as ComboBoxEdit).SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckControlValidation())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            else
            {
               
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}