using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;
using DTO;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class ThongTinCaNhanForm : DevExpress.XtraEditors.XtraUserControl
    {
        Creator creator = new NhanVienCreator(new NhanVienBuilder());

        public ThongTinCaNhanForm()
        {
            InitializeComponent();
        }

        private void ThongTinCaNhanForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            txtMaNV.Enabled = false;
            txtNgayVao.Enabled = false;
            txtLuong.Enabled = false;
            txtChucVu.Enabled = false;
            txtTen.Focus();

            NhanVienBUS nv = new NhanVienBUS();
            NhanVien nhanvien = nv.GetUserInformation();
            txtMaNV.Text = nhanvien.MaNhanVien;
            txtTen.Text = nhanvien.TenNhanVien;
            txtNgaySinh.Text = nhanvien.NgaySinh.ToShortDateString();
            if (nhanvien.GioiTinh)
                txtGioiTinh.Text = "Nữ";
            else
                txtGioiTinh.Text = "Nam";
            txtCMND.Text = nhanvien.CMND;
            txtSDT.Text = nhanvien.SDT;
            txtDiaChi.Text = nhanvien.DiaChi;
            txtNgayVao.Text = nhanvien.NgayVaoLam.ToShortDateString();
            txtLuong.Text = nhanvien.Luong.ToString();
            if (nhanvien.PhanQuyen == 0)
                txtChucVu.Text = "Admin";
            else
                txtChucVu.Text = "Nhân Viên";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNV.Text; 
            string tenNhanVien = txtTen.Text;
            DateTime ngaySinh = Convert.ToDateTime(txtNgaySinh.Text);
            bool gioiTinh = txtGioiTinh.Text.Equals("Nữ");
            string cmnd = txtCMND.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            DateTime ngayVaoLam = Convert.ToDateTime(txtNgayVao.Text);
            Decimal luong = Convert.ToInt32(txtLuong.Text);
            int phanQuyen = txtChucVu.Text.Equals("Admin") ? 0 : 1;
            
            creator.CreateNhanVien(
                maNhanVien,
                tenNhanVien,
                ngaySinh,
                gioiTinh,
                cmnd,
                sdt,
                diaChi,
                ngayVaoLam,
                luong,
                phanQuyen
                );

            NhanVien nhanVien = creator.GetNhanVien();

            int result = NhanVienBUS.UpdateThongTinNhanVien(nhanVien);
            if (result == 1)
                MessageBox.Show("Cập Nhật Thành Công!!!", "Success", MessageBoxButtons.OK);
            else
                MessageBox.Show("Cập Nhật Thất Bại", "Fail", MessageBoxButtons.OK);

        }
    }
}
