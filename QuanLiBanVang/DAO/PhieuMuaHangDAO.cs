using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class PhieuMuaHangDAO
    {

        private static PhieuMuaHangDAO instance;

        public static PhieuMuaHangDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuaHangDAO(); return PhieuMuaHangDAO.instance; }
            private set { PhieuMuaHangDAO.instance = value; }
        }

        public PhieuMuaHangDAO() { }

        public List<PhieuMuaHangDTO> GetDsPhieuMuaHang()
        {
            List<PhieuMuaHangDTO> list = new List<PhieuMuaHangDTO>();

            string query = "select * from PHIEUMUAHANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuMuaHangDTO LoaiSP = new PhieuMuaHangDTO(item);
                list.Add(LoaiSP);
               
            }

            return list;
        }



        public bool ThemPhieuMuaHang(string SoPBH, DateTime NgayLap, string MaNCC, float TongTien)
        {
            string query = string.Format("INSERT PHIEUMUAHANG (SoPhieuMuaHang,NgayLap,MaNhaCungCap,TongTien) VALUES (N'{0}',N'{1}',N'{2}',{3})", SoPBH, NgayLap, MaNCC, TongTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }


        public bool CapNhatPhieuMuaHang(string SoPBH, DateTime NgayLap, string MaNCC, float TongTien)
        {
            string query = string.Format("UPDATE PHIEUMUAHANG SET NgayLap =N'{1}',MaNhaCungCap = N'{2}', TongTien = {3} WHERE SoPhieuMuaHang = N'{0}'", SoPBH, NgayLap, MaNCC, TongTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public string GetNgayLap(string SoPMH) 
        {
            string query = string.Format("SELECT NgayLap FROM PHIEUMUAHANG WHERE SoPhieuMuaHang = N'{0}'", SoPMH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();
        
            return result;

        }

        public string GetNCC(string SoPMH) 
        {
            string query = string.Format("SELECT MaNhaCungCap FROM PHIEUMUAHANG WHERE SoPhieuMuaHang = N'{0}'", SoPMH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }


        public string GetTongTien(string SoPMH)
        {
            string query = string.Format("SELECT TongTien FROM PHIEUMUAHANG WHERE SoPhieuMuaHang = N'{0}'", SoPMH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;
        }


        public bool CheckSoPMH(string SoPMH) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) SoPhieuMuaHang FROM PHIEUMUAHANG WHERE SoPhieuMuaHang = N'{0}'", SoPMH);

            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            if (result == 1) return true;

            else return false;

        }


    }
}
