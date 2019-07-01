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
    public partial class DanhSachNhaCungCap_Form : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachNhaCungCap_Form()
        {
            InitializeComponent();
            LoadDSNCC();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            NhaCungCap_Form NCC = new NhaCungCap_Form();
            NCC.ShowDialog();
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            SuaNhaCungCap_Form SuaNCC = new SuaNhaCungCap_Form();
            SuaNCC.ShowDialog();
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadDSNCC();
        }

        private void LoadDSNCC()
        {
            dtgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.GetDsNCC();
        }

        private void dtgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
