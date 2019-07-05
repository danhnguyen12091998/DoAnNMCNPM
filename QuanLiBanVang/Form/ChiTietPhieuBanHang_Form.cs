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
    public partial class ChiTietPhieuBanHang_Form : DevExpress.XtraEditors.XtraForm
    {
        public ChiTietPhieuBanHang_Form()
        {
            InitializeComponent();
        }
                
        private void btnThemPhieuBanHang_Click(object sender, EventArgs e)
        {
            string soPBH = txtSoPhieuBanHang.Text;
            XemPhieuBanHang(soPBH);
       }
    
        void XemPhieuBanHang(string SoPBH)
        {
            txtTenKH.Text = PhieuBanHangDAO.Instance.GetKH(SoPBH);
            txtNgayLap.Text = PhieuBanHangDAO.Instance.GetNgayLap(SoPBH);
            txtTongTien.Text = ChiTietPhieuBanHangDAO.Instance.GetTongTien(SoPBH);
            dtgvChiTietPBH.DataSource = ChiTietPhieuBanHangDAO.Instance.GetChiTietPhieuBanHang(SoPBH);
;

        }

        private void simpleButton_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
