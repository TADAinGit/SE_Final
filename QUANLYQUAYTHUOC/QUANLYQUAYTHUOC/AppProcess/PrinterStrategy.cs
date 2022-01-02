using BUS;
using QUANLYQUAYTHUOC.AppForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QUANLYQUAYTHUOC
{
    public interface PrinterStrategy
    {
        void Print();
    }

    public class PrintContext
    {
        private PrinterStrategy strategy;

        public PrintContext(PrinterStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void setPrintContext(PrinterStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Print()
        {
            strategy.Print();
        }
    }

    public class InHoaDonStrategy : PrinterStrategy
    {
        private int maHoaDon;
        private string tenKH;
        private string sdtKH;
        private string tienNhan;
        private string tienThua;

        public InHoaDonStrategy(int maHoaDon, string tenKH, string sdtKH, string tienNhan, string tienThua)
        {
            this.maHoaDon = maHoaDon;
            this.tenKH = tenKH;
            this.sdtKH = sdtKH;
            this.tienNhan = tienNhan;
            this.tienThua = tienThua;
        }

        public void Print()
        {
            HoaDonBUS hoaDon = new HoaDonBUS();
            InvoiceReport report = new InvoiceReport();

            foreach (DevExpress.XtraReports.Parameters.Parameter param in report.Parameters)
            {
                param.Visible = false;
            }

            string tenNhanVien = new NhanVienBUS().GetUserInformation().TenNhanVien;
            string maNhanVien = new NhanVienBUS().GetUserInformation().MaNhanVien;

            report.InitData(maHoaDon.ToString(), DateTime.Today, tenNhanVien, maNhanVien, tenKH, sdtKH, tienNhan, tienThua, hoaDon.GetInvoiceDetailById(maHoaDon));
            report.ExportToPdf(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\invoice.pdf");
        }
    }

    public class NoteStrategy : PrinterStrategy
    {
        private string txtAccount;
        private string txtPassword;

        public NoteStrategy(string txtAccount, string txtPassword)
        {
            this.txtAccount = txtAccount;
            this.txtPassword = txtPassword;
        }

        public void Print()
        {
            string path = "..\\..\\AppResource\\note.pdf";

            if (true)
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

                Paragraph paragraph = new Paragraph("Username: " + txtAccount, font);
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph);
                paragraph = new Paragraph("Password: " + txtPassword, font);
                paragraph.Alignment = Element.ALIGN_CENTER;
                document.Add(paragraph);

                document.Close();
            }
        }
    }

    public class InMaVachStrategy : PrinterStrategy
    {
        private System.Drawing.Image barcodeControl;
        private string tenSanPham;
        string txtID;

        public InMaVachStrategy(System.Drawing.Image barcodeControl, string tenSanPham, string txtID)
        {
            this.barcodeControl = barcodeControl;
            this.tenSanPham = tenSanPham;
            this.txtID = txtID;
        }

        public void Print()
        {
            string path = "..\\AppResource\\barcode.pdf";

            Document document = new Document(PageSize.A4, 10, 10, 35, 35);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            //Full path to the Unicode Arial file
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

            //Create a base font object making sure to specify IDENTITY-H
            BaseFont baseFont = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //Create a specific font object
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

            Paragraph paragraph = new Paragraph(txtID + " - " + tenSanPham, font);
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);


            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(barcodeControl, System.Drawing.Imaging.ImageFormat.Png);
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
}
