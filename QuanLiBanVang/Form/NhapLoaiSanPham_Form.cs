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
    public partial class NhapLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
       
        public NhapLoaiSanPham_Form()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maLoaiSP = txtMaloai.Text;
            string tenLoaiSP = txtName.Text;
            float phanTram = float.Parse(txtPercent.Text);
            string maDVT = txtDVT.Text;

            if (LoaiSanPhamDAO.Instance.CheckMaLoaiSP(maLoaiSP) == false)
            {
                if (LoaiSanPhamDAO.Instance.ThemLoaiSanPham(maLoaiSP, tenLoaiSP, phanTram, maDVT))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm mới loại sản phẩm !");
                }
            }
            else
            {
                MessageBox.Show("Trùng mã loại sản phẩm, vui lòng kiểm tra lại !");
            }

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

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }


    }
}