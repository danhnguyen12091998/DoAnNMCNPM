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
using QuanLiBanVang.Model;
using QuanLiBanVang.DAO;

namespace QuanLiBanVang.Form
{
    public partial class NhapTenMayTinh_Form : DevExpress.XtraEditors.XtraForm
    {

        public NhapTenMayTinh_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ComputerName = txtComputerName.Text;
            DataProvider.Instance.SetConnectionString(ComputerName);
            this.Close();
        }
    }
}