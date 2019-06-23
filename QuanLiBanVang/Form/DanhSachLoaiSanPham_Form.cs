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
    public partial class DanhSachLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {

        private void createTable()
        {
           
        }
        private void addNewRowToDataTable()
        {
           
        }
        private void updateRowInDatatable()
        {
           


        }
        public DanhSachLoaiSanPham_Form()
        {
            
            
        }

        private void gridViewProductType_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
           
        }
        private void initTableData()
        {
            
        }
        private void DanhSachLoaiSanPham_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItemCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDelete_Click(sender,e);
        }

        private void dgvProductType_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
           
        }

        private void dgvListProductType_Click(object sender, EventArgs e)
        {

        }
    }
}