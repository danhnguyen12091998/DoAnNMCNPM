using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class NhaCungCapDTO
    {
        public NhaCungCapDTO(string MaNCC, string TenNCC, string DiaChi,string SDT)
        {
            this.maNhaCungCap = MaNCC;
            this.tenNhaCungCap = TenNCC;
            this.diaChi = DiaChi;
            this.soDienThoai = SDT;
        }

        public NhaCungCapDTO(DataRow row)
        {
            this.maNhaCungCap = row["MaNhaCungCap"].ToString();
            this.tenNhaCungCap = row["TenNhaCungCap"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.soDienThoai = row["SoDienThoai"].ToString();
        }

        private string maNhaCungCap;

        public string MaNhaCungCap
        {
            get {return maNhaCungCap;}
            set { maNhaCungCap = value; }
        }

        private string tenNhaCungCap;

        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
        
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string soDienThoai;

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

    }
}
