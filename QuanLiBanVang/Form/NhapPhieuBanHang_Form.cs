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
            if (CheckValueCTPBH() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cho chi tiết của phiếu bán hàng !");
                return;
            }
            else
            {
                string MaCT_PBH = txtMaCTPBH.Text;
                string SoPhieuBanHang = txtSoPhieuBanHang.Text;
                string MaSanPham = GetMaSanPham();
                int SoLuong = int.Parse(txtSL.Text);
                float DonGiaBanRa = float.Parse(txtDonGia.Text);
                float ThanhTien = DonGiaBanRa * SoLuong;
                if (ChiTietPhieuBanHangDAO.Instance.CheckMaCT_PBH(MaCT_PBH) == false)
                {

                    if (ChiTietPhieuBanHangDAO.Instance.ThemChiTietPhieuBanHang(MaCT_PBH, SoPhieuBanHang, MaSanPham, SoLuong, DonGiaBanRa, ThanhTien))
                    {
                        MessageBox.Show("Thêm một sản phẩm thành công !");
                        GetTongTienCuaPBH(SoPhieuBanHang);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm sản phẩm vào phiếu bán hàng !");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng chi tiết phiếu bán hàng, vui lòng kiểm tra lại !");
                }
            }

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

        string GetMaSanPham()
        {
            string MASP = null;

            SanPhamDTO selected = cboTenSP.SelectedItem as SanPhamDTO;

            MASP = selected.MaSanPham;
            return MASP;
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


        bool CheckValuePhieuBanHang()
        {
            if (txtSoPhieuBanHang.Text == "") return false;
            if (txtTenKH.Text == "") return false;
            return true;
        }

        bool CheckValueCTPBH()
        {
            if (txtMaCTPBH.Text == "") return false;
            if (txtSL.Text == "") return false;
            return true;
        }
        void GetDanhSachChiTietPhieuBanHang(string soPhieuBanHang)
        {
            dtgvChiTietPBH.DataSource = ChiTietPhieuBanHangDAO.Instance.GetChiTietPhieuBanHang(soPhieuBanHang);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string SoPBH = txtSoPhieuBanHang.Text;
            GetDanhSachChiTietPhieuBanHang(SoPBH);
            txtTongTien.Text = ChiTietPhieuBanHangDAO.Instance.GetTongTien(SoPBH);
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void txtSL_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhieuBanHang_Click(object sender, EventArgs e)
        {

            if (CheckValuePhieuBanHang() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu bán hàng !");
                return;
            }
            else
            {
                string SoPBH = txtSoPhieuBanHang.Text;
                DateTime NgayLap = dateTimePickerNgayBan.Value;
                string KH = txtTenKH.Text;
                float TongTien = 0;

                if (PhieuBanHangDAO.Instance.CheckSoPBH(SoPBH) == false)
                {

                    if (PhieuBanHangDAO.Instance.ThemPhieuBanHang(SoPBH, NgayLap, KH, TongTien))
                    {
                        MessageBox.Show("Thêm Phiếu bán hàng thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm phiếu bán hàng !");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng số phiếu bán hàng, vui lòng kiểm tra lại !");
                }

            }


        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            string MaCT_PBH = txtMaCTPBH.Text;
            string MaSanPham = GetMaSanPham();
            int SoLuong = int.Parse(txtSL.Text);
            float DonGiaBanRa = float.Parse(txtDonGia.Text);
            float ThanhTien = DonGiaBanRa * SoLuong;
            if (ChiTietPhieuBanHangDAO.Instance.CheckMaCT_PBH(MaCT_PBH) == true)
            {
                if (ChiTietPhieuBanHangDAO.Instance.CapNhatChiTietPhieuMuaHang(MaCT_PBH, MaSanPham, SoLuong, DonGiaBanRa, ThanhTien))
                {
                    MessageBox.Show("Cập nhật chi tiết phiếu bán hàng thành công !");
                }

                else
                {
                    MessageBox.Show("Có lỗi trong quá trình cập nhật chi tiết phiếu bán hàng ! ");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu bán hàng cần sửa !");
            }
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            string MaCT_PBH = txtMaCTPBH.Text;
            if(ChiTietPhieuBanHangDAO.Instance.CheckMaCT_PBH(MaCT_PBH)==true)
            {
                if(ChiTietPhieuBanHangDAO.Instance.XoaChiTietPhieuMuaHang(MaCT_PBH))
                {
                    MessageBox.Show("Xóa chi tiết phiếu bán hàng thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa chi tiết phiếu bán hàng !");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu bán hàng cần xóa !");
            }
        }

        void GetTongTienCuaPBH(string SoPBH)
        {
            txtTongTien.Text = ChiTietPhieuBanHangDAO.Instance.GetTongTien(SoPBH);
        }

        private void simpleButton_Luu_Click(object sender, EventArgs e)
        {
            string SoPBH = txtSoPhieuBanHang.Text;
            DateTime NgayLap = dateTimePickerNgayBan.Value;
            string KH = txtTenKH.Text;
            float TT = float.Parse(txtTongTien.Text);

            PhieuBanHangDAO.Instance.CapNhatPhieuBanHang(SoPBH, NgayLap, KH, TT);
            this.Close();
        }
    }
}
