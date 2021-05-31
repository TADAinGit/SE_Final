using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LichSuNhapHangDAO
    {
        private static LichSuNhapHangDAO instance;
        public static LichSuNhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichSuNhapHangDAO();
                }
                return LichSuNhapHangDAO.instance;
            }
        }

        public LichSuNhapHangDAO() { }

        public DataTable GetLSNhapHang()
        {
            string query = "exec DS_DN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTTNhapHang(string maDN)
        {
            string query = "exec DS_CTDN @MADN";
            string[] data = { maDN };
            return DataProvider.Instance.ExecuteQuery(query, data);
        }

        public DataTable GetTongChi(string date)
        {
            string query = "exec TONGCHI @DATE";
            object[] obj = { date };
            return DataProvider.Instance.ExecuteQuery(query, obj);
        }

        public int UpdateRowNhapHang(object[] obj)
        {
            string query = "exec CAPNHATDONHAP @MADN , @MANV , @NGAYNHAP , @NGAYGIAO , @TONGTIEN , @TRANGTHAI";
            return DataProvider.Instance.ExecuteNonQuery(query, obj);
        }
    }
}
