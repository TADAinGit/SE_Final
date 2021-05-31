using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhapHangDAO
    {
        private static NhapHangDAO instance;
        public static NhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhapHangDAO();
                }
                return NhapHangDAO.instance;
            }
        }

        public NhapHangDAO() { }

        public DataTable GetDsThuoc()
        {
            string query = "exec DS_NH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertDonNhapMoi(object[] obj)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec THEMDONHAP @MANV , @NGAYNHAP , @NGAYGIAO , @TONGTIEN , @TRANGTHAI", obj);
        }

        public int InsertCTDN(object[] obj)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec THEMCTNH @MASP , @SL", obj);
        }
    }
}
