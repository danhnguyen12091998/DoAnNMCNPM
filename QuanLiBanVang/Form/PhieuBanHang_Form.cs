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

using System.Collections.ObjectModel;
using QuanLiBanVang.ExtendClass;
using System.Collections;
using QuanLiBanVang.Form;
using QuanLiBanVang.Model;
using QuanLiBanVang.model;
using System.Data.Entity;


namespace QuanLiBanVang
{
    public partial class PhieuBanHang : DevExpress.XtraEditors.XtraForm
    {

      


        public PhieuBanHang()
        {
            InitializeComponent();
        }

       
        private void PhieuBanHang_Load(object sender, EventArgs e)
        {

        }


        private void onReceiveFrequenter()
        {
            
        }

        /*
         * before adding new record into grid control , data must be check to be valid
         * 
         * */
        


        


        /// <summary>
        /// Update value of DonGia texfield corresponding to product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEditMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void gridControl1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        ///<summary>
        ///save all data into database
        ///</summary>
        ///<notice>
        /// Have to check all data before invoking this method
        ///</notice>
        private void saveReceiptIntoDatabase()
        {
           
        }

        /// <summary>
        /// udpate value of receipt total
        /// </summary>
        private void updateTotal()
        {
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            
        }


        //
        // reset all text in box
        //
        private void resetEditText()
        {
            this.comboBoxEditMaLoaiSp.Text = string.Empty;
            this.comboBoxEditMaLoaiSp.Text = string.Empty;
            this.textEditSoLuong.Text = string.Empty;
            this.textEditDonGia.Text = string.Empty;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridViewDanhSachSanPham.SelectedRowsCount == 0 || this.gridViewDanhSachSanPham.SelectedRowsCount > 1) { return; }
            // get value from selected row
            DetailGridViewDataSource item = (DetailGridViewDataSource)this.gridViewDanhSachSanPham.GetRow(this.gridViewDanhSachSanPham.FocusedRowHandle);

            // start to show the update form
            UpdateDetaiItem updateDetailItemForm = new UpdateDetaiItem(item);
            updateDetailItemForm.sendBackDelegate = new UpdateDetaiItem.onDataSendBack(this.updateDetailItemDelegate); // instance a delegate for form
            updateDetailItemForm.ShowDialog();
        }

        // delegate function
        private void updateDetailItemDelegate(DetailGridViewDataSource arg)
        {
            
        }

        // <summary>
        // background work saving data into database
        //</summary>
        private void databaseSavingBackgrounWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.saveReceiptIntoDatabase();
        }

        private void databaseSavingBackgrounWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        /// <summary>
        /// incase user want to see the details of existed receipt
        /// Disable all views that should not be modified
        /// </summary>
        /// <param name="data">PHIEUBANHANG from database</param>
        //private void viewExistedDetail(PHIEUBANHANG data)
        //{

            
        //}



        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Show form containing list of frequenters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonTimKhachQuen_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonLapPhieuNo_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_Huy_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Luu_Click(object sender, EventArgs e)
        {
            

        }

        private void checkEditKhachQuen_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        // show form containing list of frequenters for staff to choose 
        private void simpleButtonTimKhachQuen_Click_1(object sender, EventArgs e)
        {
            
        }

        // insert new item into user's cart
        private void simpleButtonThem_Click_1(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// load all products corresponding to product type that user selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEditMaLoaiSp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void comboBoxEditMaSp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Make sure that the selling date has to be today
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerNgayBan_EditValueChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Make sure that the payment date has to be greater than the selling date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerNgayThanhToan_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// Rename griview column's captions to be semantic
        /// </summary>
        private void renameColumnsOfGridControl()
        {

        }

    }

}