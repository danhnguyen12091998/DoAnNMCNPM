using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class DonViTinhDAO
    {
        private static DonViTinhDAO instance;

        public static DonViTinhDAO Instance
        {
            get { if (instance == null) instance = new DonViTinhDAO(); return DonViTinhDAO.instance; }
            private set { DonViTinhDAO.instance = value; }
        }

        public DonViTinhDAO() { }

        public List<DonViTinhDTO> GetDsDonViTinh()
        {
            List<DonViTinhDTO> list = new List<DonViTinhDTO>();

            string query = "select * from DONVITINH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DonViTinhDTO LoaiSP = new DonViTinhDTO(item);
                list.Add(LoaiSP);        
            }

            return list;
        }

        public bool ThemDonViTinh(string MaDVT, string TenDVT)
        {
            string query = string.Format("INSERT DONVITINH (MaDonViTinh,TenDonViTinh) VALUES (N'{0}',N'{1}')", MaDVT, TenDVT);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool XoaDonViTinh(string MaDVT)
        {
            string query = string.Format("DELETE DONVITINH WHERE MaDonViTinh = N'{0}'",MaDVT);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }



    }
}
