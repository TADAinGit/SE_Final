using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class NhapHangForm : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVienBUS currentUser = new NhanVienBUS();
        List<string> ls = new List<string>();

        public string GetMaNhanVien()
        {
            return currentUser.GetUserInformation().MaNhanVien;
        }

        public NhapHangForm()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NhapHangForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            txtId.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtGiaThanh.Enabled = false;
            txtTongTien.Text = "0";
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = NhapHangBUS.GetDsThuoc();
            gvwNhapHang.DataSource = bindingSource;

            gvwDuLieuNH.OptionsView.ShowGroupPanel = false;
            gvwDuLieuNH.OptionsFind.AlwaysVisible = true;

            gvwDuLieuNH.Columns["MASP"].Caption = "Mã Sản Phẩm";
            gvwDuLieuNH.Columns["MANCC"].Caption = "Mã Nhà Cung Cấp";
            gvwDuLieuNH.Columns["LOAISP"].Caption = "Loại Sản Phẩm";
            gvwDuLieuNH.Columns["TENSP"].Caption = "Tên Sản Phẩm";
            gvwDuLieuNH.Columns["DVT"].Caption = "Đơn Vị Tính";
            gvwDuLieuNH.Columns["GIANHAP"].Caption = "Giá Nhập";
            gvwDuLieuNH.Columns["MOTA"].Caption = "Mô Tả";

            gvwDuLieuNH.Columns["MASP"].OptionsColumn.ReadOnly = true;
            gvwDuLieuNH.Columns["MANCC"].OptionsColumn.ReadOnly = true;
            gvwDuLieuNH.Columns["LOAISP"].OptionsColumn.ReadOnly = true;
            gvwDuLieuNH.Columns["TENSP"].OptionsColumn.ReadOnly = true;
            gvwDuLieuNH.Columns["DVT"].OptionsColumn.ReadOnly = true;
            gvwDuLieuNH.Columns["GIANHAP"].OptionsColumn.ReadOnly = true;
            gvwDuLieuNH.Columns["MOTA"].OptionsColumn.ReadOnly = true;

        }

        private void gvwDuLieuNH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtId.Text = gvwDuLieuNH.GetRowCellValue(gvwDuLieuNH.FocusedRowHandle, "MASP").ToString();
            txtTenSanPham.Text = gvwDuLieuNH.GetRowCellValue(gvwDuLieuNH.FocusedRowHandle, "TENSP").ToString();
            txtGiaThanh.Text = gvwDuLieuNH.GetRowCellValue(gvwDuLieuNH.FocusedRowHandle, "GIANHAP").ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(nudAmount.Value);
            int countGiaThanh = int.Parse(txtGiaThanh.Text);
            int countTongTien = countGiaThanh * count;
            txtTongTien.Text = (int.Parse(txtTongTien.Text) + countTongTien).ToString();
            string[] row = { txtId.Text, txtTenSanPham.Text, count.ToString(), countTongTien.ToString() };
            var listViewItem = new ListViewItem(row);
            lstviewNhapHang.Items.Add(listViewItem);

            ls.Add(txtId.Text);
            ls.Add(count.ToString());

        }

        private void btnGiam10_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(nudAmount.Value) - 10;
            if (count <= 0)
                nudAmount.Value = 1;
            else
                nudAmount.Value = count;
        }

        private void btnGiam100_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(nudAmount.Value) - 100;
            if (count <= 0)
                nudAmount.Value = 1;
            else
                nudAmount.Value = count;
        }

        private void btnTang10_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(nudAmount.Value) + 10;
            nudAmount.Value = count;
        }

        private void btnTang100_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(nudAmount.Value) + 100;
            nudAmount.Value = count;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstviewNhapHang.Items.Clear();
            txtTongTien.Text = "0";
            ls.Clear();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTongTien.Text.Equals("0"))
                {
                    string maNV = GetMaNhanVien();
                    int add = NhapHangBUS.InsertDonNhapMoi(new object[] { maNV, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString(), Convert.ToDecimal(txtTongTien.Text), false });
                    int CT = 0;
                    for (int i = 0; i < ls.Count(); i += 2)
                    {
                        CT = CT + NhapHangBUS.InsertCTDN(new object[] { ls[i], Convert.ToInt32(ls[i + 1]) });
                    }
                    if (CT + add == lstviewNhapHang.Items.Count + 1)
                    {
                        MessageBox.Show("Đã thêm 1 đơn nhập", "Thành Công", MessageBoxButtons.OK);
                        lstviewNhapHang.Items.Clear();
                        txtTongTien.Text = "0";
                        ls.Clear();
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Có lỗi xảy ra: " + s.Message, "Thất Bại", MessageBoxButtons.OK);
            }
        }

        private void gvwNhapHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = NhapHangBUS.GetDsThuoc();
                gvwNhapHang.DataSource = bindingSource;
            }
        }

        private void gvwDuLieuNH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = NhapHangBUS.GetDsThuoc();
                gvwNhapHang.DataSource = bindingSource;
            }
        }
    }
}
