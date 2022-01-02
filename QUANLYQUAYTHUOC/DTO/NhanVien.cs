using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DTO
{
    public interface INhanVienBuidler 
    {
        void SetUserId(string maNhanvien);
        void SetUserName(string tenNhanVien);
        void SetUserBirth(DateTime ngaySinh);
        void SetUserGender(bool gioiTinh);
        void SetUserCIN(string cmnd);
        void SetUserPhone(string sdt);
        void SetUserAddress(string diaChi);
        void SetUserFirstDayWork(DateTime ngayVaoLam);
        void SetUserSalary(Decimal luong);
        void SetUserRole(int phanQuyen);
        NhanVien GetNhanVien();
    }

    public class NhanVienBuilder : INhanVienBuidler
    {
        NhanVien nhanVien = new NhanVien();

        public void SetUserId(string maNhanVien)
        {
            nhanVien.MaNhanVien = maNhanVien;
        }

        public void SetUserName(string tenNhanVien)
        {
            nhanVien.TenNhanVien = tenNhanVien;
        }
        public void SetUserBirth(DateTime ngaySinh)
        {
            nhanVien.NgaySinh = ngaySinh;
        }

        public void SetUserGender(bool gioiTinh)
        {
            nhanVien.GioiTinh = gioiTinh;
        }

        public void SetUserCIN(string cmnd)
        {
            nhanVien.CMND = cmnd;
        }

        public void SetUserPhone(string sdt)
        {
            nhanVien.SDT = sdt;
        }

        public void SetUserAddress(string diaChi)
        {
            nhanVien.DiaChi = diaChi;
        }

        public void SetUserFirstDayWork(DateTime ngayVaoLam)
        {
            nhanVien.NgayVaoLam = ngayVaoLam;
        }

        public void SetUserSalary(Decimal luong)
        {
            nhanVien.Luong = luong;
        }

        public void SetUserRole(int phanQuyen)
        {
            nhanVien.PhanQuyen = phanQuyen;
        }

        public NhanVien GetNhanVien()
        {
            return nhanVien;
        }

    }

    public abstract class Creator
    {
        protected INhanVienBuidler _builder;

        public Creator(INhanVienBuidler builder)
        {
            _builder = builder;
        }

        public abstract void CreateNhanVien(
            string maNhanVien,
            string tenNhanVien,
            DateTime ngaySinh,
            bool gioiTinh,
            string cmnd,
            string sdt,
            string diaChi,
            DateTime ngayVaoLam,
            Decimal luong,
            int phanQuyen
            );

        public abstract NhanVien GetNhanVien();
    }

    public class NhanVienCreator : Creator
    {
        public NhanVienCreator(INhanVienBuidler buidler) : base(buidler)
        { }

        public override void CreateNhanVien(
            string maNhanVien,
            string tenNhanVien,
            DateTime ngaySinh,
            bool gioiTinh,
            string cmnd,
            string sdt,
            string diaChi,
            DateTime ngayVaoLam,
            Decimal luong,
            int phanQuyen
            )
        {
            _builder.SetUserId(maNhanVien);
            _builder.SetUserName(tenNhanVien);
            _builder.SetUserBirth(ngaySinh);
            _builder.SetUserGender(gioiTinh);
            _builder.SetUserCIN(cmnd);
            _builder.SetUserPhone(sdt);
            _builder.SetUserAddress(diaChi);
            _builder.SetUserFirstDayWork(ngayVaoLam);
            _builder.SetUserSalary(luong);
            _builder.SetUserRole(phanQuyen);
        }

        public override NhanVien GetNhanVien()
        {
            return _builder.GetNhanVien();
        }
    }

    public class NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string cmnd;
        private string sdt;
        private string diaChi;
        private DateTime ngayVaoLam;
        private Decimal luong;
        private int phanQuyen;
        private bool hasAccount;

        public NhanVien()
        {
        }

        public NhanVien(DataRow row) 
        {
            maNhanVien = (string)row["MANV"];
            tenNhanVien = (string)row["TEN"];
            ngaySinh = (DateTime)row["NGAYSINH"];
            gioiTinh = (bool)row["GIOITINH"];
            cmnd = (string)row["CMND"];
            sdt = (string)row["SDT"];
            diaChi = (string)row["DiaChi"];
            ngayVaoLam = (DateTime)row["NGAYSINH"];
            luong = (Decimal)row["LUONG"];
            phanQuyen = (int)row["PHANQUYEN"];
            hasAccount = (bool)row["CO_TK"];
        }

        #region Get - Set
        public string MaNhanVien 
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public DateTime NgayVaoLam
        {
            get { return ngayVaoLam; }
            set { ngayVaoLam = value; }
        }
        public Decimal Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        public int PhanQuyen
        {
            get { return phanQuyen; }
            set { phanQuyen = value; }
        }
        public bool HasAccount
        {
            get { return hasAccount; }
            set { hasAccount = value; }
        }
        #endregion
    }
}
