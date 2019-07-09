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
using System.Data;
using DevExpress.XtraGrid.Columns;
using QuanLiBanVang.DAO;
using QuanLiBanVang.Form;

namespace QuanLiBanVang.Report
{
    public partial class DanhSachDonViTinh_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public DanhSachDonViTinh_Form()
        {
            InitializeComponent();
            GetDanhSachDVT();               
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhapDonViTinh_Form nhapdvt = new NhapDonViTinh_Form();
            nhapdvt.ShowDialog();
        }

        void GetDanhSachDVT()
        {

            dtgvDonViTinh.DataSource = DonViTinhDAO.Instance.GetDsDonViTinh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDanhSachDVT();
        }
    }
}