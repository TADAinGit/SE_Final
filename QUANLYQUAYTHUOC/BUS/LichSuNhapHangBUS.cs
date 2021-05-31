using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class LichSuNhapHangBUS
    {
        public static DataTable GetLSNhapHang()
        {
            return LichSuNhapHangDAO.Instance.GetLSNhapHang();
        }
        public static DataTable GetTTNhapHang(string maHD)
        {
            return LichSuNhapHangDAO.Instance.GetTTNhapHang(maHD);
        }
        public static DataTable GetTongChi(string date)
        {
            return LichSuNhapHangDAO.Instance.GetTongChi(date);
        }
        public static int UpdateRowNhapHang(object[] obj)
        {
            return LichSuNhapHangDAO.Instance.UpdateRowNhapHang(obj);
        }
    }
}
