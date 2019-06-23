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

using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.Model;

using System.Collections.ObjectModel;

namespace QuanLiBanVang.Form
{

    public partial class PhieuNhapHang_Form : DevExpress.XtraEditors.XtraForm
    {
        

        public PhieuNhapHang_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// member constructor
        /// </summary>
        /// <param name="type"> identify user's intention : view or create new one </param>
        /// <param name="data"> null if the Action Type is null. Otherwise , data will be not null to show to user</param>

        /// <summary>
        /// 
        /// do things when load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhieuNhapHang_Load(object sender, EventArgs e)
        {

        }
        private void comboBoxEditLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        /// <summary>
        /// save this import receit into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        #region ------------------------- PRIVATE METHOD ---------------------------------------
        /// <summary>
        /// check wheather content of view components is valid or not 
        /// </summary>
        /// <returns>
        /// true if all content is valid. Otherwise , return false
        /// </returns>
        

        /// <summary>
        /// check whether general information of this receipt is valid
        /// </summary>
        /// <returns>
        /// true if information is valid, otherwise , return false;
        /// </returns>
        


        private void updateTotal()
        {

            
        }


        private void updateItemFromDelegate(ImportItemGridViewDataSource item)
        {
            
        }
        /// <summary>
        /// show detail of an existed PHIEUNHAPHANG
        /// </summary>
        /// <param name="data"> desired PHIEUBANHANG to be shown detal</param>
        private void showExistingImportDetail()
        {
            

        }
        #endregion

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        /// <summary>
        ///  add new record into gridview, as well as add new item of the list to be saved into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(this.dateTimePickerNgayNhap.DateTime.Date, DateTime.Now.Date) < 0)
            {
                MessageBox.Show(ErrorMessage.TODAY_ONLY_FOR_SELLING_DATE, ErrorMessage.ERROR_MESSARE_TITLE,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateTimePickerNgayNhap.DateTime = DateTime.Now;
            }
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            
        }


        private void renameColumnsOfGridControl(ActionType actionType)
        {
            if (actionType == ActionType.ACTION_CREATE_NEW)
            {
                this.gridViewDanhSachSanPham.Columns[0].Caption = "Số TT";
                this.gridViewDanhSachSanPham.Columns[1].Caption = "Loại sản phẩm";
                this.gridViewDanhSachSanPham.Columns[2].Caption = "Mã sản phẩm";
                this.gridViewDanhSachSanPham.Columns[3].Caption = "Tên sản phẩm";
                this.gridViewDanhSachSanPham.Columns[4].Caption = "Số lượng";
                this.gridViewDanhSachSanPham.Columns[5].Caption = "Giá mua";
                this.gridViewDanhSachSanPham.Columns[6].Caption = "Thành tiền";
            }
            else
            {
                this.gridViewDanhSachSanPham.Columns[0].Caption = "Số phiếu nhập";
                this.gridViewDanhSachSanPham.Columns[1].Caption = "Mã sản phẩm";
                this.gridViewDanhSachSanPham.Columns[2].Caption = "Số lượng";
                this.gridViewDanhSachSanPham.Columns[3].Caption = "Giá mua";
                this.gridViewDanhSachSanPham.Columns[4].Caption = "Thành tiền";
            }
        }
    }
}