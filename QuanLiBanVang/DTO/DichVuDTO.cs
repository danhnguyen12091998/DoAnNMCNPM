using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class DichVuDTO
    {
        public DichVuDTO(string MaLoaiDV, string TenLoaiDV, float DonGia)
        {
            this.maLoaiDichVu = MaLoaiDV;
            this.tenLoaiDichVu = TenLoaiDV;
            this.donGia = DonGia;
        }

        public DichVuDTO(DataRow row)
        {
            this.maLoaiDichVu = row["MaLoaiDichVu"].ToString();
            this.tenLoaiDichVu = row["TenLoaiDichVu"].ToString();
            this.donGia = float.Parse(row["DonGia"].ToString());
        }



        private string maLoaiDichVu;

        public string MaLoaiDichVu
        {
            get {return maLoaiDichVu;}
            set { maLoaiDichVu = value; }
        }


        private string tenLoaiDichVu;

        public string TenLoaiDichVu
        {
            get { return tenLoaiDichVu; }
            set { tenLoaiDichVu = value; }
        }

        private float donGia;

        public float DonGia
        {
            get {return donGia; }
            set { donGia = value; }
        }
    }
}
