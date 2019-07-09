using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(string MaNV, string HoTen, string MK)
        {
            this.manv = MaNV;
            this.hoten = HoTen;
            this.matkhau = MK;
        }

        public NhanVienDTO(DataRow row)
        {
            this.manv = row["Manv"].ToString();
            this.hoten = row["Hoten"].ToString();
            this.matkhau = row["Matkhau"].ToString();
        }         

        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value;}
        }

        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
    }
}
