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
using QuanLiBanVang.DTO;
using QuanLiBanVang.DAO;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QuanLiBanVang.Report
{
    public partial class NhapPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {


        public NhapPhieuMua_Form()
        {
            InitializeComponent();
            GetTenNCC();
            GetTenLoaiSP();           
        }
        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
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

            SanPhamDTO selected = cboSanPham.SelectedItem as SanPhamDTO;

            MASP = selected.MaSanPham;
            return MASP;
        }
        string GetMaNhaCungCap()
        {
            string MANCC = null;

            NhaCungCapDTO selected = cboNCC.SelectedItem as NhaCungCapDTO;

            MANCC = selected.MaNhaCungCap;
            return MANCC;
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            SanPhamDTO selected = cb.SelectedItem as SanPhamDTO;

            txtDonGia.Text = selected.DonGiaMuaVao.ToString();

            txtDonGia.Show();
        }


        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            NhaCungCapDTO selected = cb.SelectedItem as NhaCungCapDTO;

            txtDiaChi.Text = selected.DiaChi;
            txtSDT.Text = selected.SoDienThoai;
        }


        void GetTenLoaiSP()
        {
            List<LoaiSanPhamDTO> listMaLoaiSP = LoaiSanPhamDAO.Instance.GetDsLoaiSanPham();
            cboLoaiSanPham.DataSource = listMaLoaiSP;
            cboLoaiSanPham.DisplayMember = "tenLoaiSP";

        }

        void GetTenSP(string maLoaiSP)
        {
            List<SanPhamDTO> listSanPham = SanPhamDAO.Instance.GetListTenSPDuaTrenMaLoaiSP(maLoaiSP);
            cboSanPham.DataSource = listSanPham;
            cboSanPham.DisplayMember = "tenSanPham";
        }

        void GetTenNCC()
        {
            List<NhaCungCapDTO> listNCC = NhaCungCapDAO.Instance.GetDsNCC();
            cboNCC.DataSource = listNCC;
            cboNCC.DisplayMember = "tenNhaCungCap";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (CheckValueCTPMH() == true)
            {
                string MaCTPMH = txtCTPMH.Text;
                string SoPMH = txtSoPMH.Text;
                string MaSP = GetMaSanPham();
                int SL = int.Parse(txtSoLuong.Text);
                float DonGiaMuaVao = float.Parse(txtDonGia.Text);
                float ThanhTien = SL * DonGiaMuaVao;
                if (ChiTietPhieuMuaHangDAO.Instance.CheckMaCT_PMH(MaCTPMH) == false)
                {
                    if (ChiTietPhieuMuaHangDAO.Instance.ThemChiTietPhieuMuaHang(MaCTPMH, SoPMH, MaSP, SL, DonGiaMuaVao, ThanhTien))
                    {
                        MessageBox.Show("Nhập chi tiết phiếu mua hàng thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm chi tiết phiếu mua hàng !");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng mã chi tiết phiếu mua hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            }

        }

        private void NhapPhieuMua_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MaCTPMH = txtCTPMH.Text;
            string SoPMH = txtSoPMH.Text;
            string MaSP = GetMaSanPham();
            int SL = int.Parse(txtSoLuong.Text);
            float DonGiaMuaVao = float.Parse(txtDonGia.Text);
            float ThanhTien = SL * DonGiaMuaVao;
            if (ChiTietPhieuMuaHangDAO.Instance.CheckMaCT_PMH(MaCTPMH) == true)
            {
                if (ChiTietPhieuMuaHangDAO.Instance.CapNhatChiTietPhieuMuaHang(MaCTPMH, SoPMH, MaSP, SL, DonGiaMuaVao, ThanhTien))
                {
                    MessageBox.Show("Cập nhật chi tiết phiếu mua hàng thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật chi tiết phiếu mua hàng !");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã chi tiết phiếu mua hàng cần cập nhật !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string SoPhieuMuaHang = txtSoPMH.Text;
            string MaNCC = GetMaNhaCungCap();
            DateTime NgayLap = dateTimePickerNgayBan.Value;
            float TongTien = float.Parse(txtTongTien.Text);

            if(PhieuMuaHangDAO.Instance.CapNhatPhieuMuaHang(SoPhieuMuaHang,NgayLap,MaNCC,TongTien))
            {
                MessageBox.Show("Thêm phiếu mua hàng thành công !");
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình lưu phiếu mua hàng !");
            }

        }       

        bool CheckValuePMH()
        {
            if (txtSoPMH.Text == "") return false;
            return true;
        }

        bool CheckValueCTPMH()
        {
            if (txtSoLuong.Text == "") return false;
            return true;
        }

        private void btnAddPMH_Click(object sender, EventArgs e)
        {
            if (CheckValuePMH() == true)
            {
                string SoPhieuMuaHang = txtSoPMH.Text;
                string MaNCC = GetMaNhaCungCap();
                DateTime NgayLap = dateTimePickerNgayBan.Value;
                float TongTien = 0;

                if (PhieuMuaHangDAO.Instance.CheckSoPMH(SoPhieuMuaHang) == false)
                {
                    if (PhieuMuaHangDAO.Instance.ThemPhieuMuaHang(SoPhieuMuaHang, NgayLap, MaNCC, TongTien))
                    {
                        MessageBox.Show("Thêm phiếu mua hàng thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm phiếu mua hàng !");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng số phiếu mua hàng !");
                }
            }

            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            }
        }

        void ShowDSCTPMH(string SoPMH)
        {
            dtgvCTPMH.DataSource = ChiTietPhieuMuaHangDAO.Instance.GetChiTietPhieuMuaHang(SoPMH);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string SoPMH = txtSoPMH.Text;
            ShowDSCTPMH(SoPMH);
            GetTongTienCuaPMH(SoPMH);

        }

        void GetTongTienCuaPMH(string SoPMH)
        {
            txtTongTien.Text = ChiTietPhieuMuaHangDAO.Instance.GetTongTien(SoPMH);
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaCTPMH = txtCTPMH.Text;
            if (ChiTietPhieuMuaHangDAO.Instance.CheckMaCT_PMH(MaCTPMH) == true)
            {
                if (ChiTietPhieuMuaHangDAO.Instance.XoaChiTietPhieuMuaHang(MaCTPMH))
                {
                    MessageBox.Show("Xóa chi tiết phiếu mua hàng thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã chi tiết phiếu mua hàng cần xóa !");
            }
        }
    }
 
}