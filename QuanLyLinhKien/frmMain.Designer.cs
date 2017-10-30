namespace QuanLyLinhKien
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uc_NhanVienBanHang1 = new QuanLyLinhKien.uc_NhanVienBanHang();
            this.SuspendLayout();
            // 
            // uc_NhanVienBanHang1
            // 
            this.uc_NhanVienBanHang1.AutoSize = true;
            this.uc_NhanVienBanHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uc_NhanVienBanHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_NhanVienBanHang1.Location = new System.Drawing.Point(0, 0);
            this.uc_NhanVienBanHang1.Margin = new System.Windows.Forms.Padding(2);
            this.uc_NhanVienBanHang1.Name = "uc_NhanVienBanHang1";
            this.uc_NhanVienBanHang1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uc_NhanVienBanHang1.Size = new System.Drawing.Size(1346, 661);
            this.uc_NhanVienBanHang1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1346, 661);
            this.Controls.Add(this.uc_NhanVienBanHang1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng linh kiện máy tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uc_NhanVienBanHang uc_NhanVienBanHang1;

























    }
}

