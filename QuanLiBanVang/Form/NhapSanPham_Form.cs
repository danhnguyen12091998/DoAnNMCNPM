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
using QuanLiBanVang.DTO;
using QuanLiBanVang.DAO;

namespace QuanLiBanVang.Report
{
    public partial class NhapSanPham_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public NhapSanPham_Form()
        {
            InitializeComponent();
            GetMaLoaiSP();           
        }

        void GetMaLoaiSP()
        {
            List<LoaiSanPhamDTO> listMaLoaiSP = LoaiSanPhamDAO.Instance.GetDsLoaiSanPham();
            cbMaLoaiSP.DataSource = listMaLoaiSP;
            cbMaLoaiSP.DisplayMember = "maLoaiSP";
        }

        public bool CheckControlValidation()
        {
            if (this.txtTenSP.Text == "")
                return false;
            if (this.txtSL.Text == "")
                return false;
            if (this.cbMaLoaiSP.SelectedIndex == -1)
                return false;
            return true;
        }
        private void Clear()
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string maSanPham = txtMaSP.Text;
            string tenSanPham = txtTenSP.Text;
            string maLoaiSanPham = cbMaLoaiSP.Text;
            float donGiaMuaVao = float.Parse(txtDonGiaMuaVao.Text);
            int soLuong = int.Parse(txtSL.Text);
            float phanTramLoiNhuan = LoaiSanPhamDAO.Instance.GetPhanTramLoiNhuan(maLoaiSanPham);
            float donGiaBanRa = donGiaMuaVao + (donGiaMuaVao * phanTramLoiNhuan);

            if(SanPhamDAO.Instance.ThemSanPham(maSanPham,tenSanPham,maLoaiSanPham,donGiaMuaVao,soLuong,donGiaBanRa))
            {
                MessageBox.Show("Thêm sản phẩm thành công !");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm mới loại sản phẩm !");
            }
        }

        private void NhapSanPham_Form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void NhapSanPham_Form_SizeChanged(object sender, EventArgs e)
        {
            groupControlInfo.Left = (ClientSize.Width - groupControlInfo.Width) / 2;
            btnCancel.Left = groupControlInfo.Right - btnSave.Width;
            btnSave.Left = btnCancel.Left - btnSave.Width - 10; 
        }

        private void cboProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}