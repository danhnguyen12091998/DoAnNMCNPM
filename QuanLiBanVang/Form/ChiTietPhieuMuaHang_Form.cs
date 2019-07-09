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
    public partial class ChiTietNhapPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {


        public ChiTietNhapPhieuMua_Form()
        {
            InitializeComponent();
                       
        }       
                   
        private void NhapPhieuMua_Form_Load(object sender, EventArgs e)
        {

        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }                        

        void ShowDSCTPMH(string SoPMH)
        {
            dtgvCTPMH.DataSource = ChiTietPhieuMuaHangDAO.Instance.GetChiTietPhieuMuaHang(SoPMH);
        }

             

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string SoPMH = txtSoPMH.Text;      
            string MaNCC = PhieuMuaHangDAO.Instance.GetNCC(SoPMH);
            txtNgayLap.Text = PhieuMuaHangDAO.Instance.GetNgayLap(SoPMH);
            txtNCC.Text = NhaCungCapDAO.Instance.GetTenNCC(MaNCC);
            txtDiaChi.Text = NhaCungCapDAO.Instance.GetDiaChiNCC(MaNCC);
            txtSDT.Text = NhaCungCapDAO.Instance.GetSDTNCC(MaNCC);
            txtTongTien.Text = PhieuMuaHangDAO.Instance.GetTongTien(SoPMH);
            ShowDSCTPMH(SoPMH);
        }
    }
 
}