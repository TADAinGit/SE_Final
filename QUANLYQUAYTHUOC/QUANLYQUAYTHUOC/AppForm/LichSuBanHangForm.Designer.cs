
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class LichSuBanHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuBanHangForm));
            this.tpl = new DevExpress.Utils.Layout.TablePanel();
            this.tpl2 = new DevExpress.Utils.Layout.TablePanel();
            this.gridview2 = new DevExpress.XtraGrid.GridControl();
            this.gridTTCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTTCT = new System.Windows.Forms.Label();
            this.gridview = new DevExpress.XtraGrid.GridControl();
            this.gridLSBH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.lblLichSuBanHang = new System.Windows.Forms.Label();
            this.txtDoanhThuNgay = new System.Windows.Forms.TextBox();
            this.lblTDT = new System.Windows.Forms.Label();
            this.picHistory = new DevExpress.XtraEditors.PictureEdit();
            this.dateNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tpl)).BeginInit();
            this.tpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpl2)).BeginInit();
            this.tpl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTTCT)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLSBH)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tpl
            // 
            this.tpl.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.88F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.12F)});
            this.tpl.Controls.Add(this.tpl2);
            this.tpl.Controls.Add(this.gridview);
            this.tpl.Controls.Add(this.pnl1);
            this.tpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl.Location = new System.Drawing.Point(0, 0);
            this.tpl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpl.Name = "tpl";
            this.tpl.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90.2001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tpl.Size = new System.Drawing.Size(1291, 699);
            this.tpl.TabIndex = 0;
            // 
            // tpl2
            // 
            this.tpl.SetColumn(this.tpl2, 1);
            this.tpl2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tpl2.Controls.Add(this.gridview2);
            this.tpl2.Controls.Add(this.pnl3);
            this.tpl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl2.Location = new System.Drawing.Point(732, 93);
            this.tpl2.Name = "tpl2";
            this.tpl.SetRow(this.tpl2, 1);
            this.tpl2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 46F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tpl2.Size = new System.Drawing.Size(556, 603);
            this.tpl2.TabIndex = 5;
            // 
            // gridview2
            // 
            this.tpl2.SetColumn(this.gridview2, 0);
            this.gridview2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview2.Location = new System.Drawing.Point(3, 49);
            this.gridview2.MainView = this.gridTTCT;
            this.gridview2.Name = "gridview2";
            this.tpl2.SetRow(this.gridview2, 1);
            this.gridview2.Size = new System.Drawing.Size(550, 551);
            this.gridview2.TabIndex = 1;
            this.gridview2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTTCT});
            // 
            // gridTTCT
            // 
            this.gridTTCT.GridControl = this.gridview2;
            this.gridTTCT.Name = "gridTTCT";
            // 
            // pnl3
            // 
            this.tpl2.SetColumn(this.pnl3, 0);
            this.pnl3.Controls.Add(this.panel3);
            this.pnl3.Controls.Add(this.lblTTCT);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl3.Location = new System.Drawing.Point(3, 3);
            this.pnl3.Name = "pnl3";
            this.tpl2.SetRow(this.pnl3, 0);
            this.pnl3.Size = new System.Drawing.Size(550, 40);
            this.pnl3.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(9, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 1);
            this.panel3.TabIndex = 10;
            // 
            // lblTTCT
            // 
            this.lblTTCT.AutoSize = true;
            this.lblTTCT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTCT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTTCT.Location = new System.Drawing.Point(5, 10);
            this.lblTTCT.Name = "lblTTCT";
            this.lblTTCT.Size = new System.Drawing.Size(149, 21);
            this.lblTTCT.TabIndex = 0;
            this.lblTTCT.Text = "Thông Tin Chi Tiết";
            // 
            // gridview
            // 
            this.tpl.SetColumn(this.gridview, 0);
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(3, 93);
            this.gridview.MainView = this.gridLSBH;
            this.gridview.Name = "gridview";
            this.tpl.SetRow(this.gridview, 1);
            this.gridview.Size = new System.Drawing.Size(723, 603);
            this.gridview.TabIndex = 4;
            this.gridview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridLSBH});
            this.gridview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridview_KeyDown);
            // 
            // gridLSBH
            // 
            this.gridLSBH.GridControl = this.gridview;
            this.gridLSBH.Name = "gridLSBH";
            this.gridLSBH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridLSBH_RowClick);
            this.gridLSBH.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridLSBH_RowUpdated);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpl.SetColumn(this.pnl1, 0);
            this.tpl.SetColumnSpan(this.pnl1, 2);
            this.pnl1.Controls.Add(this.lblLichSuBanHang);
            this.pnl1.Controls.Add(this.txtDoanhThuNgay);
            this.pnl1.Controls.Add(this.lblTDT);
            this.pnl1.Controls.Add(this.picHistory);
            this.pnl1.Controls.Add(this.dateNgay);
            this.pnl1.Controls.Add(this.lblNgay);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(3, 2);
            this.pnl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl1.Name = "pnl1";
            this.tpl.SetRow(this.pnl1, 0);
            this.pnl1.Size = new System.Drawing.Size(1285, 86);
            this.pnl1.TabIndex = 0;
            // 
            // lblLichSuBanHang
            // 
            this.lblLichSuBanHang.AutoSize = true;
            this.lblLichSuBanHang.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLichSuBanHang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSuBanHang.ForeColor = System.Drawing.Color.White;
            this.lblLichSuBanHang.Location = new System.Drawing.Point(92, 2);
            this.lblLichSuBanHang.Name = "lblLichSuBanHang";
            this.lblLichSuBanHang.Size = new System.Drawing.Size(239, 37);
            this.lblLichSuBanHang.TabIndex = 9;
            this.lblLichSuBanHang.Text = "Lịch Sử Bán Hàng";
            // 
            // txtDoanhThuNgay
            // 
            this.txtDoanhThuNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuNgay.Location = new System.Drawing.Point(531, 48);
            this.txtDoanhThuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThuNgay.Name = "txtDoanhThuNgay";
            this.txtDoanhThuNgay.Size = new System.Drawing.Size(192, 29);
            this.txtDoanhThuNgay.TabIndex = 7;
            // 
            // lblTDT
            // 
            this.lblTDT.AutoSize = true;
            this.lblTDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDT.ForeColor = System.Drawing.Color.White;
            this.lblTDT.Location = new System.Drawing.Point(388, 51);
            this.lblTDT.Name = "lblTDT";
            this.lblTDT.Size = new System.Drawing.Size(137, 21);
            this.lblTDT.TabIndex = 6;
            this.lblTDT.Text = "Tổng Doanh Thu";
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
            this.picHistory.Size = new System.Drawing.Size(51, 49);
            this.picHistory.TabIndex = 5;
            // 
            // dateNgay
            // 
            this.dateNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgay.Location = new System.Drawing.Point(157, 50);
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
            this.lblNgay.Location = new System.Drawing.Point(100, 56);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(51, 21);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // LichSuBanHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LichSuBanHangForm";
            this.Size = new System.Drawing.Size(1291, 699);
            this.Load += new System.EventHandler(this.LichSuBanHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tpl)).EndInit();
            this.tpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpl2)).EndInit();
            this.tpl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTTCT)).EndInit();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLSBH)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tpl;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.DateTimePicker dateNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TextBox txtDoanhThuNgay;
        private System.Windows.Forms.Label lblTDT;
        private DevExpress.XtraEditors.PictureEdit picHistory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTTCT;
        private DevExpress.XtraGrid.GridControl gridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLSBH;
        private DevExpress.Utils.Layout.TablePanel tpl2;
        private DevExpress.XtraGrid.GridControl gridview2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTTCT;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label lblLichSuBanHang;
    }
}
