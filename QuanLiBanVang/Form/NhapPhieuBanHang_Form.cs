using QuanLiBanVang.DAO;
using QuanLiBanVang.DTO;
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
    public partial class NhapPhieuBanHang_Form : DevExpress.XtraEditors.XtraForm
    {
        public NhapPhieuBanHang_Form()
        {
            InitializeComponent();
            GetTenLoaiSP();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            DateTime ngayBan = dateTimePickerNgayBan.Value;
        }


        private void cboMaLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MALOAISP = null;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            LoaiSanPhamDTO selected = cb.SelectedItem as LoaiSanPhamDTO;

            MALOAISP = selected.MaLoaiSP;

            GetTenSP(MALOAISP);
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            SanPhamDTO selected = cb.SelectedItem as SanPhamDTO;

            txtDonGia.Text = selected.DonGiaBanRa.ToString();
            txtDonGia.Show();
        }
        void GetTenLoaiSP()
        {
            List<LoaiSanPhamDTO> listMaLoaiSP = LoaiSanPhamDAO.Instance.GetDsLoaiSanPham();
            cboMaLoaiSp.DataSource = listMaLoaiSP;
            cboMaLoaiSp.DisplayMember = "tenLoaiSP";

        }

        void GetTenSP(string maLoaiSP)
        {
            List<SanPhamDTO> listSanPham = SanPhamDAO.Instance.GetListTenSPDuaTrenMaLoaiSP(maLoaiSP);
            cboTenSP.DataSource = listSanPham;
            cboTenSP.DisplayMember = "tenSanPham";
        }


    }
}
