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
    public partial class NhapDichVu_Form : DevExpress.XtraEditors.XtraForm
    {
        public NhapDichVu_Form()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string MaDV = txtMaDV.Text;
            string TenDV = txtTenDV.Text;
            float DonGia = float.Parse(txtDonGia.Text);


            if(DichVuDAO.Instance.ThemDichVu(MaDV,TenDV,DonGia))
            {
                MessageBox.Show("Thêm dịch vụ thành công !");
                this.Close();
            }

            else
            {
                MessageBox.Show("Có lỗi khi thêm dịch vụ !");
                this.Close();
            }

        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
