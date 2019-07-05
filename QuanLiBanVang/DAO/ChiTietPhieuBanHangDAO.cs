using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class ChiTietPhieuBanHangDAO
    {
        private static ChiTietPhieuBanHangDAO instance;

        public static ChiTietPhieuBanHangDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuBanHangDAO(); return instance; }
            private set{ ChiTietPhieuBanHangDAO.instance = value;}
        }

        public List<ChiTietPhieuBanHangDTO> GetChiTietPhieuBanHang(string soPhieuBanHang)
        {
            List<ChiTietPhieuBanHangDTO> list = new List<ChiTietPhieuBanHangDTO>();

            string query = string.Format("SELECT * FROM CT_PBH WHERE SoPhieuBanHang = N'{0}'",soPhieuBanHang);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietPhieuBanHangDTO LoaiSP = new ChiTietPhieuBanHangDTO(item);
                list.Add(LoaiSP);
                ;
            }

            return list;
        }

        public bool ThemChiTietPhieuBanHang(string MaCTPBH, string SoPBH, string MaSP, int SL,float DonGiaBanRa,float ThanhTien)
        {
            string query = string.Format("INSERT CT_PBH (MaCT_PBH,SoPhieuBanHang,MaSanPham,SoLuong,DonGiaBanRa,ThanhTien) VALUES (N'{0}',N'{1}',N'{2}',{3},{4},{5})", MaCTPBH,SoPBH,MaSP,SL,DonGiaBanRa,ThanhTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CapNhatChiTietPhieuMuaHang(string MaCTPBH, string MaSP, int SL, float DonGiaBanRa, float ThanhTien)
        {
            string query = string.Format("UPDATE CT_PBH SET MaSanPham =N'{1}',SoLuong = {2}, DonGiaBanRa = {3},ThanhTien = {4} WHERE MaCT_PBH = N'{0}'",MaCTPBH,MaSP,SL,DonGiaBanRa,ThanhTien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public bool CheckMaCT_PBH(string MaCTPBH) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT COUNT(*) MaCT_PBH FROM CT_PBH WHERE MaCT_PBH = N'{0}'", MaCTPBH);

            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            if (result == 1) return true;

            else return false;

        }

        public bool XoaChiTietPhieuMuaHang(string MaCTPBH)
        {
            string query = string.Format("DELETE CT_PBH WHERE MaCT_PBH = N'{0}'",MaCTPBH);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public string GetTongTien(string SoPBH) // có trả về true, không có trả về false
        {
            string query = string.Format("SELECT SUM(ThanhTien) FROM CT_PBH WHERE SoPhieuBanHang = N'{0}'", SoPBH);

            string result = DataProvider.Instance.ExecuteScalar(query).ToString();

            return result;

        }
    }
}
