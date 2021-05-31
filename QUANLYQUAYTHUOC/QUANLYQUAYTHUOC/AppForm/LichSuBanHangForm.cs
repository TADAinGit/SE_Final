using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class LichSuBanHangForm : DevExpress.XtraEditors.XtraUserControl
    {
        public LichSuBanHangForm()
        {
            InitializeComponent();
        }

        private void LichSuBanHangForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = LichSuBanHangBUS.GetLSBanHang();
            gridview.DataSource = bindingSource;

            gridLSBH.OptionsView.ShowGroupPanel = false;
            gridLSBH.OptionsFind.AlwaysVisible = true;

            gridTTCT.OptionsView.ShowGroupPanel = false;
            gridTTCT.OptionsFind.AlwaysVisible = true;

            gridLSBH.Columns["MAHD"].Caption = "Mã Hóa Đơn";
            gridLSBH.Columns["MANV"].Caption = "Mã Nhân Viên";
            gridLSBH.Columns["TENKH"].Caption = "Tên Khách Hàng";
            gridLSBH.Columns["NGAYLAP"].Caption = "Ngày Lập";
            gridLSBH.Columns["TONGTIEN"].Caption = "Tổng Tiền";
            gridLSBH.Columns["TRANGTHAI"].Caption = "Đã Thanh Toán";

            string date = dateNgay.Value.ToShortDateString();
            DataTable data = LichSuBanHangBUS.GetTongThuNhap(date);
            string tongtien = data.Rows[0].ItemArray[0].ToString();
            if (String.IsNullOrEmpty(tongtien))
                txtDoanhThuNgay.Text = "0";
            else
                txtDoanhThuNgay.Text = tongtien;
            gridLSBH.Columns["MAHD"].OptionsColumn.ReadOnly = true;
        }

        private void gridLSBH_RowClick(object sender, RowClickEventArgs e)
        {
            string maHD = gridLSBH.GetRowCellValue(gridLSBH.FocusedRowHandle, "MAHD").ToString();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = LichSuBanHangBUS.GetTTBanHang(maHD);
            gridview2.DataSource = bindingSource;

            gridTTCT.Columns["MAHD"].Caption = "Mã Hóa Đơn";
            gridTTCT.Columns["MASP"].Caption = "Mã Sản Phẩm";
            gridTTCT.Columns["TENSP"].Caption = "Tên Sản Phẩm";
            gridTTCT.Columns["SL"].Caption = "Số Lượng";

            gridTTCT.Columns["MAHD"].OptionsColumn.ReadOnly = true;
            gridTTCT.Columns["MASP"].OptionsColumn.ReadOnly = true;
            gridTTCT.Columns["TENSP"].OptionsColumn.ReadOnly = true;
            gridTTCT.Columns["SL"].OptionsColumn.ReadOnly = true;
        }

        private void dateNgay_ValueChanged(object sender, EventArgs e)
        {
            string date = dateNgay.Value.ToShortDateString();
            DataTable data = LichSuBanHangBUS.GetTongThuNhap(date);
            string tongtien = data.Rows[0].ItemArray[0].ToString();
            if (String.IsNullOrEmpty(tongtien))
                txtDoanhThuNgay.Text = "0";
            else
                txtDoanhThuNgay.Text = tongtien;
        }

        private void gridLSBH_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView row = (DataRowView)e.Row;
            object[] obj = row.Row.ItemArray;
            int result = LichSuBanHangBUS.UpdateRowBanHang(obj);
            if (result > 0)
                MessageBox.Show("Đã cập nhật dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = LichSuBanHangBUS.GetLSBanHang();
                gridview.DataSource = bindingSource;

                gridview2.Refresh();
            }
        }
    }
}
