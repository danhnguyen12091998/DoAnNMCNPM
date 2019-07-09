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
using QuanLiBanVang.DAO;

namespace QuanLiBanVang.Report
{
    public partial class DanhSachPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {
        

 
        public DanhSachPhieuMua_Form()
        {
            InitializeComponent();
            GetDsPhieuMuaHang();


        }
        private void createTable()
        {
           
        }
        private void addNewRowToTableData()
        {
            
        }
        private void updateRowInTableData()
        {
            
        }
        private void initTableData()
        {
            

        }


        private void DanhSachPhieuMua_Form_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhapPhieuMua_Form nhapphieumua = new NhapPhieuMua_Form();
            nhapphieumua.ShowDialog();
        }
        private bool checkLegalDateChange(DateTime changetime)
        {
            DateTime current = DateTime.Now.Date;
            if (DateTime.Compare(changetime, current) < 0)
            {
                return false;
            }
            return true;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChiTietNhapPhieuMua_Form ctpmh = new ChiTietNhapPhieuMua_Form();
            ctpmh.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDsPhieuMuaHang();
        }


        void GetDsPhieuMuaHang()
        {
            dtgvPhieuMuaHang.DataSource = PhieuMuaHangDAO.Instance.GetDsPhieuMuaHang();
        }
        private void barButtonItemCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUpdate_Click(sender,e);
        }


        private void dgvBuyBill_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                popupMenu1.ShowPopup(MousePosition);
        }


    }
}