using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
            private set {NhaCungCapDAO.instance = value;} 
        }

        public NhaCungCapDAO() {  }

        public List<NhaCungCapDTO> GetDsNCC()
        {
            List<NhaCungCapDTO> list = new List<NhaCungCapDTO>();

            string query = "select * from NHACUNGCAP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO LoaiSP = new NhaCungCapDTO(item);
                list.Add(LoaiSP);
                ;
            }
            return list;
        }


        public bool ThemNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string SDT)
        {
            string query = string.Format("INSERT NHACUNGCAP (MaNhaCungCap,TenNhaCungCap,DiaChi,SoDienThoai) VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", MaNCC, TenNCC, DiaChi, SDT);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }


        public bool CapNhatNhaCungCap(string MaNCC, string TenNCC, string DiaChi, string SDT)
        {
            string query = string.Format("UPDATE NHACUNGCAP SET TenNhaCungCap =N'{1}',DiaChi = N'{2}', SoDienThoai = N'{3}' WHERE MaNhaCungCap = N'{0}'", MaNCC, TenNCC, DiaChi, SDT);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CheckMaNCC(string MaNhaCC) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) MaNhaCungCap FROM NHACUNGCAP WHERE MaNhaCungCap = N'{0}'", MaNhaCC);

            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            if (result == 1) return true;

            else return false;

        }

        public string GetTenNCC(string MaNCC)
        {
            string query = string.Format("SELECT TenNhaCungCap FROM NHACUNGCAP WHERE MaNhaCungCap = N'{0}'", MaNCC);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }

        public string GetDiaChiNCC(string MaNCC)
        {
            string query = string.Format("SELECT DiaChi FROM NHACUNGCAP WHERE MaNhaCungCap = N'{0}'", MaNCC);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }

        public string GetSDTNCC(string MaNCC)
        {
            string query = string.Format("SELECT SoDienThoai FROM NHACUNGCAP WHERE MaNhaCungCap = N'{0}'", MaNCC);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }


    }
}
