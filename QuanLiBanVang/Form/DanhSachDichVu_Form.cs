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


namespace QuanLiBanVang
{
    public partial class DanhSachDichVu : DevExpress.XtraEditors.XtraForm
    {
       

        public DanhSachDichVu()
        {
            InitializeComponent();
            GetDSDichVu();

        }
        private void CreateDataTable()
        {
           
        }

        private void FillGridView()
        {
            
        }       

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            NhapDichVu_Form nhapDV = new NhapDichVu_Form();
            nhapDV.ShowDialog();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            SuaDichVu_Form suaDV = new SuaDichVu_Form();
            suaDV.ShowDialog();
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
        

        
        private void barButtonItemCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            simpleButtonDel_Click(sender,e);
        }

        private void simpleButtonLamMoi_Click(object sender, EventArgs e)
        {
            GetDSDichVu();
        }

        private void GetDSDichVu()
        {
            dtgvDichVu.DataSource = DichVuDAO.Instance.GetDsLoaiSanPham();
        }

        
    }
}