using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class SanPhamDTO
    {
        public SanPhamDTO(string maSP, string tenSP, string maLoaiSP, int donGiaMuaVao, int soLuongTon, int donGiaBanRa)
        {
            this.maSanPham = maSP;
            this.tenSanPham = tenSP;
            this.maLoaiSanPham = maLoaiSP;
            this.donGiaMuaVao = donGiaMuaVao;
            this.soLuongTon = soLuongTon;
            this.donGiaBanRa = donGiaBanRa;
        }

        public SanPhamDTO(DataRow row)
        {
            this.maSanPham = row["MaSanPham"].ToString();
            this.tenSanPham = row["TenSanPham"].ToString();
            this.maLoaiSanPham = row["MaLoaiSanPham"].ToString(); 
            this.donGiaMuaVao = int.Parse(row["donGiaMuaVao"].ToString());
            this.soLuongTon = int.Parse(row["soLuongTon"].ToString());
            this.donGiaBanRa = int.Parse(row["donGiaBanRa"].ToString());
        }

        private string maSanPham;

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }

        private string tenSanPham;

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }

        private string maLoaiSanPham;
        public string MaLoaiSanPham
        {
            get { return maLoaiSanPham; }
            set { maLoaiSanPham = value; }
        }

        private int donGiaMuaVao;

        public int DonGiaMuaVao
        {
            get { return donGiaMuaVao; }
            set { donGiaMuaVao = value; }
        }

        private int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        private int donGiaBanRa;

        public int DonGiaBanRa
        {
            get { return donGiaBanRa; }
            set { donGiaBanRa = value; }
        }
    }
   


}
