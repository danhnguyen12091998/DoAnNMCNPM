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
using QuanLiBanVang.DAO;

namespace QuanLiBanVang.Report
{
    public partial class Login_Form : DevExpress.XtraEditors.XtraForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }


        private void Login_Form_Load(object sender, EventArgs e)
        {


        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserID.Text;
            string password = txtPassword.Text;
            if (Login(username,password))
            {
                MainForm f = new MainForm();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }
        }

        bool Login(string username, string password)
        {
            return NhanVienDAO.Instance.Login(username, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void Login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}