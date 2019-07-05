using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class PhieuBanHangDAO
    {

        private static PhieuBanHangDAO instance;

        public static PhieuBanHangDAO Instance
        {
            get { if (instance == null) instance = new PhieuBanHangDAO(); return PhieuBanHangDAO.instance; }
            private set { PhieuBanHangDAO.instance = value; }
        }

        public PhieuBanHangDAO() { }

        public List<PhieuBanHangDTO> GetDsLoaiSanPham()
        {
            List<PhieuBanHangDTO> list = new List<PhieuBanHangDTO>();

            string query = "select * from PHIEUBANHANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhieuBanHangDTO LoaiSP = new PhieuBanHangDTO(item);
                list.Add(LoaiSP);
                ;
            }

            return list;
        }



        public bool ThemPhieuBanHang(string SoPBH, DateTime NgayLap, string KH, float TongTien)
        {
            string query = string.Format("INSERT PHIEUBANHANG (SoPhieuBanHang,NgayLap,KhachHang,TongTien) VALUES (N'{0}',N'{1}',N'{2}',{3})", SoPBH, NgayLap, KH, TongTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }


        public bool CapNhatPhieuBanHang(string SoPBH, DateTime NgayLap, string KH, float TongTien)
        {
            string query = string.Format("UPDATE PHIEUBANHANG SET NgayLap =N'{1}',KhachHang = N'{2}', TongTien = {3} WHERE SoPhieuBanHang = N'{0}'", SoPBH, NgayLap, KH, TongTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public string GetNgayLap(string SoPBH) 
        {
            string query = string.Format("SELECT NgayLap FROM PHIEUBANHANG WHERE SoPhieuBanHang = N'{0}'", SoPBH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();
        
            return result;

        }

        public string GetKH(string SoPBH) 
        {
            string query = string.Format("SELECT KhachHang FROM PHIEUBANHANG WHERE SoPhieuBanHang = N'{0}'", SoPBH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }


        public bool CheckSoPBH(string SoPBH) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) SoPhieuBanHang FROM PHIEUBANHANG WHERE SoPhieuBanHang = N'{0}'", SoPBH);

            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            if (result == 1) return true;

            else return false;

        }


    }
}
