using BUS;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NhanVienBUS currentUser = new NhanVienBUS();
        CommandBase commandBase;
        ChildTab tab;
        public string GetMaNhanVien()
        {
            return currentUser.GetUserInformation().MaNhanVien;
        }

        public MainForm()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 White");

            bhiUsername.Caption = currentUser.GetUserInformation().TenNhanVien;
            if (currentUser.GetUserInformation().PhanQuyen != 0)
            {
                rbpQuanTri.Visible = false;
            }

        }

        private void tabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            tabControlMain.TabPages.Remove(arg.Page as XtraTabPage);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Tab setting
            tab = new ChildTab(tabControlMain, null, "name");
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab banHang = (ChildTab) tab.Clone();
            banHang.TabName = "Bán hàng";
            banHang.UserControl = new BanHangForm();
            commandBase = new TabControlCommand(banHang);
            commandBase.Execute();
        }

        private void btnInTemMaVach_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab inMaVach = (ChildTab)tab.Clone();
            inMaVach.TabName = "In tem mã vạch";
            inMaVach.UserControl = new InMaVachForm();
            commandBase = new TabControlCommand(inMaVach);
            commandBase.Execute();
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab danhSachNhanVien = (ChildTab)tab.Clone();
            danhSachNhanVien.TabName = "Danh sách nhân viên";
            danhSachNhanVien.UserControl = new DanhSachNhanVienForm();
            commandBase = new TabControlCommand(danhSachNhanVien);
            commandBase.Execute();
        }

        private void btnXemLichSuBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab lichSuBanHang = (ChildTab)tab.Clone();
            lichSuBanHang.TabName = "Lịch sử bán hàng";
            lichSuBanHang.UserControl = new LichSuBanHangForm();
            commandBase = new TabControlCommand(lichSuBanHang);
            commandBase.Execute();
        }

        private void btnXemLichSuNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab lichSuNhapHang = (ChildTab)tab.Clone();
            lichSuNhapHang.TabName = "Lịch sử nhập hàng";
            lichSuNhapHang.UserControl = new LichSuNhapHangForm();
            commandBase = new TabControlCommand(lichSuNhapHang);
            commandBase.Execute();
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab nhapHang = (ChildTab)tab.Clone();
            nhapHang.TabName = "Nhập hàng";
            nhapHang.UserControl = new NhapHangForm();
            commandBase = new TabControlCommand(nhapHang);
            commandBase.Execute();
        }

        private void btnKhoThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab khoThuoc = (ChildTab)tab.Clone();
            khoThuoc.TabName = "Kho thuốc";
            khoThuoc.UserControl = new KhoThuocForm();
            commandBase = new TabControlCommand(khoThuoc);
            commandBase.Execute();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ứng dụng này ?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab thongTinCaNhan = (ChildTab)tab.Clone();
            thongTinCaNhan.TabName = "Thông tin cá nhân";
            thongTinCaNhan.UserControl = new ThongTinCaNhanForm();
            commandBase = new TabControlCommand(thongTinCaNhan);
            commandBase.Execute();
        }

        private void btnThongTinNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChildTab thongTinNCC = (ChildTab)tab.Clone();
            thongTinNCC.TabName = "Thông tin nhà cung cấp";
            thongTinNCC.UserControl = new ThongTinNCCForm();
            commandBase = new TabControlCommand(thongTinNCC);
            commandBase.Execute();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            new DoiMatKhauForm().Show();
        }
    }
}