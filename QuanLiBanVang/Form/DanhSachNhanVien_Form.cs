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
    public partial class DanhSachNhanVien_Form : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachNhanVien_Form()
        {
            InitializeComponent();
            GetDSNhanVien();
        }

        private void DanhSachKH_Form_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapNhanVien nhapnv = new NhapNhanVien();
            nhapnv.ShowDialog();
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GetDSNhanVien()
        {
            dtgvDanhSachNhanVien.DataSource = NhanVienDAO.Instance.GetDsNhanVien();
        }

        private void simpleButtonLamMoi_Click(object sender, EventArgs e)
        {
            GetDSNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien_Form xoaNV = new XoaNhanVien_Form();
            xoaNV.ShowDialog();
        }
    }
}
