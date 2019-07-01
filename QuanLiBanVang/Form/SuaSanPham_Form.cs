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
using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.DAO;
using QuanLiBanVang.DTO;

namespace QuanLiBanVang.Report
{
    public partial class SuaSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaSanPham_Form()
        {
            InitializeComponent();
            GetMaLoaiSP();
            
        }
        
        private void SuaSanPham_Form_Load(object sender, EventArgs e)
        {
           
        }
        public bool CheckControlValidation()
        {
            if (this.txtTenSP.Text == "")
                return false;
            if (this.txtSoLuong.Text == "")
                return false;
            if (this.cbMaLoaiSP.SelectedIndex == -1)
                return false;
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string maSanPham = txtMaSP.Text;
            string tenSanPham = txtTenSP.Text;
            string maLoaiSanPham = cbMaLoaiSP.Text;
            float donGiaMuaVao = float.Parse(txtDonGiaMuaVao.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            float phanTramLoiNhuan = LoaiSanPhamDAO.Instance.GetPhanTramLoiNhuan(maLoaiSanPham);
            float donGiaBanRa = donGiaMuaVao + (donGiaMuaVao * phanTramLoiNhuan);

            if(SanPhamDAO.Instance.SuaSanPham(maSanPham,tenSanPham,maLoaiSanPham,donGiaMuaVao,soLuong,donGiaBanRa))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công !");
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật sản phẩm !");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
        void GetMaLoaiSP()
        {
            List<LoaiSanPhamDTO> listMaLoaiSP = LoaiSanPhamDAO.Instance.GetDsLoaiSanPham();
            cbMaLoaiSP.DataSource = listMaLoaiSP;
            cbMaLoaiSP.DisplayMember = "maLoaiSP";
        }
        private void cboProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}