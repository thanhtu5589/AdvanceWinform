namespace QuanLyLinhKien
{
    partial class uc_NhanVienKho
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
            this.mns_Main = new System.Windows.Forms.MenuStrip();
            this.SanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaiSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuNhapHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuXuatHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mns_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_Main
            // 
            this.mns_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mns_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.mns_Main.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.mns_Main.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.mns_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SanPhamToolStripMenuItem,
            this.LoaiSanPhamToolStripMenuItem,
            this.PhieuNhapHangToolStripMenuItem,
            this.PhieuXuatHangToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.mns_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mns_Main.Location = new System.Drawing.Point(0, 0);
            this.mns_Main.Name = "mns_Main";
            this.mns_Main.Size = new System.Drawing.Size(340, 530);
            this.mns_Main.TabIndex = 0;
            this.mns_Main.Text = "menuStrip1";
            // 
            // SanPhamToolStripMenuItem
            // 
            this.SanPhamToolStripMenuItem.Image = global::QuanLyLinhKien.Properties.Resources.box_packing_peanut_512;
            this.SanPhamToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem";
            this.SanPhamToolStripMenuItem.Size = new System.Drawing.Size(333, 84);
            this.SanPhamToolStripMenuItem.Text = "Sản phẩm";
            this.SanPhamToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SanPhamToolStripMenuItem.Click += new System.EventHandler(this.SanPhamToolStripMenuItem_Click);
            // 
            // LoaiSanPhamToolStripMenuItem
            // 
            this.LoaiSanPhamToolStripMenuItem.Image = global::QuanLyLinhKien.Properties.Resources.TheLoai;
            this.LoaiSanPhamToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoaiSanPhamToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LoaiSanPhamToolStripMenuItem.Name = "LoaiSanPhamToolStripMenuItem";
            this.LoaiSanPhamToolStripMenuItem.Size = new System.Drawing.Size(333, 84);
            this.LoaiSanPhamToolStripMenuItem.Text = "Loại sản phẩm";
            this.LoaiSanPhamToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoaiSanPhamToolStripMenuItem.Click += new System.EventHandler(this.LoaiSanPhamToolStripMenuItem_Click);
            // 
            // PhieuNhapHangToolStripMenuItem
            // 
            this.PhieuNhapHangToolStripMenuItem.Image = global::QuanLyLinhKien.Properties.Resources.HDNhap;
            this.PhieuNhapHangToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhieuNhapHangToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PhieuNhapHangToolStripMenuItem.Name = "PhieuNhapHangToolStripMenuItem";
            this.PhieuNhapHangToolStripMenuItem.Size = new System.Drawing.Size(333, 84);
            this.PhieuNhapHangToolStripMenuItem.Text = "Phiếu nhập hàng";
            this.PhieuNhapHangToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhieuNhapHangToolStripMenuItem.Click += new System.EventHandler(this.PhieuNhapHangToolStripMenuItem_Click);
            // 
            // PhieuXuatHangToolStripMenuItem
            // 
            this.PhieuXuatHangToolStripMenuItem.Image = global::QuanLyLinhKien.Properties.Resources.HDBan;
            this.PhieuXuatHangToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhieuXuatHangToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PhieuXuatHangToolStripMenuItem.Name = "PhieuXuatHangToolStripMenuItem";
            this.PhieuXuatHangToolStripMenuItem.Size = new System.Drawing.Size(333, 84);
            this.PhieuXuatHangToolStripMenuItem.Text = "Phiếu xuất hàng";
            this.PhieuXuatHangToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhieuXuatHangToolStripMenuItem.Click += new System.EventHandler(this.PhieuXuatHangToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Image = global::QuanLyLinhKien.Properties.Resources.previous_1;
            this.DangXuatToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DangXuatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(333, 84);
            this.DangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.DangXuatToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Location = new System.Drawing.Point(413, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1184, 794);
            this.pnlMain.TabIndex = 1;
            // 
            // uc_NhanVienKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mns_Main);
            this.Name = "uc_NhanVienKho";
            this.Size = new System.Drawing.Size(1600, 800);
            this.mns_Main.ResumeLayout(false);
            this.mns_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Main;
        private System.Windows.Forms.ToolStripMenuItem SanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoaiSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuNhapHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuXuatHangToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;

    }
}
