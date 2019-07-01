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
using QuanLiBanVang.DAO;

namespace QuanLiBanVang.Report
{
    public partial class SuaLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaLoaiSanPham_Form()
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
                string maLoaiSP = txtID.Text;
                string tenLoaiSP = txtName.Text;
                float phanTram = float.Parse(txtPercent.Text);
                string maDVT = txtmaDVT.Text;

                if (LoaiSanPhamDAO.Instance.CheckMaLoaiSP(maLoaiSP) == true)
                {

                    if (LoaiSanPhamDAO.Instance.CapNhatLoaiSanPham(maLoaiSP, tenLoaiSP, phanTram, maDVT))
                    {
                        MessageBox.Show("Cập nhật loại sản phẩm thành công !");
                    }
                    else

                    {
                        MessageBox.Show("Có lỗi khi cập nhật loại sản phẩm !");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm cần cập nhật !");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}