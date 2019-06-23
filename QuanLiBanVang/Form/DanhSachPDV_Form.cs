using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class DanhSachPDV : XtraForm
    {
        
        public DanhSachPDV()
        {
            InitializeComponent();
            GetDataNvAndKh();
            CreateDataTable();
        }
        private void CreateDataTable()
        {
            
        }

        private void GetDataNvAndKh()
        {
           
        }
        
        private void FillDataTable()
        {

        }
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            OpenEditDialog();            
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewDSPDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
        }

        private void gridViewDSPDV_DoubleClick(object sender, EventArgs e)
        {
            OpenEditDialog();  
        }
        private void OpenEditDialog()
        {
            
        }

        private void DanhSachPDV_Load(object sender, EventArgs e)
        {
            FillDataTable();
        }

        private void DanhSachPDV_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void gridViewDSPDV_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenEditDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            simpleButtonDel_Click(sender,e);
        }

        private void simpleButtonLamMoi_Click(object sender, EventArgs e)
        {
            FillDataTable();
        }
    }
}