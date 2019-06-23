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

namespace QuanLiBanVang.Form
{
    public partial class NhaCungCap_Form : DevExpress.XtraEditors.XtraForm
    {

        // datbase context
        public NhaCungCap_Form()
        {
            InitializeComponent();
        }


        //public NhaCungCap_Form(ActionType type, NHACUNGCAP data)
        //{
            
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// make sure all contents from view is valid(not null or empty or existed from database)
        /// </summary>
        /// <returns>
        /// true if all contents are valid. Otherwise, returns false
        /// </returns>
        //private bool isValidInformation()
        //{
            
        //}
        /// <summary>
        /// save new provider into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Set up data for viewing existed provider from database
        /// and disable all essential view components to prevent user from modifying data
        /// </summary>
        /// <param name="data"> data to be filled in the view</param>
        //private void viewActionType(NHACUNGCAP data)
        //{
            
        //}

        //private void updateProviderActionType(NHACUNGCAP argument)
        //{
            
        //}

        private void NhaCungCap_Form_SizeChanged(object sender, EventArgs e)
        {
            groupControl1.Left = (ClientSize.Width - groupControl1.Width) / 2;
            simpleButtonThoat.Left = groupControl1.Right - simpleButtonLuu.Width;
            simpleButtonLuu.Left = simpleButtonThoat.Left - simpleButtonLuu.Width - 10;
        }

        private void textEditMaNCC_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}