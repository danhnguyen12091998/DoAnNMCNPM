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

namespace QuanLiBanVang.Report
{
    public partial class DanhSachPhieuChi_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public DanhSachPhieuChi_Form()
        {
            InitializeComponent();
           
        }
        private void createTable()
        {
            
            

        }
        private void initTableData()
        {
            
        }
        private void addNewRowToDataTable()
        {
            
        }
        private void updateRowInDataTable()
        {
           
        }
        private void dgvPaymentBill_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void DanhSachPhieuChi_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPaymentBill_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                popupMenu1.ShowPopup(MousePosition);
        }

        private void barButtonItemCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUpdate_Click(sender,e);
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDelete_Click(sender,e);
        }
        

    }
}