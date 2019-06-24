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
using QuanLiBanVang.Model;
using System.Data.Entity;

namespace QuanLiBanVang.Form
{
    public partial class DanhSachPhieuBanHang_Form : DevExpress.XtraEditors.XtraForm
    {
        
        public DanhSachPhieuBanHang_Form()
        {
            InitializeComponent();
        }

        private void DanhSachPhieuBanHang_Load(object sender, EventArgs e)
        {

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void simpleButtonChiTiet_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            this.refresh();
        }


        private void refresh()
        {
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            simpleButtonChiTiet_Click(sender,e);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            simpleButtonChiTiet_Click(sender,e);
        }
    }
}