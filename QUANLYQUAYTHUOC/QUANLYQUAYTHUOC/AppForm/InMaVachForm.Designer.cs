
namespace QUANLYQUAYTHUOC.AppForm
{
    partial class InMaVachForm
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator3 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLocSanPham = new System.Windows.Forms.Button();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cbLocLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.lbLocLoaiSanPham = new System.Windows.Forms.Label();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbFilterMa = new System.Windows.Forms.Label();
            this.txtFilterMa = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbIDSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.barcodeControl = new DevExpress.XtraEditors.BarCodeControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaoMaVach = new System.Windows.Forms.Button();
            this.btnInTemMaVach = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.lbFilterTen = new System.Windows.Forms.Label();
            this.txtFilterTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 439.9F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.1F)});
            this.tablePanel1.Controls.Add(this.panel7);
            this.tablePanel1.Controls.Add(this.panel5);
            this.tablePanel1.Controls.Add(this.panel3);
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 137F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 44F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 452F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 132F)});
            this.tablePanel1.Size = new System.Drawing.Size(1328, 758);
            this.tablePanel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.tablePanel1.SetColumn(this.panel7, 1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnReset);
            this.panel7.Controls.Add(this.btnLocSanPham);
            this.panel7.Controls.Add(this.cbNhaCungCap);
            this.panel7.Controls.Add(this.cbLocLoaiSanPham);
            this.panel7.Controls.Add(this.lbFilterTen);
            this.panel7.Controls.Add(this.lbLocLoaiSanPham);
            this.panel7.Controls.Add(this.lbNhaCungCap);
            this.panel7.Controls.Add(this.lbFilterMa);
            this.panel7.Controls.Add(this.txtFilterTen);
            this.panel7.Controls.Add(this.txtFilterMa);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(443, 3);
            this.panel7.Name = "panel7";
            this.tablePanel1.SetRow(this.panel7, 0);
            this.tablePanel1.SetRowSpan(this.panel7, 2);
            this.panel7.Size = new System.Drawing.Size(882, 175);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 175);
            this.panel8.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderSize = 3;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(346, 137);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(285, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLocSanPham
            // 
            this.btnLocSanPham.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLocSanPham.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLocSanPham.FlatAppearance.BorderSize = 3;
            this.btnLocSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLocSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLocSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocSanPham.ForeColor = System.Drawing.Color.White;
            this.btnLocSanPham.Location = new System.Drawing.Point(29, 137);
            this.btnLocSanPham.Name = "btnLocSanPham";
            this.btnLocSanPham.Size = new System.Drawing.Size(285, 31);
            this.btnLocSanPham.TabIndex = 2;
            this.btnLocSanPham.Text = "Lọc sản phẩm";
            this.btnLocSanPham.UseVisualStyleBackColor = false;
            this.btnLocSanPham.Click += new System.EventHandler(this.btnLocSanPham_Click);
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(346, 87);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(285, 29);
            this.cbNhaCungCap.TabIndex = 1;
            // 
            // cbLocLoaiSanPham
            // 
            this.cbLocLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbLocLoaiSanPham.FormattingEnabled = true;
            this.cbLocLoaiSanPham.Location = new System.Drawing.Point(29, 87);
            this.cbLocLoaiSanPham.Name = "cbLocLoaiSanPham";
            this.cbLocLoaiSanPham.Size = new System.Drawing.Size(285, 29);
            this.cbLocLoaiSanPham.TabIndex = 1;
            // 
            // lbLocLoaiSanPham
            // 
            this.lbLocLoaiSanPham.AutoSize = true;
            this.lbLocLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbLocLoaiSanPham.Location = new System.Drawing.Point(25, 64);
            this.lbLocLoaiSanPham.Name = "lbLocLoaiSanPham";
            this.lbLocLoaiSanPham.Size = new System.Drawing.Size(110, 20);
            this.lbLocLoaiSanPham.TabIndex = 1;
            this.lbLocLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbNhaCungCap.Location = new System.Drawing.Point(342, 64);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(104, 20);
            this.lbNhaCungCap.TabIndex = 1;
            this.lbNhaCungCap.Text = "Nhà cung cấp";
            // 
            // lbFilterMa
            // 
            this.lbFilterMa.AutoSize = true;
            this.lbFilterMa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbFilterMa.Location = new System.Drawing.Point(25, 7);
            this.lbFilterMa.Name = "lbFilterMa";
            this.lbFilterMa.Size = new System.Drawing.Size(103, 20);
            this.lbFilterMa.TabIndex = 1;
            this.lbFilterMa.Text = "Mã sản phẩm";
            // 
            // txtFilterMa
            // 
            this.txtFilterMa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFilterMa.Location = new System.Drawing.Point(29, 30);
            this.txtFilterMa.Name = "txtFilterMa";
            this.txtFilterMa.Size = new System.Drawing.Size(285, 29);
            this.txtFilterMa.TabIndex = 0;
            this.txtFilterMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterMa_KeyPress);
            // 
            // panel5
            // 
            this.tablePanel1.SetColumn(this.panel5, 0);
            this.panel5.Controls.Add(this.lbTenSanPham);
            this.panel5.Controls.Add(this.lbIDSanPham);
            this.panel5.Controls.Add(this.txtTenSanPham);
            this.panel5.Controls.Add(this.txtID);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.tablePanel1.SetRow(this.panel5, 0);
            this.panel5.Size = new System.Drawing.Size(434, 131);
            this.panel5.TabIndex = 3;
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbTenSanPham.Location = new System.Drawing.Point(-1, 62);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(106, 20);
            this.lbTenSanPham.TabIndex = 1;
            this.lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // lbIDSanPham
            // 
            this.lbIDSanPham.AutoSize = true;
            this.lbIDSanPham.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbIDSanPham.Location = new System.Drawing.Point(-1, 7);
            this.lbIDSanPham.Name = "lbIDSanPham";
            this.lbIDSanPham.Size = new System.Drawing.Size(103, 20);
            this.lbIDSanPham.TabIndex = 1;
            this.lbIDSanPham.Text = "Mã sản phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenSanPham.Location = new System.Drawing.Point(3, 85);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(428, 29);
            this.txtTenSanPham.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(3, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(428, 29);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterMa_KeyPress);
            // 
            // panel3
            // 
            this.tablePanel1.SetColumn(this.panel3, 0);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 140);
            this.panel3.Name = "panel3";
            this.tablePanel1.SetRow(this.panel3, 1);
            this.tablePanel1.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(434, 509);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(434, 509);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.barcodeControl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(424, 499);
            this.panel6.TabIndex = 4;
            // 
            // barcodeControl
            // 
            this.barcodeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeControl.AutoModule = true;
            this.barcodeControl.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barcodeControl.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barcodeControl.Location = new System.Drawing.Point(36, 168);
            this.barcodeControl.MaximumSize = new System.Drawing.Size(350, 92);
            this.barcodeControl.MinimumSize = new System.Drawing.Size(350, 92);
            this.barcodeControl.Name = "barcodeControl";
            this.barcodeControl.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barcodeControl.Size = new System.Drawing.Size(350, 92);
            code128Generator3.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.barcodeControl.Symbology = code128Generator3;
            this.barcodeControl.TabIndex = 3;
            this.barcodeControl.Text = "Default";
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.btnTaoMaVach);
            this.panel2.Controls.Add(this.btnInTemMaVach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 655);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 3);
            this.panel2.Size = new System.Drawing.Size(434, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnTaoMaVach
            // 
            this.btnTaoMaVach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTaoMaVach.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaoMaVach.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTaoMaVach.FlatAppearance.BorderSize = 3;
            this.btnTaoMaVach.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaoMaVach.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaoMaVach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMaVach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTaoMaVach.ForeColor = System.Drawing.Color.White;
            this.btnTaoMaVach.Location = new System.Drawing.Point(0, 1);
            this.btnTaoMaVach.Name = "btnTaoMaVach";
            this.btnTaoMaVach.Size = new System.Drawing.Size(434, 42);
            this.btnTaoMaVach.TabIndex = 0;
            this.btnTaoMaVach.Text = "Tạo mã vạch";
            this.btnTaoMaVach.UseVisualStyleBackColor = false;
            this.btnTaoMaVach.Click += new System.EventHandler(this.btnTaoMaVach_Click);
            // 
            // btnInTemMaVach
            // 
            this.btnInTemMaVach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInTemMaVach.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInTemMaVach.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnInTemMaVach.FlatAppearance.BorderSize = 3;
            this.btnInTemMaVach.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInTemMaVach.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInTemMaVach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInTemMaVach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnInTemMaVach.ForeColor = System.Drawing.Color.White;
            this.btnInTemMaVach.Location = new System.Drawing.Point(0, 58);
            this.btnInTemMaVach.Name = "btnInTemMaVach";
            this.btnInTemMaVach.Size = new System.Drawing.Size(434, 42);
            this.btnInTemMaVach.TabIndex = 0;
            this.btnInTemMaVach.Text = "In mã vạch";
            this.btnInTemMaVach.UseVisualStyleBackColor = false;
            this.btnInTemMaVach.Click += new System.EventHandler(this.btnInTemMaVach_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tablePanel1.SetColumn(this.panel1, 1);
            this.panel1.Controls.Add(this.fpnSanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(443, 184);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.tablePanel1.SetRow(this.panel1, 2);
            this.tablePanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(882, 571);
            this.panel1.TabIndex = 0;
            // 
            // fpnSanPham
            // 
            this.fpnSanPham.BackColor = System.Drawing.Color.White;
            this.fpnSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnSanPham.Location = new System.Drawing.Point(5, 5);
            this.fpnSanPham.Name = "fpnSanPham";
            this.fpnSanPham.Size = new System.Drawing.Size(872, 561);
            this.fpnSanPham.TabIndex = 0;
            // 
            // lbFilterTen
            // 
            this.lbFilterTen.AutoSize = true;
            this.lbFilterTen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbFilterTen.Location = new System.Drawing.Point(342, 7);
            this.lbFilterTen.Name = "lbFilterTen";
            this.lbFilterTen.Size = new System.Drawing.Size(106, 20);
            this.lbFilterTen.TabIndex = 1;
            this.lbFilterTen.Text = "Tên sản phẩm";
            // 
            // txtFilterTen
            // 
            this.txtFilterTen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFilterTen.Location = new System.Drawing.Point(346, 30);
            this.txtFilterTen.Name = "txtFilterTen";
            this.txtFilterTen.Size = new System.Drawing.Size(285, 29);
            this.txtFilterTen.TabIndex = 0;
            // 
            // InMaVachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "InMaVachForm";
            this.Size = new System.Drawing.Size(1328, 758);
            this.Load += new System.EventHandler(this.InMaVachForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInTemMaVach;
        private System.Windows.Forms.Button btnTaoMaVach;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.BarCodeControl barcodeControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbIDSanPham;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLocSanPham;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.ComboBox cbLocLoaiSanPham;
        private System.Windows.Forms.Label lbLocLoaiSanPham;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbFilterMa;
        private System.Windows.Forms.TextBox txtFilterMa;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbFilterTen;
        private System.Windows.Forms.TextBox txtFilterTen;
    }
}
