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

            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            
            if (result == 1) return true;

            else return false;

        }


        public bool ThemLoaiSanPham(string MaLoaiSP, string TenLoaiSP, float PhanTram, string MaDVT)
        {
            string query = string.Format("INSERT LOAISANPHAM (MaLoaiSanPham,TenLoaiSanPham,PhanTramLoiNhuan,MaDonViTinh) VALUES (N'{0}',N'{1}',{2},N'{3}')",MaLoaiSP,TenLoaiSP,PhanTram,MaDVT);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
           
        }

        public bool CapNhatLoaiSanPham(string MaLoaiSP, string TenLoaiSP, float PhanTram, string MaDVT)
        {
            string query = string.Format("UPDATE LOAISANPHAM SET TenLoaiSanPham =N'{0}',PhanTramLoiNhuan = {1}, MaDonViTinh = N'{2}' WHERE MaLoaiSanPham = N'{3}'",TenLoaiSP, PhanTram, MaDVT, MaLoaiSP);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool XoaLoaiSanPham(string MaLoaiSP, string TenLoaiSP, float PhanTram, string MaDVT)
        {
            string query = string.Format("");

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }


        public List<LoaiSanPhamDTO> GetListMaLoaiSP()
        {
            List<LoaiSanPhamDTO> list = new List<LoaiSanPhamDTO>();

            string query = "select * from LOAISANPHAM";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSanPhamDTO loaiSP = new LoaiSanPhamDTO(item);
                list.Add(loaiSP);
            }

            return list;
        }


        public float GetPhanTramLoiNhuan(string maLoaiSP)

        {
            string query = String.Format("SELECT LOAISANPHAM.PhanTramLoiNhuan FROM LOAISANPHAM WHERE MaLoaiSanPham = N'{0}'",maLoaiSP);

            float result =float.Parse(DataProvider.Instance.ExecuteScalar(query).ToString());

            return result;
        }

    }
}
