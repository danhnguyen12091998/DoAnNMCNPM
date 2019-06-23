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
    public partial class SuaPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {
        private ExtendClass.MyCache _myCache;

        
        public SuaPhieuMua_Form()
        {
            InitializeComponent();
           
        }
        public SuaPhieuMua_Form(int id)
        {

            InitializeComponent();
            

        }

        public void createTable()
        {
           
            
        }
        public void addNewRowToDataTable()
        {
          
        }
        
        private void SuaPhieuMua_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvBuy_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                e.Value = _myCache.getValue(e.Row);
            }
            if (e.IsSetData)
            {
                _myCache.setValue(e.Row, e.Value);
            }
        }

        private void rdoClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdoClientType.SelectedIndex == 0)
            {
                this.cboClientName.Enabled = false;
                this.lblPhoneNumber.Text = "(Không có)";
            }
            else
            {
                this.cboClientName.Enabled = true;
                //this.lblPhoneNumber.Text = ((this.cboClientName.SelectedItem as ExtendClass.ContainerItem).Value as DTO.KHACHHANG).SDT;
            }
        }
        private bool checkLegalDetail()
        {
            if (txtPrice.Text == "")
                return false;
            if (txtPrice.Text == "")
                return false;
            if (txtQuantity.Text == "")
                return false;
            if (this.dtpkCreateDate.EditValue.ToString() == "")
                return false;
            if (this.rdoClientType.SelectedIndex == 1)
            {
                if (this.cboClientName.SelectedItem == null)
                    return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void cboProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}