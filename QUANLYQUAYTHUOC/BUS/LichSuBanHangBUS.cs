using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LichSuBanHangBUS
    {
        public static DataTable GetLSBanHang()
        {
            return LichSuBanHangDAO.Instance.GetLSBanHang();
        }
        public static DataTable GetTTBanHang(string maHD)
        {
            return LichSuBanHangDAO.Instance.GetTTBanHang(maHD);
        }

        public static DataTable GetTongThuNhap(string date)
        {
            return LichSuBanHangDAO.Instance.GetTongThuNhap(date);
        }
        public static int UpdateRowBanHang(object[] obj)
        {
            return LichSuBanHangDAO.Instance.UpdateRowBanHang(obj);
        }
    }
}
