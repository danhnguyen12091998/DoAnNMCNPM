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
using System.Data.Entity;
using QuanLiBanVang.Model;
namespace QuanLiBanVang.Form
{
    public partial class DanhSachNhaCungCap_Form : DevExpress.XtraEditors.XtraForm
    {
        // database context

        public DanhSachNhaCungCap_Form()
        {
            InitializeComponent();
            
            // start to get all providers from database and binding into the view list
        }

        private void DanhSachNhaCungCap_Load(object sender, EventArgs e)
        {
            this.renameColumnsOfGridView();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            
        }


        private void renameColumnsOfGridView()
        {
            
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}