
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class LichSuNhapHangForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuNhapHangForm));
            this.tpl = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gvwTTCT = new DevExpress.XtraGrid.GridControl();
            this.gvwTTTCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTTCT = new System.Windows.Forms.Label();
            this.gvwNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gvwTableNH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblLichSuNhapHang = new System.Windows.Forms.Label();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.lblTDT = new System.Windows.Forms.Label();
            this.picHistory = new DevExpress.XtraEditors.PictureEdit();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tpl)).BeginInit();
            this.tpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTTCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTTTCT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTableNH)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tpl
            // 
            this.tpl.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36.63F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 23.37F)});
            this.tpl.Controls.Add(this.tablePanel1);
            this.tpl.Controls.Add(this.gvwNhapHang);
            this.tpl.Controls.Add(this.pnl1);
            this.tpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl.Location = new System.Drawing.Point(0, 0);
            this.tpl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpl.Name = "tpl";
            this.tpl.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 93.2001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tpl.Size = new System.Drawing.Size(1294, 646);
            this.tpl.TabIndex = 1;
            // 
            // tablePanel1
            // 
            this.tpl.SetColumn(this.tablePanel1, 1);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.gvwTTCT);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(793, 96);
            this.tablePanel1.Name = "tablePanel1";
            this.tpl.SetRow(this.tablePanel1, 1);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(498, 547);
            this.tablePanel1.TabIndex = 5;
            // 
            // gvwTTCT
            // 
            this.tablePanel1.SetColumn(this.gvwTTCT, 0);
            this.gvwTTCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvwTTCT.Location = new System.Drawing.Point(3, 53);
            this.gvwTTCT.MainView = this.gvwTTTCT;
            this.gvwTTCT.Name = "gvwTTCT";
            this.tablePanel1.SetRow(this.gvwTTCT, 1);
            this.gvwTTCT.Size = new System.Drawing.Size(492, 491);
            this.gvwTTCT.TabIndex = 1;
            this.gvwTTCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwTTTCT});
            // 
            // gvwTTTCT
            // 
            this.gvwTTTCT.GridControl = this.gvwTTCT;
            this.gvwTTTCT.Name = "gvwTTTCT";
            // 
            // panel1
            // 
            this.tablePanel1.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTTCT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 0);
            this.panel1.Size = new System.Drawing.Size(492, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(9, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 1);
            this.panel3.TabIndex = 10;
            // 
            // lblTTCT
            // 
            this.lblTTCT.AutoSize = true;
            this.lblTTCT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTCT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTTCT.Location = new System.Drawing.Point(5, 11);
            this.lblTTCT.Name = "lblTTCT";
            this.lblTTCT.Size = new System.Drawing.Size(149, 21);
            this.lblTTCT.TabIndex = 0;
            this.lblTTCT.Text = "Thông Tin Chi Tiết";
            // 
            // gvwNhapHang
            // 
            this.tpl.SetColumn(this.gvwNhapHang, 0);
            this.gvwNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvwNhapHang.Location = new System.Drawing.Point(3, 96);
            this.gvwNhapHang.MainView = this.gvwTableNH;
            this.gvwNhapHang.Name = "gvwNhapHang";
            this.tpl.SetRow(this.gvwNhapHang, 1);
            this.gvwNhapHang.Size = new System.Drawing.Size(784, 547);
            this.gvwNhapHang.TabIndex = 4;
            this.gvwNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwTableNH});
            this.gvwNhapHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvwNhapHang_KeyDown);
            // 
            // gvwTableNH
            // 
            this.gvwTableNH.GridControl = this.gvwNhapHang;
            this.gvwTableNH.Name = "gvwTableNH";
            this.gvwTableNH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvwTableNH_RowClick);
            this.gvwTableNH.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvwTableNH_RowUpdated);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpl.SetColumn(this.pnl1, 0);
            this.tpl.SetColumnSpan(this.pnl1, 2);
            this.pnl1.Controls.Add(this.lblLichSuNhapHang);
            this.pnl1.Controls.Add(this.txtTongChi);
            this.pnl1.Controls.Add(this.lblTDT);
            this.pnl1.Controls.Add(this.picHistory);
            this.pnl1.Controls.Add(this.dateNgay);
            this.pnl1.Controls.Add(this.lblNgay);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(3, 2);
            this.pnl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl1.Name = "pnl1";
            this.tpl.SetRow(this.pnl1, 0);
            this.pnl1.Size = new System.Drawing.Size(1288, 89);
            this.pnl1.TabIndex = 0;
            // 
            // lblLichSuNhapHang
            // 
            this.lblLichSuNhapHang.AutoSize = true;
            this.lblLichSuNhapHang.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLichSuNhapHang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSuNhapHang.ForeColor = System.Drawing.Color.White;
            this.lblLichSuNhapHang.Location = new System.Drawing.Point(121, 2);
            this.lblLichSuNhapHang.Name = "lblLichSuNhapHang";
            this.lblLichSuNhapHang.Size = new System.Drawing.Size(260, 37);
            this.lblLichSuNhapHang.TabIndex = 8;
            this.lblLichSuNhapHang.Text = "Lịch Sử Nhập Hàng";
            // 
            // txtTongChi
            // 
            this.txtTongChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChi.Location = new System.Drawing.Point(499, 53);
            this.txtTongChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(192, 29);
            this.txtTongChi.TabIndex = 7;
            // 
            // lblTDT
            // 
            this.lblTDT.AutoSize = true;
            this.lblTDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDT.ForeColor = System.Drawing.Color.White;
            this.lblTDT.Location = new System.Drawing.Point(415, 56);
            this.lblTDT.Name = "lblTDT";
            this.lblTDT.Size = new System.Drawing.Size(78, 21);
            this.lblTDT.TabIndex = 6;
            this.lblTDT.Text = "Tổng Chi";
            // 
            // picHistory
            // 
            this.picHistory.EditValue = ((object)(resources.GetObject("picHistory.EditValue")));
            this.picHistory.Location = new System.Drawing.Point(13, 15);
            this.picHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHistory.Name = "picHistory";
            this.picHistory.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picHistory.Properties.Appearance.Options.UseBackColor = true;
            this.picHistory.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picHistory.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picHistory.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picHistory.Size = new System.Drawing.Size(102, 50);
            this.picHistory.TabIndex = 5;
            // 
            // dateNgay
            // 
            this.dateNgay.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(189, 50);
            this.dateNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Size = new System.Drawing.Size(192, 29);
            this.dateNgay.TabIndex = 1;
            this.dateNgay.ValueChanged += new System.EventHandler(this.dateNgay_ValueChanged);
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(123, 56);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(51, 21);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // LichSuNhapHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpl);
            this.Name = "LichSuNhapHangForm";
            this.Size = new System.Drawing.Size(1294, 646);
            this.Load += new System.EventHandler(this.LichSuNhapHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tpl)).EndInit();
            this.tpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvwTTCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTTTCT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwTableNH)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tpl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTTCT;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.Label lblTDT;
        private DevExpress.XtraEditors.PictureEdit picHistory;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.Label lblNgay;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gvwTTCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwTTTCT;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gvwNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwTableNH;
        private System.Windows.Forms.Label lblLichSuNhapHang;
    }
}
