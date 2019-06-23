using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using QuanLiBanVang.ExtendClass;

using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class NhapPhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
       
        public NhapPhieuDichVu()
        {
            InitializeComponent();
                
        }
        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadEmployeeName()
        {
           
        }
        private void AddDichVuToComboBoxEdit()
        {
            
        }
        private void AddLoaiSpToComboBoxEdit()
        {
            
        }
        private void AddKhachHangToComboEdit()
        {
            
        }
        private void ClearAllItemInComboboxKh()
        {
            
        }
        private void checkEditKhachQuen_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void gridViewCT_PDV_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
           
        }
        private void CreateDataTable()
        {
            
        }
        private void comboBoxEditTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {            
                  
        }
        private void textEditSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }
        private void CalculateThanhTien()
        {
            int tiencong = Int32.Parse(string.IsNullOrEmpty(textEditTienCong.Text)? "0": textEditTienCong.Text);
            int soluong = Int32.Parse(string.IsNullOrEmpty(textEditSoLuong.Text)? "0" : textEditSoLuong.Text);
            textEditThanhTien.Text = (tiencong * soluong).ToString();
        }
        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            
        }
        private void CalculateTongTien()
        {
           
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void NhapPhieuDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textEditTienCong_EditValueChanged_1(object sender, EventArgs e)
        {
            CalculateThanhTien();
        }

        private void comboBoxEditTenKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}