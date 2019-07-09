using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class ChiTietPhieuBanHangDTO
    {
        public ChiTietPhieuBanHangDTO(string MaCT_PBH,string SoPBH,string MaSP, int SL,int DonGiaBanRa,int ThanhTien)
        {
            this.maCT_PBH = MaCT_PBH;
            this.soPhieuBanHang = SoPBH;
            this.MaSanPham = MaSP;
            this.soLuong = SL;
            this.donGianBanRa = DonGiaBanRa;
            this.thanhTien = ThanhTien;
        }

        public ChiTietPhieuBanHangDTO(DataRow row)
        {
            this.maCT_PBH = row["MaCT_PBH"].ToString();
            this.soPhieuBanHang = row["SoPhieuBanHang"].ToString();
            this.maSanPham = row["MaSanPham"].ToString();
            this.soLuong = int.Parse(row["SoLuong"].ToString());
            this.donGianBanRa = int.Parse(row["DonGiaBanRa"].ToString());
            this.thanhTien = int.Parse(row["ThanhTien"].ToString());
        }


        private string maCT_PBH;

        public string MaCT_PBH
        {
            get { return maCT_PBH; }
            set { maCT_PBH = value; }
        }

        private string soPhieuBanHang;

        public string SoPhieuBanHang
        {
            get { return soPhieuBanHang; }
            set { soPhieuBanHang = value; }
        }

        private string maSanPham;

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private int donGianBanRa;

        public int DonGianBanRa
        {
            get { return donGianBanRa; }
            set { donGianBanRa = value;}
        }

        private int thanhTien;

        public int ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }

      
    }
}
