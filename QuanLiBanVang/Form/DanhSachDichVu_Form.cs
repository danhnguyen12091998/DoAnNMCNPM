using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class DanhSachDichVu : DevExpress.XtraEditors.XtraForm
    {
       

        public DanhSachDichVu()
        {
            InitializeComponent();
            
        }
        private void CreateDataTable()
        {
           
        }

        private void FillGridView()
        {
            
        }       

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void OpenEditDialog()
        {
            
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewDSDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

        }
        private void gridViewDSDV_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonEdit_Click(sender,e);
        }

        private void gridViewDSDV_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

        }
        private void barButtonItemCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            simpleButtonDel_Click(sender,e);
        }

        private void simpleButtonLamMoi_Click(object sender, EventArgs e)
        {
            FillGridView();
        }
    }
}