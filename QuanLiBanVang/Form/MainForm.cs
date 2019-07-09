using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiBanVang.Form;
using QuanLiBanVang.Model;

namespace QuanLiBanVang
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        [System.STAThread]
        public static void ThreadProcess()
        {
            Application.Run(new MainForm());
        }
  
        private void InitInventoryReport()
        {

           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }
        //Open from or focus if opened
        public void OpenChildForm(XtraForm form)
        {
            //Check before open
            if (!IsFormOpened(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }
        //Check if a form is opened already      
        private bool IsFormOpened(XtraForm form)
        {
            bool isOpened = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Active this form
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        isOpened = true;
                    }
                }
            }
            return isOpened;
        }
        private void SetAccessControl(){
            int level = ExtendClass.UserAccess.Instance.GetAccessLevel;
            switch (level)
            {
                case 1:
                    {
                        this.barButtonItemQD.Enabled = false;
                        this.barButtonItemDSNV.Enabled = false;
                        this.barButtonItemThemNV.Enabled = false;
                        break;
                    }
                default: break;
            }
        }
        private void barButtonItemDSKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemDSNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemDSThoGiaCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemDSPhieuDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachPDV danhSachPdv = new DanhSachPDV();
            OpenChildForm(danhSachPdv);
        }

        private void barButtonItemDSPhieuGC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemThemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemThemTho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItemThemPGC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemLapPhieuDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapPhieuDichVu nhapPhieuDichVu = new NhapPhieuDichVu();
            OpenChildForm(nhapPhieuDichVu);
        }

        private void barButtonItemDSLoaiDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachDichVu danhSachDichVu = new DanhSachDichVu();
            OpenChildForm(danhSachDichVu);
        }

        private void barButtonItemThemLoaiDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapDichVu_Form nhapDV = new NhapDichVu_Form();
            nhapDV.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.DanhSachLoaiSanPham_Form dsLoaiSanPham_frm = new Report.DanhSachLoaiSanPham_Form();
            OpenChildForm(dsLoaiSanPham_frm);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.NhapLoaiSanPham_Form nhapLoaiSanPham_frm = new Report.NhapLoaiSanPham_Form();
            nhapLoaiSanPham_frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.DanhSachSanPham_Form dsSanPham_frm = new Report.DanhSachSanPham_Form();
            OpenChildForm(dsSanPham_frm);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.NhapSanPham_Form nhapSanPham_frm = new Report.NhapSanPham_Form();
            nhapSanPham_frm.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.DanhSachPhieuMua_Form dsPhieuMua_frm = new Report.DanhSachPhieuMua_Form();
            OpenChildForm(dsPhieuMua_frm);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.NhapPhieuMua_Form nhapPhieuMua_frm = new Report.NhapPhieuMua_Form();
            OpenChildForm(nhapPhieuMua_frm);
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.NhapPhieuChi_Form nhapPhieuchi_frm = new Report.NhapPhieuChi_Form();
            OpenChildForm(nhapPhieuchi_frm);
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachNhanVien_Form dsnv = new DanhSachNhanVien_Form();
            OpenChildForm(dsnv);
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcess));
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            //thread.Start();
            this.Close();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Report.BaoCaoTonKho_Form baoCaoTonKho_frm = new Report.BaoCaoTonKho_Form();
            OpenChildForm(baoCaoTonKho_frm);
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemDSPhieuBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachPhieuBanHang_Form danhSachPhieuBanHang = new DanhSachPhieuBanHang_Form();
            OpenChildForm(danhSachPhieuBanHang);
        }

        private void barButtonItemLapPBH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhapPhieuBanHang_Form nhapPBH = new NhapPhieuBanHang_Form();
            nhapPBH.ShowDialog();
        }

        private void barButtonItemDSPhieuThuTienNo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemLapPhieuTTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemDSphieuNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemThemPhieuNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemThemNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        

        private void btnThemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhSachNhaCungCap_Form DSNCC = new DanhSachNhaCungCap_Form();
            OpenChildForm(DSNCC);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhaCungCap_Form NCC = new NhaCungCap_Form();
            NCC.ShowDialog();
        }
    }
}
