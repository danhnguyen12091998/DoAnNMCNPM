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
using QuanLiBanVang.Form;

namespace QuanLiBanVang.Report
{
    public partial class DanhSachLoaiSanPham_Form : DevExpress.XtraEditors.XtraForm
    {

        public DanhSachLoaiSanPham_Form()
        {
            InitializeComponent();
            LoadDanhSachSanPham();
        }

        private void createTable()
        {
           
        }
        private void addNewRowToDataTable()
        {
           
        }
        private void updateRowInDatatable()
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
            NhapLoaiSanPham_Form nhapLoaiSP = new NhapLoaiSanPham_Form();
            nhapLoaiSP.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            XoaLoaiSanPham xoaLoaiSP = new XoaLoaiSanPham();
            xoaLoaiSP.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SuaLoaiSanPham_Form suaLoaiSP = new SuaLoaiSanPham_Form();
            suaLoaiSP.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDanhSachSanPham();
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


        #region Method

        void LoadDanhSachSanPham()
        {
            dtgvLoaiSanPham.DataSource = LoaiSanPhamDAO.Instance.GetDsLoaiSanPham();
        }

        #endregion

        private void dtgvLoaiSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}