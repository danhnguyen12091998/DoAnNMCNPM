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


    }
}
