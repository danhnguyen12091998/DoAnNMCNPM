using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using QuanLiBanVang.DTO;

namespace QuanLiBanVang.DAO
{
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;

        public static LoaiSanPhamDAO Instance
        {
            get { if (instance == null) instance = new LoaiSanPhamDAO(); return LoaiSanPhamDAO.instance; }
            private set { LoaiSanPhamDAO.instance = value; }
        }
         
        public LoaiSanPhamDAO() { }

        public List<LoaiSanPhamDTO> GetDsLoaiSanPham()
        {
            List<LoaiSanPhamDTO> list = new List<LoaiSanPhamDTO>();

            string query = "select * from LOAISANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSanPhamDTO LoaiSP = new LoaiSanPhamDTO(item);
                list.Add(LoaiSP);
;           }

            return list;
        }

        public bool CheckMaLoaiSP(string MaLoaiSP) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) MaLoaiSanPham FROM LOAISANPHAM WHERE MaLoaiSanPham = N'{0}'",MaLoaiSP);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            if (result == -1) return true;

            return false;
        }


        public bool ThemLoaiSanPham(string MaLoaiSP, string TenLoaiSP, float PhanTram, string MaDVT)
        {
            string query = string.Format("INSERT LOAISANPHAM (MaLoaiSanPham,TenLoaiSanPham,PhanTramLoiNhuan,MaDonViTinh) VALUES (N'{0}',N'{1}',{2},N'{3}')",MaLoaiSP,TenLoaiSP,PhanTram,MaDVT);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
           
        }


    }
}
