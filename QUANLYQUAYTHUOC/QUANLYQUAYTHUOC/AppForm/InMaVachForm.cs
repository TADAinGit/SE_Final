using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using BUS;

namespace QUANLYQUAYTHUOC.AppForm
{
    public partial class InMaVachForm : DevExpress.XtraEditors.XtraUserControl
    {
        SanPhamBanBUS sanPham = new SanPhamBanBUS();
        NhaCungCapBUS nhaCungCap = new NhaCungCapBUS();

        public InMaVachForm()
        {
            InitializeComponent();
            sanPham.LoadComboBoxLoaiSanPham(cbLocLoaiSanPham);
            nhaCungCap.LoadComboBoxTenNhaCungCap(cbNhaCungCap);
            List<TextBox> listTextBox = new List<TextBox>();
            listTextBox.Add(txtID);
            listTextBox.Add(txtTenSanPham);
            sanPham.GetTextBox(listTextBox);
        }

        private void InMaVachForm_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            sanPham.LoadSanPham(fpnSanPham);
        }

        // Tạo mã vạch
        private void btnTaoMaVach_Click(object sender, EventArgs e)
        {
            if (txtID.TextLength > 0) 
            {
                string encode = Base64Encode(txtID.Text + " - " + txtTenSanPham.Text);
                barcodeControl.Text = encode;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }


        // In tem mã vạch
        private void btnInTemMaVach_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\AppResource\\barcode.pdf";
            
            if (barcodeControl.Text != "Default") 
            {
                Document document = new Document(PageSize.A4, 10, 10, 35, 35);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                document.Open();

                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont baseFont = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                Paragraph paragraph = new Paragraph(txtID + " - " + txtTenSanPham.Text,font);
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph);
                

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(barcodeControl.ExportToImage(), System.Drawing.Imaging.ImageFormat.Png);
                image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                document.Add(image);

                document.Add(new Paragraph("\n"));

                PdfPTable table = new PdfPTable(3);
                for (int i = 0; i < 10; i++) 
                {
                    table.AddCell(image);
                    table.AddCell(image);
                    table.AddCell(image);
                }
                
                document.Add(table);
                document.Close();
            }
        }

        private void btnLocSanPham_Click(object sender, EventArgs e)
        {
            int maSanPham = 0;
            string tenSanPham = "";
            string loaiSanPham = "";
            string tenNhaCungCap = "";

            if (txtFilterMa.TextLength > 0) maSanPham = int.Parse(txtFilterMa.Text);
            if (txtFilterTen.TextLength > 0) tenSanPham = txtFilterTen.Text;
            if (cbLocLoaiSanPham.SelectedItem != null) loaiSanPham = cbLocLoaiSanPham.SelectedItem.ToString();
            if (cbNhaCungCap.SelectedItem != null) tenNhaCungCap = cbNhaCungCap.SelectedItem.ToString();

            sanPham.LoadFilterSanPham(fpnSanPham, maSanPham, tenSanPham, loaiSanPham, tenNhaCungCap);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFilterMa.Clear();
            txtFilterTen.Clear();
            cbLocLoaiSanPham.SelectedItem = null;
            cbNhaCungCap.SelectedItem = null;
            sanPham.ResetSanPham(fpnSanPham);
        }

        private void txtFilterMa_KeyPress(object sender, KeyPressEventArgs e)
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
}
