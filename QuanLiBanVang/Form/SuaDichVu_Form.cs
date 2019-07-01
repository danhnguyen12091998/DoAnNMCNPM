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
    public partial class SuaDichVu_Form : DevExpress.XtraEditors.XtraForm
    {
        public SuaDichVu_Form()
        {
            InitializeComponent();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string MaDV = txtMaDV.Text;
            string TenDV = txtTenDV.Text;
            float DonGia = float.Parse(txtDonGia.Text);


            if (DichVuDAO.Instance.CapNhatDichVu(MaDV, TenDV, DonGia))
            {
                MessageBox.Show("Cập nhật dịch vụ thành công !");
                this.Close();
            }

            else
            {
                MessageBox.Show("Có lỗi khi cập nhật dịch vụ !");
                this.Close();
            }
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
