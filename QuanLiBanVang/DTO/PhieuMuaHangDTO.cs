using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class PhieuMuaHangDTO
    {

        public PhieuMuaHangDTO(string SoPBH, DateTime NgayLap, string MaNCC, float TongTien)
        {
            this.soPhieuBanHang = SoPBH;
            this.ngayLap = NgayLap;
            this.maNhaCungCap = MaNCC;
            this.tongTien = TongTien;
        }

        public PhieuMuaHangDTO(DataRow row)
        {
            this.soPhieuBanHang = row["SoPhieuBanHang"].ToString();
            this.ngayLap = DateTime.Parse(row["NgayLap"].ToString());
            this.maNhaCungCap = row["MaNhaCungCap"].ToString();
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

        private string maNhaCungCap;

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }

        private float tongTien;

        public float TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
    }
}
