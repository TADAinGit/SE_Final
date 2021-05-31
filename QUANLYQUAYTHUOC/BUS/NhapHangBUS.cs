using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhapHangBUS
    {
        public static DataTable GetDsThuoc()
        {
            return NhapHangDAO.Instance.GetDsThuoc();
        }

        public static int InsertDonNhapMoi(object[] obj)
        {
            return NhapHangDAO.Instance.InsertDonNhapMoi(obj);
        }

        public static int InsertCTDN(object[] obj)
        {
            return NhapHangDAO.Instance.InsertCTDN(obj);
        }
    }
}
