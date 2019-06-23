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
    public partial class DanhSachPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {
        

 
        public DanhSachPhieuMua_Form()
        {
            InitializeComponent();
            
        }
        public DanhSachPhieuMua_Form(int staffid)
        {
            InitializeComponent();
            
            
            
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
        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DataRow row = null;
        //    int pos = -1;
        //    foreach (int i in this.dgvBuyBill.GetSelectedRows())
        //    {
        //        pos = i;
        //        row = this.dgvBuyBill.GetDataRow(i);
        //        break;
        //    }
        //    if (row != null)
        //    {
        //        if (this.checkLegalDateChange(((DateTime)row[3]).Date) == true)
        //        {
        //            this.dgvBuyBill.DeleteRow(pos);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không thể xóa phiếu khác ngày hiện tại!");
        //            return;
        //        }
        //    }
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
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