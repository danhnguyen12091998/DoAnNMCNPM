using QuanLiBanVang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }
            private set { SanPhamDAO.instance = value; }
        }

        public SanPhamDAO() { }


        public bool ThemSanPham(string MaSP, string TenSP, string MaLoaiSP, float DonGiaMuaVao, int SoLuong, float DonGiaBanRa)
        {
            string query = string.Format("INSERT SANPHAM (MaSanPham,TenSanPham,MaLoaiSanPham,DonGiaMuaVao,SoLuongTon,DonGiaBanRa) VALUES (N'{0}',N'{1}',N'{2}',{3},{4},{5})",MaSP,TenSP,MaLoaiSP,DonGiaMuaVao,SoLuong,DonGiaBanRa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
           
        }

        public bool SuaSanPham(string MaSP, string TenSP, string MaLoaiSP, float DonGiaMuaVao, int SoLuong, float DonGiaBanRa)
        {
            string query = string.Format("UPDATE SANPHAM SET TenSanPham = N'{1}',MaLoaiSanPham=N'{2}',DonGiaMuaVao = {3},SoLuongTon={4},DonGiaBanRa={5} WHERE MaSanPham = N'{0}'", MaSP, TenSP, MaLoaiSP, DonGiaMuaVao, SoLuong, DonGiaBanRa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }

        public List<SanPhamDTO> GetDsSanPham()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();

            string query = "select * from SANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO LoaiSP = new SanPhamDTO(item);
                list.Add(LoaiSP);
                ;
            }

            return list;
        }


        public List<SanPhamDTO> GetListTenSPDuaTrenMaLoaiSP(string maLoaiSP)
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();

            string query = string.Format("select * from SANPHAM WHERE MaLoaiSanPham = N'{0}'",maLoaiSP);


            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO loaiSP = new SanPhamDTO(item);
                list.Add(loaiSP);
            }

            return list;
        }
        #region method




        #endregion method



    }
}
