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
using QuanLiBanVang.Model;
using QuanLiBanVang.DAO;

namespace QuanLiBanVang.Form
{
    public partial class NhapDonViTinh_Form : DevExpress.XtraEditors.XtraForm
    {

        public NhapDonViTinh_Form()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string MaDVT = txtMaDVT.Text;
            string TenDVT = txtTenDVT.Text;
            if(DonViTinhDAO.Instance.ThemDonViTinh(MaDVT,TenDVT))
            {
                MessageBox.Show("Thêm đơn vị tính thành công !");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm đơn vị tính !");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}