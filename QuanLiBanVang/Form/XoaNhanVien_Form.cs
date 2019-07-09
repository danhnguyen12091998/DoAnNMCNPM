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
    public partial class XoaNhanVien_Form : DevExpress.XtraEditors.XtraForm
    {
        public XoaNhanVien_Form()
        {
            InitializeComponent();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text;

            if(NhanVienDAO.Instance.CheckMaNhanVien(MaNV) == true)
            {
                if(NhanVienDAO.Instance.XoaLNhanVien(MaNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa nhân viên !");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã nhân viên cần xóa !");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaNhanVien_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
