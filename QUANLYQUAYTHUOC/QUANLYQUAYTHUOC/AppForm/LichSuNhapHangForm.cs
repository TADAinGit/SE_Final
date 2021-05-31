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
using DevExpress.XtraGrid.Views.Grid;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class LichSuNhapHangForm : DevExpress.XtraEditors.XtraUserControl
    {
        public LichSuNhapHangForm()
        {
            InitializeComponent();
        }
        private void LichSuNhapHangForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = LichSuNhapHangBUS.GetLSNhapHang();
            gvwNhapHang.DataSource = bindingSource;

            gvwTableNH.OptionsView.ShowGroupPanel = false;
            gvwTableNH.OptionsFind.AlwaysVisible = true;

            gvwTTTCT.OptionsView.ShowGroupPanel = false;
            gvwTTTCT.OptionsFind.AlwaysVisible = true;

            gvwTableNH.Columns["MADN"].Caption = "Mã Đơn Nhập";
            gvwTableNH.Columns["MANV"].Caption = "Mã Nhân Viên";
            gvwTableNH.Columns["NGAYNHAP"].Caption = "Ngày Nhập";
            gvwTableNH.Columns["NGAYGIAO"].Caption = "Ngày Giao";
            gvwTableNH.Columns["TONGTIEN"].Caption = "Tổng Tiền";
            gvwTableNH.Columns["TRANGTHAI"].Caption = "Đã Nhận";

            string date = dateNgay.Value.ToShortDateString();
            DataTable data = LichSuNhapHangBUS.GetTongChi(date);
            string tongTien = data.Rows[0].ItemArray[0].ToString();
            if (String.IsNullOrEmpty(tongTien))
                txtTongChi.Text = "0";
            else
                txtTongChi.Text = tongTien;
            gvwTableNH.Columns["MADN"].OptionsColumn.ReadOnly = true;
        }

        private void gvwTableNH_RowClick(object sender, RowClickEventArgs e)
        {
            string maDN = gvwTableNH.GetRowCellValue(gvwTableNH.FocusedRowHandle, "MADN").ToString();
            System.Console.WriteLine(maDN);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = LichSuNhapHangBUS.GetTTNhapHang(maDN);
            gvwTTCT.DataSource = bindingSource;

            gvwTTTCT.Columns["MADN"].Caption = "Mã Đơn Nhập";
            gvwTTTCT.Columns["MASP"].Caption = "Mã Sản Phẩm";
            gvwTTTCT.Columns["TENSP"].Caption = "Tên Sản Phẩm";
            gvwTTTCT.Columns["SL"].Caption = "Số Lượng";

            gvwTTTCT.Columns["MADN"].OptionsColumn.ReadOnly = true;
            gvwTTTCT.Columns["MASP"].OptionsColumn.ReadOnly = true;
            gvwTTTCT.Columns["TENSP"].OptionsColumn.ReadOnly = true;
            gvwTTTCT.Columns["SL"].OptionsColumn.ReadOnly = true;
        }

        private void dateNgay_ValueChanged(object sender, EventArgs e)
        {
            string date = dateNgay.Value.ToShortDateString();
            DataTable data = LichSuNhapHangBUS.GetTongChi(date);
            string tongTien = data.Rows[0].ItemArray[0].ToString();
            if (String.IsNullOrEmpty(tongTien))
                txtTongChi.Text = "0";
            else
                txtTongChi.Text = tongTien;
        }

        private void gvwTableNH_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView row = (DataRowView)e.Row;
            object[] obj = row.Row.ItemArray;
            int result = LichSuNhapHangBUS.UpdateRowNhapHang(obj);
            if (result > 0)
                MessageBox.Show("Đã cập nhật dữ liệu", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gvwNhapHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = LichSuNhapHangBUS.GetLSNhapHang();
                gvwNhapHang.DataSource = bindingSource;
            }
        }
    }
}
