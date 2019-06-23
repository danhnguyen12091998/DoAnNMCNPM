using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiBanVang.model;
using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.Model;

namespace QuanLiBanVang.Form
{
    public partial class UpdateDetaiItem : DevExpress.XtraEditors.XtraForm
    {
        public delegate void onDataSendBack(DetailGridViewDataSource arg);
        public onDataSendBack sendBackDelegate;
        public int STT;
        public UpdateDetaiItem()
        {
            InitializeComponent();
        }

        // member contructor
        public UpdateDetaiItem(DetailGridViewDataSource arg)
        {

            this.InitializeComponent();
            /**
             * start to load list product types and coresponding prodcuts from database into view component(ComboBox Edit)
             * 
             */
            // load product types from database
            

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    // close the form
        //    this.Close();
        //}


        private void UpdateDetaiItem_Load(object sender, EventArgs e)
        {

        }

        // listener for combobox loai SP
        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // listener for combobox SP
        private void comboBoxEditLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        /* check all input data whether is valid or not
         * returns true if all data is valid to be updated ,
         * otherwise returns false
         */
        

        private void simpleButton_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Ok_Click(object sender, EventArgs e)
        {
        }



        /* delete to transfer data from form to form*/


    }
}
