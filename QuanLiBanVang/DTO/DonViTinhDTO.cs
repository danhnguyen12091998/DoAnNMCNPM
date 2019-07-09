using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DTO
{
    public class DonViTinhDTO
    {
        public DonViTinhDTO(string MaDVT, string TenDVT)
        {
            this.maDonViTinh = MaDVT;
            this.tenDonViTinh = TenDVT;
        }

        public DonViTinhDTO(DataRow row)
        {
            this.maDonViTinh = row["MaDonViTinh"].ToString();
            this.tenDonViTinh = row["TenDonViTinh"].ToString();
        }

        private string maDonViTinh;

        public string MaDonViTinh
        {
            get { return maDonViTinh; }
            set { maDonViTinh = value; }
        }

        private string tenDonViTinh;

        public string TenDonViTinh
        {
            get { return tenDonViTinh; }
            set { tenDonViTinh = value; }
        }


    }
}
