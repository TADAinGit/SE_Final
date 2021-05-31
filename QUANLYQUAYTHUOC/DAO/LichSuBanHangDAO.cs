using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichSuBanHangDAO
    {
        private static LichSuBanHangDAO instance;
        public static LichSuBanHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichSuBanHangDAO();
                }
                return LichSuBanHangDAO.instance;
            }
        }

        public LichSuBanHangDAO() { }

        public DataTable GetLSBanHang()
        {
            string query = "exec DS_HD";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTTBanHang(string maHD)
        {
            string query = "exec DS_CTHD @MAHD";
            string[] data = { maHD };
            return DataProvider.Instance.ExecuteQuery(query, data);
        }

        public DataTable GetTongThuNhap(string date)
        {
            string query = "exec TONGTHUNHAP @date";
            object[] para = { date };
            return DataProvider.Instance.ExecuteQuery(query, para);
        }

        public int UpdateRowBanHang(object[] obj)
        {
            string query = "exec CAPNHATHOADON @MAHD , @MANV , @TENKH , @NGAYLAP , @TONGTIEN , @TRANGTHAI";
            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }
    }
}
