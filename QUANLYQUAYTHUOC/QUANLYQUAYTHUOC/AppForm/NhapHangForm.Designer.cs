
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class NhapHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHangForm));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tpnl2 = new DevExpress.Utils.Layout.TablePanel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lstviewNhapHang = new System.Windows.Forms.ListView();
            this.clnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGiaTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnGiam10 = new System.Windows.Forms.Button();
            this.btnGiam100 = new System.Windows.Forms.Button();
            this.btnTang100 = new System.Windows.Forms.Button();
            this.btnTang10 = new System.Windows.Forms.Button();
            this.picEditAdd = new DevExpress.XtraEditors.PictureEdit();
            this.txtGiaThanh = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.gvwNhapHang = new DevExpress.XtraGrid.GridControl();
            this.gvwDuLieuNH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlDanhSachSanPham = new System.Windows.Forms.Panel();
            this.pnlDSSP = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.picEditList = new DevExpress.XtraEditors.PictureEdit();
            this.lblDanhSachSP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpnl2)).BeginInit();
            this.tpnl2.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDuLieuNH)).BeginInit();
            this.pnlDanhSachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditList.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 29.85F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30.15F)});
            this.tablePanel1.Controls.Add(this.tpnl2);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Controls.Add(this.gvwNhapHang);
            this.tablePanel1.Controls.Add(this.pnlDanhSachSanPham);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 168.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 57.99997F)});
            this.tablePanel1.Size = new System.Drawing.Size(1531, 568);
            this.tablePanel1.TabIndex = 0;
            // 
            // tpnl2
            // 
            this.tpnl2.Appearance.BackColor = System.Drawing.Color.White;
            this.tpnl2.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.tpnl2, 1);
            this.tpnl2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tpnl2.Controls.Add(this.pnl2);
            this.tpnl2.Controls.Add(this.lstviewNhapHang);
            this.tpnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnl2.Location = new System.Drawing.Point(765, 171);
            this.tpnl2.Name = "tpnl2";
            this.tablePanel1.SetRow(this.tpnl2, 1);
            this.tpnl2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 71.20001F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tpnl2.Size = new System.Drawing.Size(763, 394);
            this.tpnl2.TabIndex = 8;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tpnl2.SetColumn(this.pnl2, 0);
            this.pnl2.Controls.Add(this.btnReset);
            this.pnl2.Controls.Add(this.btnNhapHang);
            this.pnl2.Controls.Add(this.txtTongTien);
            this.pnl2.Controls.Add(this.lblTong);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(3, 3);
            this.pnl2.Name = "pnl2";
            this.tpnl2.SetRow(this.pnl2, 0);
            this.pnl2.Size = new System.Drawing.Size(757, 65);
            this.pnl2.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.Location = new System.Drawing.Point(432, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.BackColor = System.Drawing.Color.White;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNhapHang.Location = new System.Drawing.Point(584, 8);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(147, 34);
            this.btnNhapHang.TabIndex = 2;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTongTien.Location = new System.Drawing.Point(119, 9);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(207, 29);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.White;
            this.lblTong.Location = new System.Drawing.Point(27, 12);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(86, 21);
            this.lblTong.TabIndex = 0;
            this.lblTong.Text = "Tổng Tiền";
            // 
            // lstviewNhapHang
            // 
            this.tpnl2.SetColumn(this.lstviewNhapHang, 0);
            this.lstviewNhapHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnID,
            this.clnTen,
            this.clnSoLuong,
            this.clnGiaTien});
            this.lstviewNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstviewNhapHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstviewNhapHang.GridLines = true;
            this.lstviewNhapHang.HideSelection = false;
            this.lstviewNhapHang.Location = new System.Drawing.Point(3, 73);
            this.lstviewNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstviewNhapHang.Name = "lstviewNhapHang";
            this.tpnl2.SetRow(this.lstviewNhapHang, 1);
            this.lstviewNhapHang.Size = new System.Drawing.Size(757, 319);
            this.lstviewNhapHang.TabIndex = 2;
            this.lstviewNhapHang.UseCompatibleStateImageBehavior = false;
            this.lstviewNhapHang.View = System.Windows.Forms.View.Details;
            // 
            // clnID
            // 
            this.clnID.Text = "ID";
            this.clnID.Width = 127;
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên";
            this.clnTen.Width = 132;
            // 
            // clnSoLuong
            // 
            this.clnSoLuong.Text = "Số lượng";
            this.clnSoLuong.Width = 87;
            // 
            // clnGiaTien
            // 
            this.clnGiaTien.Text = "Giá tiền";
            this.clnGiaTien.Width = 121;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tablePanel1.SetColumn(this.panel1, 1);
            this.panel1.Controls.Add(this.nudAmount);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnGiam10);
            this.panel1.Controls.Add(this.btnGiam100);
            this.panel1.Controls.Add(this.btnTang100);
            this.panel1.Controls.Add(this.btnTang10);
            this.panel1.Controls.Add(this.picEditAdd);
            this.panel1.Controls.Add(this.txtGiaThanh);
            this.panel1.Controls.Add(this.txtTenSanPham);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(765, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.tablePanel1.SetRow(this.panel1, 0);
            this.panel1.Size = new System.Drawing.Size(763, 164);
            this.panel1.TabIndex = 7;
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.White;
            this.nudAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nudAmount.Location = new System.Drawing.Point(209, 75);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(164, 29);
            this.nudAmount.TabIndex = 22;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Location = new System.Drawing.Point(588, 67);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 38);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnGiam10
            // 
            this.btnGiam10.BackColor = System.Drawing.Color.White;
            this.btnGiam10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiam10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGiam10.Location = new System.Drawing.Point(122, 75);
            this.btnGiam10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiam10.Name = "btnGiam10";
            this.btnGiam10.Size = new System.Drawing.Size(82, 29);
            this.btnGiam10.TabIndex = 21;
            this.btnGiam10.Text = "-10";
            this.btnGiam10.UseVisualStyleBackColor = false;
            this.btnGiam10.Click += new System.EventHandler(this.btnGiam10_Click);
            // 
            // btnGiam100
            // 
            this.btnGiam100.BackColor = System.Drawing.Color.White;
            this.btnGiam100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiam100.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam100.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGiam100.Location = new System.Drawing.Point(34, 75);
            this.btnGiam100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiam100.Name = "btnGiam100";
            this.btnGiam100.Size = new System.Drawing.Size(82, 29);
            this.btnGiam100.TabIndex = 20;
            this.btnGiam100.Text = "-100";
            this.btnGiam100.UseVisualStyleBackColor = false;
            this.btnGiam100.Click += new System.EventHandler(this.btnGiam100_Click);
            // 
            // btnTang100
            // 
            this.btnTang100.BackColor = System.Drawing.Color.White;
            this.btnTang100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTang100.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang100.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTang100.Location = new System.Drawing.Point(467, 75);
            this.btnTang100.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTang100.Name = "btnTang100";
            this.btnTang100.Size = new System.Drawing.Size(82, 29);
            this.btnTang100.TabIndex = 24;
            this.btnTang100.Text = "+100";
            this.btnTang100.UseVisualStyleBackColor = false;
            this.btnTang100.Click += new System.EventHandler(this.btnTang100_Click);
            // 
            // btnTang10
            // 
            this.btnTang10.BackColor = System.Drawing.Color.White;
            this.btnTang10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTang10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTang10.Location = new System.Drawing.Point(378, 75);
            this.btnTang10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTang10.Name = "btnTang10";
            this.btnTang10.Size = new System.Drawing.Size(82, 29);
            this.btnTang10.TabIndex = 23;
            this.btnTang10.Text = "+10";
            this.btnTang10.UseVisualStyleBackColor = false;
            this.btnTang10.Click += new System.EventHandler(this.btnTang10_Click);
            // 
            // picEditAdd
            // 
            this.picEditAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picEditAdd.EditValue = ((object)(resources.GetObject("picEditAdd.EditValue")));
            this.picEditAdd.Location = new System.Drawing.Point(637, 11);
            this.picEditAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEditAdd.Name = "picEditAdd";
            this.picEditAdd.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picEditAdd.Properties.Appearance.Options.UseBackColor = true;
            this.picEditAdd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEditAdd.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEditAdd.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEditAdd.Size = new System.Drawing.Size(63, 57);
            this.picEditAdd.TabIndex = 16;
            // 
            // txtGiaThanh
            // 
            this.txtGiaThanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtGiaThanh.Location = new System.Drawing.Point(417, 14);
            this.txtGiaThanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaThanh.Name = "txtGiaThanh";
            this.txtGiaThanh.Size = new System.Drawing.Size(133, 29);
            this.txtGiaThanh.TabIndex = 19;
            this.txtGiaThanh.Text = "Giá thành";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTenSanPham.Location = new System.Drawing.Point(159, 14);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(253, 29);
            this.txtTenSanPham.TabIndex = 18;
            this.txtTenSanPham.Text = "Tên sản phẩm";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtId.Location = new System.Drawing.Point(33, 14);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 29);
            this.txtId.TabIndex = 17;
            this.txtId.Text = "ID";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(29, 46);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 21);
            this.lblSoLuong.TabIndex = 15;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // gvwNhapHang
            // 
            this.tablePanel1.SetColumn(this.gvwNhapHang, 0);
            this.gvwNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvwNhapHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvwNhapHang.Location = new System.Drawing.Point(3, 170);
            this.gvwNhapHang.MainView = this.gvwDuLieuNH;
            this.gvwNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvwNhapHang.Name = "gvwNhapHang";
            this.tablePanel1.SetRow(this.gvwNhapHang, 1);
            this.gvwNhapHang.Size = new System.Drawing.Size(756, 396);
            this.gvwNhapHang.TabIndex = 6;
            this.gvwNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwDuLieuNH});
            this.gvwNhapHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvwNhapHang_KeyDown);
            // 
            // gvwDuLieuNH
            // 
            this.gvwDuLieuNH.DetailHeight = 268;
            this.gvwDuLieuNH.GridControl = this.gvwNhapHang;
            this.gvwDuLieuNH.Name = "gvwDuLieuNH";
            this.gvwDuLieuNH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvwDuLieuNH_RowClick);
            this.gvwDuLieuNH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvwDuLieuNH_KeyDown);
            // 
            // pnlDanhSachSanPham
            // 
            this.pnlDanhSachSanPham.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tablePanel1.SetColumn(this.pnlDanhSachSanPham, 0);
            this.pnlDanhSachSanPham.Controls.Add(this.pnlDSSP);
            this.pnlDanhSachSanPham.Controls.Add(this.pictureEdit1);
            this.pnlDanhSachSanPham.Controls.Add(this.picEditList);
            this.pnlDanhSachSanPham.Controls.Add(this.lblDanhSachSP);
            this.pnlDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSachSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDanhSachSanPham.Location = new System.Drawing.Point(3, 2);
            this.pnlDanhSachSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDanhSachSanPham.Name = "pnlDanhSachSanPham";
            this.tablePanel1.SetRow(this.pnlDanhSachSanPham, 0);
            this.pnlDanhSachSanPham.Size = new System.Drawing.Size(756, 164);
            this.pnlDanhSachSanPham.TabIndex = 5;
            // 
            // pnlDSSP
            // 
            this.pnlDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDSSP.BackColor = System.Drawing.Color.White;
            this.pnlDSSP.Location = new System.Drawing.Point(219, 75);
            this.pnlDSSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDSSP.Name = "pnlDSSP";
            this.pnlDSSP.Size = new System.Drawing.Size(316, 1);
            this.pnlDSSP.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(611, 10);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(97, 89);
            this.pictureEdit1.TabIndex = 5;
            // 
            // picEditList
            // 
            this.picEditList.EditValue = ((object)(resources.GetObject("picEditList.EditValue")));
            this.picEditList.Location = new System.Drawing.Point(57, 10);
            this.picEditList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEditList.Name = "picEditList";
            this.picEditList.Properties.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picEditList.Properties.Appearance.Options.UseBackColor = true;
            this.picEditList.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picEditList.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picEditList.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picEditList.Size = new System.Drawing.Size(97, 90);
            this.picEditList.TabIndex = 5;
            // 
            // lblDanhSachSP
            // 
            this.lblDanhSachSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDanhSachSP.AutoSize = true;
            this.lblDanhSachSP.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachSP.ForeColor = System.Drawing.Color.White;
            this.lblDanhSachSP.Location = new System.Drawing.Point(236, 36);
            this.lblDanhSachSP.Name = "lblDanhSachSP";
            this.lblDanhSachSP.Size = new System.Drawing.Size(277, 37);
            this.lblDanhSachSP.TabIndex = 0;
            this.lblDanhSachSP.Text = "Danh sách sản phẩm";
            // 
            // NhapHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhapHangForm";
            this.Size = new System.Drawing.Size(1531, 568);
            this.Load += new System.EventHandler(this.NhapHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tpnl2)).EndInit();
            this.tpnl2.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDuLieuNH)).EndInit();
            this.pnlDanhSachSanPham.ResumeLayout(false);
            this.pnlDanhSachSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditList.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label lblDanhSachSP;
        private System.Windows.Forms.Panel pnlDanhSachSanPham;
        private DevExpress.XtraEditors.PictureEdit picEditList;
        private DevExpress.XtraGrid.GridControl gvwNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwDuLieuNH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnGiam10;
        private System.Windows.Forms.Button btnGiam100;
        private System.Windows.Forms.Button btnTang100;
        private System.Windows.Forms.Button btnTang10;
        private DevExpress.XtraEditors.PictureEdit picEditAdd;
        private System.Windows.Forms.TextBox txtGiaThanh;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblSoLuong;
        private DevExpress.Utils.Layout.TablePanel tpnl2;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.ListView lstviewNhapHang;
        private System.Windows.Forms.ColumnHeader clnID;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnSoLuong;
        private System.Windows.Forms.ColumnHeader clnGiaTien;
        private System.Windows.Forms.Button btnReset;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel pnlDSSP;
    }
}
