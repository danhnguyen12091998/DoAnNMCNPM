using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class ChiTietPhieuMuaHangDAO
    {
        private static ChiTietPhieuMuaHangDAO instance;

        int id = 1;

        public void SetID(int i)
        {
            id = i;
        }

        public int GetID()
        {
            return id;
        }

        public static ChiTietPhieuMuaHangDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuMuaHangDAO(); return ChiTietPhieuMuaHangDAO.instance; }
            private set { ChiTietPhieuMuaHangDAO.instance = value; }
        }

        public ChiTietPhieuMuaHangDAO() { }

        public List<ChiTietPhieuMuaHangDTO> GetChiTietPhieuMuaHang(string soPhieuMuaHang)
        {
            List<ChiTietPhieuMuaHangDTO> list = new List<ChiTietPhieuMuaHangDTO>();

            string query = string.Format("SELECT * FROM CT_PMH WHERE SoPhieuMuaHang = N'{0}'", soPhieuMuaHang);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietPhieuMuaHangDTO LoaiSP = new ChiTietPhieuMuaHangDTO(item);
                list.Add(LoaiSP);
            }

            return list;
        }

        public bool ThemChiTietPhieuMuaHang(string MaCTPMH, string SoPMH, string MaSP, int SL, float DonGiaBanRa, float ThanhTien)
        {
            string query = string.Format("INSERT CT_PMH (MaCT_PMH,SoPhieuMuaHang,MaSanPham,SoLuong,DonGiaMuaVao,ThanhTien) VALUES (N'{0}',N'{1}',N'{2}',{3},{4},{5})", MaCTPMH, SoPMH, MaSP, SL, DonGiaBanRa, ThanhTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CapNhatChiTietPhieuMuaHang(string MaCTPMH, string SoPMH, string MaSP, int SL, float DonGiaBanRa, float ThanhTien)
        {
            string query = string.Format("UPDATE CT_PMH SET MaSanPham =N'{1}',SoLuong = {2}, DonGiaMuaVao = {3},ThanhTien = {4} WHERE MaCT_PMH = N'{0}'", MaCTPMH, MaSP, SL, DonGiaBanRa, ThanhTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CheckMaCT_PMH(string MaCTPMH) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) MaCT_PMH FROM CT_PMH WHERE MaCT_PMH = N'{0}'", MaCTPMH);

            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            if (result == 1) return true;

            else return false;

        }

        public bool XoaChiTietPhieuMuaHang(string MaCTPMH)
        {
            string query = string.Format("DELETE CT_PMH WHERE MaCT_PMH = N'{0}'", MaCTPMH);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public string GetTongTien(string SoPMH) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT SUM(ThanhTien) FROM CT_PMH WHERE SoPhieuMuaHang = N'{0}'", SoPMH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }

    }
}
