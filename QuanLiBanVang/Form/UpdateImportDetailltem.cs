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

using QuanLiBanVang.ExtendClass;


namespace QuanLiBanVang.Form
{
    public partial class UpdateImportDetailltem : DevExpress.XtraEditors.XtraForm
    {
        // updated
        public delegate void SendBackDataDelegate(ImportItemGridViewDataSource data); // delegate to transfer data back to parent form
        public SendBackDataDelegate sendBack;
        private int Stt;
        private int LIMIT_NUMBER_OF_IMPORT_PROFUCTS;
        public UpdateImportDetailltem()
        {
            InitializeComponent();
        }

        public UpdateImportDetailltem(ImportItemGridViewDataSource argument, int indexOfRow)
        {
            this.InitializeComponent();
            this.Stt = indexOfRow;
            /**
            * start to load list product types and coresponding prodcuts from database into view component(ComboBox Edit)
            * 
            */
            // load product types from database
        }   
        private void UpdateImportDetailltem_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEditLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// check wheather content of view components is valid or not 
        /// </summary>
        /// <returns>
        /// true if all content is valid. Otherwise , return false
        /// </returns>
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_OK_Click(object sender, EventArgs e)
        {
            
        }
    }
}