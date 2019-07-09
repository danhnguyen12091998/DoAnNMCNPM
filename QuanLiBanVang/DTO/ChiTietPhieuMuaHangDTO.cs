using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class ChiTietPhieuMuaHangDTO
    {
        public ChiTietPhieuMuaHangDTO(string MaCT_PBH, string SoPBH, string MaSP, int SL, float DGMV, float ThanhTien)
        {
            this.maCT_PBH = MaCT_PBH;
            this.soPhieuBanHang = SoPBH;
            this.MaSanPham = MaSP;
            this.soLuong = SL;
            this.donGiaMuaVao = DGMV;
            this.thanhTien = ThanhTien;
        }

        public ChiTietPhieuMuaHangDTO(DataRow row)
        {
            this.maCT_PBH = row["MaCT_PMH"].ToString();
            this.soPhieuBanHang = row["SoPhieuMuaHang"].ToString();
            this.maSanPham = row["MaSanPham"].ToString();
            this.soLuong = int.Parse(row["SoLuong"].ToString());
            this.donGiaMuaVao = float.Parse(row["DonGiaMuaVao"].ToString());
            this.thanhTien = float.Parse(row["ThanhTien"].ToString());
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

        private float donGiaMuaVao;

        public float DonGiaMuaVao
        {
            get { return donGiaMuaVao; }
            set { donGiaMuaVao = value; }
        }

        private float thanhTien;

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
