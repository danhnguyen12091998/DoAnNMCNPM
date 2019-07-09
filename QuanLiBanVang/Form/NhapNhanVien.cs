using QuanLiBanVang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanVang.Form
{
    public partial class NhapNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public NhapNhanVien()
        {
            InitializeComponent();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;
            string HoTen = txtTenNV.Text;
            string MK = txtMatKhau.Text;

            if(NhanVienDAO.Instance.CheckMaNhanVien(MaNV) == false)
            {
                if(NhanVienDAO.Instance.ThemNhanVien(MaNV,HoTen,MK))
                {
                    MessageBox.Show("Thêm nhân viên thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình nhập nhân viên !");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Trùng mã nhân viên !");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
