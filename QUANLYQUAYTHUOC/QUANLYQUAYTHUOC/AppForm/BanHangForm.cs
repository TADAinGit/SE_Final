using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class BanHangForm : DevExpress.XtraEditors.XtraUserControl
    {   
        public BanHangForm()
        {
            InitializeComponent();
            //sanPham.LoadComboBoxLoaiSanPham(cbLocLoaiSanPham);
            //nhaCungCap.LoadComboBoxTenNhaCungCap(cbLocNhaCungCap);
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtMaSanPham);
            listTextBox.Add(txtTenSanPham);
            listTextBox.Add(txtLoaiSanPham);
            listTextBox.Add(txtGiaTien);
            listTextBox.Add(txtTongTien);
            //sanPham.GetTextBox(listTextBox);
            BanHangFacade.Instance.SetUpFilterData(cbLocLoaiSanPham, cbLocNhaCungCap, listTextBox);
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //sanPham.LoadSanPham(fpnlSanPham);
            BanHangFacade.Instance.SetUpData(fpnlSanPham);
        }

        private void btnGiam10_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value - 10 < 1) numSoLuong.Value = 1;
            else numSoLuong.Value -= 10;
        }

        private void btnGiam100_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value - 100 < 1) numSoLuong.Value = 1;
            else numSoLuong.Value -= 100;
        }

        private void btnTang10_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value + 10 > numSoLuong.Maximum) numSoLuong.Value = numSoLuong.Maximum;
            else numSoLuong.Value += 10;
        }

        private void btnTang100_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Value + 100 > numSoLuong.Maximum) numSoLuong.Value = numSoLuong.Maximum;
            else numSoLuong.Value += 100;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSanPham;
            string tenSanPham;
            int soLuong;
            int giaBan;
            if (txtMaSanPham.TextLength > 0) 
            {
                maSanPham = txtMaSanPham.Text;
                tenSanPham = txtTenSanPham.Text;
                soLuong = (int)numSoLuong.Value;
                giaBan = Int32.Parse(txtGiaTien.Text);

                //sanPham.AddItemToListView(listThongTinDonHang, int.Parse(maSanPham), tenSanPham, soLuong, giaBan);
                BanHangFacade.Instance.AddToBill(listThongTinDonHang, int.Parse(maSanPham), tenSanPham, soLuong, giaBan);
                UpdateTotalPrice();
                // Reset số lượng
                ResetBill(false);
            }
        }

        private void UpdateTotalPrice() 
        {
            decimal total = 0;
            // Duyệt giá của từng sản phẩm
            foreach (ListViewItem items in listThongTinDonHang.Items) 
            {
                total += decimal.Parse(items.SubItems[4].Text);
            }
            txtTongTien.Text = total.ToString();
        }

        private void txtTienNhan_EditValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTienNhan.Text, out decimal tienNhan) && decimal.TryParse(txtTongTien.Text, out decimal tongTien))
            {
                // Tính tiền thừa
                if (tienNhan >= tongTien)
                {
                    txtTienThua.Text = (tienNhan - tongTien).ToString();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maHD;
            string tenKH = "Unknown";;
            string sdtKH = "Unknown"; ;

            // Check có hàng hoặc đã nhận tiền đủ/dư mới cho thanh toán
            if (listThongTinDonHang.Items.Count <= 0 || txtTienNhan.Text.Length <= 0) return;

            if (txtPhone.Text.Length > 0 && txtKhachHang.Text.Length > 0)
            {
                tenKH = txtKhachHang.Text;
                sdtKH = txtPhone.Text;
            }
            //maHD = sanPham.SaveInvoice(new MainForm().GetMaNhanVien(), sdtKH, tenKH, DateTime.Today, int.Parse(txtTongTien.Text), listThongTinDonHang);
            maHD = BanHangFacade.Instance.GenerateInvoice(new MainForm().GetMaNhanVien(), sdtKH, tenKH, DateTime.Today, int.Parse(txtTongTien.Text), listThongTinDonHang);
            if (chkInHoaDon.Checked)
            {
                if (maHD != 0)
                {
                    PrintContext context = new PrintContext(new InHoaDonStrategy(maHD,tenKH,sdtKH, txtTienNhan.Text, txtTienThua.Text));
                    context.Print();
                }
            }

            // Reset lại nội dung sau khi thanh toán
            ResetBill(true);
            //sanPham.ResetSanPham(fpnlSanPham);
            BanHangFacade.Instance.ResetData(fpnlSanPham);
            txtKhachHang.Clear();
            txtPhone.Clear();
            txtTienThua.ResetText();
            txtTienNhan.ResetText();
            txtTongTien.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBill(true);
            txtTongTien.Clear();
        }

        void ResetBill(bool listReset) 
        {
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtLoaiSanPham.Clear();
            txtGiaTien.Clear();
            if (listReset) listThongTinDonHang.Items.Clear();
            numSoLuong.Value = 1;
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Chỉ cho phép nhập vào số
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSanPham.TextLength > 0) 
            {
                //numSoLuong.Maximum = sanPham.GetProductByID(int.Parse(txtMaSanPham.Text)).SoLuong;
                numSoLuong.Maximum = BanHangFacade.Instance.GetProductById(int.Parse(txtMaSanPham.Text)).SoLuong;
            }
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            BanHangFacade.Instance.ResetData(fpnlSanPham);
            txtLocMaSanPham.Clear();
            txtLocTenSanPham.Clear();
            cbLocLoaiSanPham.SelectedItem = null;
            cbLocNhaCungCap.SelectedItem = null;
        }

        private void btnLocSanPham_Click(object sender, EventArgs e)
        {
            int maSanPham = 0;
            string tenSanPham = "";
            string loaiSanPham = "";
            string tenNhaCungCap = "";

            if (txtLocMaSanPham.TextLength > 0) maSanPham = int.Parse(txtLocMaSanPham.Text);
            if (txtTenSanPham.TextLength > 0) tenSanPham = txtLocTenSanPham.Text;
            if (cbLocLoaiSanPham.SelectedItem != null) loaiSanPham = cbLocLoaiSanPham.SelectedItem.ToString();
            if (cbLocNhaCungCap.SelectedItem != null) tenNhaCungCap = cbLocNhaCungCap.SelectedItem.ToString();

            BanHangFacade.Instance.LoadFilter(fpnlSanPham, maSanPham, tenSanPham, loaiSanPham, tenNhaCungCap);
        }

        private void txtLocMaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Chỉ cho phép nhập vào số
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

    public class BanHangFacade
    {
        private static BanHangFacade instance;

        private SanPhamBanBUS sanPham;
        private NhaCungCapBUS nhaCungCap;

        public static BanHangFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BanHangFacade();
                }
                return BanHangFacade.instance;
            }
        }

        public BanHangFacade()
        {
            sanPham = new SanPhamBanBUS();
            nhaCungCap = new NhaCungCapBUS();
        }

        public void SetUpFilterData(System.Windows.Forms.ComboBox cbLoaiSanPham, System.Windows.Forms.ComboBox cbNCC, List<TextBox> listTextBox)
        {
            sanPham.LoadComboBoxLoaiSanPham(cbLoaiSanPham);
            nhaCungCap.LoadComboBoxTenNhaCungCap(cbNCC);
            sanPham.GetTextBox(listTextBox);
        }

        public void SetUpData(FlowLayoutPanel panel)
        {
            sanPham.LoadSanPham(panel);
        }

        public void AddToBill(ListView bill, int maSP, string tenSP, int sl, float giaBan)
        {
            sanPham.AddItemToListView(bill, maSP, tenSP, sl, giaBan);
        }

        public int GenerateInvoice(string maNV, string sdtKH, string tenKH, DateTime date, int tongTien, ListView bill) 
        {
            return sanPham.SaveInvoice(maNV, sdtKH, tenKH, date, tongTien, bill);
        }

        public void ResetData(FlowLayoutPanel panel) 
        {
            sanPham.ResetSanPham(panel);
        }
        public SanPhamBan GetProductById(int id) 
        {
            return sanPham.GetProductByID(id);
        }
        public void LoadFilter(FlowLayoutPanel fpnlSanPham, int maSanPham, string tenSanPham, string loaiSanPham, string tenNhaCungCap) 
        {
            sanPham.LoadFilterSanPham(fpnlSanPham, maSanPham, tenSanPham, loaiSanPham, tenNhaCungCap);
        }
    }
}
