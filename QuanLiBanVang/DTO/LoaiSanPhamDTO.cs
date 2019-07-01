using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class LoaiSanPhamDTO
    {
        public LoaiSanPhamDTO(string MaLoaiSP,string TenLoaiSP,float PhanTram,string MaDVT)
        {
            this.maLoaiSP = MaLoaiSP;
            this.tenLoaiSP = TenLoaiSP;
            this.phanTram = PhanTram;
            this.maDVT = MaDVT;
        }

        public LoaiSanPhamDTO(DataRow row)
        {
            this.maLoaiSP = row["MaLoaiSanPham"].ToString();
            this.tenLoaiSP = row["TenLoaiSanPham"].ToString();
            this.phanTram = float.Parse(row["PhanTramLoiNhuan"].ToString());
            this.maDVT = row["MaDonViTinh"].ToString();
        }


        private string maLoaiSP;

        public string MaLoaiSP
        {
            get { return maLoaiSP; }
            set { maLoaiSP = value; }
        }

        private string tenLoaiSP;

        public string TenLoaiSP
        {
            get { return tenLoaiSP; }
            set { tenLoaiSP = value; }
        }

        private float phanTram;

        public float PhanTram
        {
            get { return phanTram; }
            set { phanTram = (float)value; }
        }

        private string maDVT;

        public string MaDVT
        {
            get { return maDVT; }
            set { maDVT = value; }
        }




    }
}
