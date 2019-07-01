using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class PhieuBanHangDTO
    {
        public PhieuBanHangDTO(string SoPBH, DateTime NgayLap, string KhachHang,float TongTien)
        {
            this.soPhieuBanHang = SoPBH;
            this.ngayLap = NgayLap;
            this.khachHang = KhachHang;
            this.tongTien = TongTien;
        }

        public PhieuBanHangDTO(DataRow row)
        {
            this.soPhieuBanHang = row["SoPhieuBanHang"].ToString();
            this.ngayLap = DateTime.Parse(row["NgayLap"].ToString());
            this.khachHang = row["KhachHang"].ToString();
            this.tongTien = float.Parse(row["TongTien"].ToString());
        }

        private string soPhieuBanHang;

        public string SoPhieuBanHang
        {
            get { return soPhieuBanHang; }
            set { soPhieuBanHang = value; }
        }
        private DateTime ngayLap;

        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        private string khachHang;

        public string KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }

        private float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
