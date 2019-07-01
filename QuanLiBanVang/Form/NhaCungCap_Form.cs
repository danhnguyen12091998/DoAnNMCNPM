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
    public partial class NhaCungCap_Form : DevExpress.XtraEditors.XtraForm
    {

        public NhaCungCap_Form()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string MaNCC = txtMaNCC.Text;
            string TenNCC = txtTenNCC.Text;
            string DiaChi = txtDiaChiNCC.Text;
            string SDT = txtSDTNCC.Text;


            if (NhaCungCapDAO.Instance.CheckMaNCC(MaNCC) == false)
            {

                if (NhaCungCapDAO.Instance.ThemNhaCungCap(MaNCC, TenNCC, DiaChi, SDT))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm nhà cung cấp !");
                    this.Close();
                }

            }

            else
            {
                MessageBox.Show("Trùng mã nhà cung cấp !");
                this.Close();
            }


        }
        

        private void NhaCungCap_Form_SizeChanged(object sender, EventArgs e)
        {
            groupControl1.Left = (ClientSize.Width - groupControl1.Width) / 2;
            simpleButtonThoat.Left = groupControl1.Right - simpleButtonLuu.Width;
            simpleButtonLuu.Left = simpleButtonThoat.Left - simpleButtonLuu.Width - 10;
        }

        private void textEditMaNCC_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}