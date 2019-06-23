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
    public partial class NhapPhieuMua_Form : DevExpress.XtraEditors.XtraForm
    {
       // private DataColumn _keyField;
       
        public NhapPhieuMua_Form()
        {
            InitializeComponent();
           
        }
        public NhapPhieuMua_Form(int staffid)
        {
            InitializeComponent();
            
        }
        public void createTable()
        {
           
        }
        public void addNewRowToDataTable()
        {
            
        }
        private void dgvBuy_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
        }

        private void rdoClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void NhapPhieuMua_Form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void cboClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}