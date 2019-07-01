using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{

    public class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return DichVuDAO.instance; }
            private set { DichVuDAO.instance = value; }
        }

        public DichVuDAO() { }

        public List<DichVuDTO> GetDsLoaiSanPham()
        {
            List<DichVuDTO> list = new List<DichVuDTO>();

            string query = "select * from LOAIDICHVU";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DichVuDTO dv = new DichVuDTO(item);
                list.Add(dv);
                
            }

            return list;
        }

        public bool ThemDichVu(string MaLoaiDV, string TenLoaiDV, float DonGia)
        {
            string query = string.Format("INSERT LOAIDICHVU (MaLoaiDichVu,TenLoaiDichVu,DonGia) VALUES (N'{0}',N'{1}',{2})", MaLoaiDV, TenLoaiDV, DonGia);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }


        public bool CapNhatDichVu(string MaLoaiDV, string TenLoaiDV, float DonGia)
        {
            string query = string.Format("UPDATE LOAIDICHVU SET TenLoaiDichVu =N'{1}',DonGia = {2} WHERE MaLoaiDichVu = N'{0}'", MaLoaiDV, TenLoaiDV, DonGia);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

    }
}
