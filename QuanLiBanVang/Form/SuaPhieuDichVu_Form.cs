using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using QuanLiBanVang.ExtendClass;

using QuanLiBanVang.Properties;

namespace QuanLiBanVang
{
    public partial class SuaPhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
        
        public SuaPhieuDichVu(int soPdv)
        {
            InitializeComponent();
            
        }
        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            
            checkEditKhachQuen.ReadOnly = true;
            AddDichVuToComboBoxEdit();
            AddLoaiSpToComboBoxEdit();
            CreateDataTable();
            LoadInfoPdv();        
        }
        private void LoadInfoPdv()
        {
            
        }
        private void LoadInfoCtpdv()
        {
            
        }
        private void LoadEmployeeName(int maNv)
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
            //if (checkEditKhachQuen.Checked){
            //    comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //    AddKhachHangToComboEdit();
            //    comboBoxEditTenKhach.SelectedIndex = -1;
            //}
            //else
            //{
            //    comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.Standard;
            //    ClearAllItemInComboboxKh();           
            //}
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
            decimal tiencong = Int32.Parse(textEditTienCong.Text == "" ? "0" : textEditTienCong.Text);
            decimal soluong = Int32.Parse(textEditSoLuong.Text == "" ? "0" : textEditSoLuong.Text);
            textEditThanhTien.Text = (tiencong * soluong).ToString();
        }
        private bool CheckLogicError()
        {
            if (comboBoxEditLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.NhapPhieuDichVu_LoaiSPEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditLoaiSP.Focus();
                return false;
            }
            if (comboBoxEditTenDV.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.NhapDichVu_TenDVEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxEditTenDV.Focus();
                return false;
            }
            if (textEditSoLuong.Text == "" || Int32.Parse(textEditSoLuong.Text) == 0)
            {
                MessageBox.Show(Resources.NhapPhieuDichVu_SoLuongEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEditSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textEditHTGC.Text) && comboBoxEditTenDV.Text.Equals("Gia công"))
            {
                MessageBox.Show(Resources.NhapPhieuDichVu_HTGCEmpty, Resources.TitleMessageBox_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEditHTGC.Focus();
                return false;
            }
            return true;
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

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            
        }

        private void gridViewCT_PDV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
        }

        private void dateEditNgayGiao_EditValueChanged(object sender, EventArgs e)
        {
            //if (dateEditNgayGiao.DateTime != _pdv.NgayGiao)
            //    simpleButtonOK.Enabled = true;
            //else
            //    simpleButtonOK.Enabled = false;
        }

        private void textEditTienCong_EditValueChanged(object sender, EventArgs e)
        {
            CalculateThanhTien();
        } 
    }
}