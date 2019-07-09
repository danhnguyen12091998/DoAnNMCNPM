using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private NhanVienDAO()
        {

        }

        public List<NhanVienDTO> GetDsNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();

            string query = "select * from NHANVIEN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO LoaiSP = new NhanVienDTO(item);
                list.Add(LoaiSP);
                ;
            }

            return list;
        }

        public bool CheckMaNhanVien(string MaNV) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) Manv FROM NHANVIEN WHERE Manv = N'{0}'", MaNV);

            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            if (result == 1) return true;

            else return false;

        }



        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.NHANVIEN WHERE Hoten = N'" + username + "' AND Matkhau = N'" + password + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public bool ThemNhanVien(string MaNV, string TenNV, string Matkhau)
        {
            string query = string.Format("INSERT NHANVIEN (Manv,Hoten,Matkhau) VALUES (N'{0}',N'{1}',N'{2}')", MaNV,TenNV,Matkhau);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CapNhatNhanVien(string MaNV, string TenNV, string Matkhau)
        {
            string query = string.Format("UPDATE NHANVIEN SET Hoten = N'{1}',Matkhau = N'{2}' WHERE Manv = N'{0}'",MaNV,TenNV,Matkhau);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool XoaLNhanVien(string MaNV)
        {
            string query = string.Format("DELETE FROM NHANVIEN WHERE Manv = N'{0}'",MaNV);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }



    }
    
}
