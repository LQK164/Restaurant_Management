namespace Client
{
    partial class Client_QL
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
            this.tc_database = new System.Windows.Forms.TabControl();
            this.tp_NhanVien = new System.Windows.Forms.TabPage();
            this.tp_Mon = new System.Windows.Forms.TabPage();
            this.tp_Ban = new System.Windows.Forms.TabPage();
            this.tp_HoaDon = new System.Windows.Forms.TabPage();
            this.tp_KhachHang = new System.Windows.Forms.TabPage();
            this.tp_CTHD = new System.Windows.Forms.TabPage();
            this.tc_database.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_database
            // 
            this.tc_database.Controls.Add(this.tp_NhanVien);
            this.tc_database.Controls.Add(this.tp_Mon);
            this.tc_database.Controls.Add(this.tp_Ban);
            this.tc_database.Controls.Add(this.tp_HoaDon);
            this.tc_database.Controls.Add(this.tp_KhachHang);
            this.tc_database.Controls.Add(this.tp_CTHD);
            this.tc_database.Location = new System.Drawing.Point(13, 8);
            this.tc_database.Name = "tc_database";
            this.tc_database.SelectedIndex = 0;
            this.tc_database.Size = new System.Drawing.Size(775, 434);
            this.tc_database.TabIndex = 1;
            // 
            // tp_NhanVien
            // 
            this.tp_NhanVien.Location = new System.Drawing.Point(4, 29);
            this.tp_NhanVien.Name = "tp_NhanVien";
            this.tp_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tp_NhanVien.Size = new System.Drawing.Size(767, 401);
            this.tp_NhanVien.TabIndex = 0;
            this.tp_NhanVien.Text = "NhanVien";
            this.tp_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tp_Mon
            // 
            this.tp_Mon.Location = new System.Drawing.Point(4, 29);
            this.tp_Mon.Name = "tp_Mon";
            this.tp_Mon.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Mon.Size = new System.Drawing.Size(767, 401);
            this.tp_Mon.TabIndex = 1;
            this.tp_Mon.Text = "Mon";
            this.tp_Mon.UseVisualStyleBackColor = true;
            // 
            // tp_Ban
            // 
            this.tp_Ban.Location = new System.Drawing.Point(4, 29);
            this.tp_Ban.Name = "tp_Ban";
            this.tp_Ban.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Ban.Size = new System.Drawing.Size(767, 401);
            this.tp_Ban.TabIndex = 2;
            this.tp_Ban.Text = "Ban";
            this.tp_Ban.UseVisualStyleBackColor = true;
            // 
            // tp_HoaDon
            // 
            this.tp_HoaDon.Location = new System.Drawing.Point(4, 29);
            this.tp_HoaDon.Name = "tp_HoaDon";
            this.tp_HoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tp_HoaDon.Size = new System.Drawing.Size(767, 401);
            this.tp_HoaDon.TabIndex = 3;
            this.tp_HoaDon.Text = "HoaDon";
            this.tp_HoaDon.UseVisualStyleBackColor = true;
            // 
            // tp_KhachHang
            // 
            this.tp_KhachHang.Location = new System.Drawing.Point(4, 29);
            this.tp_KhachHang.Name = "tp_KhachHang";
            this.tp_KhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tp_KhachHang.Size = new System.Drawing.Size(767, 401);
            this.tp_KhachHang.TabIndex = 4;
            this.tp_KhachHang.Text = "KhachHang";
            this.tp_KhachHang.UseVisualStyleBackColor = true;
            // 
            // tp_CTHD
            // 
            this.tp_CTHD.Location = new System.Drawing.Point(4, 29);
            this.tp_CTHD.Name = "tp_CTHD";
            this.tp_CTHD.Padding = new System.Windows.Forms.Padding(3);
            this.tp_CTHD.Size = new System.Drawing.Size(767, 401);
            this.tp_CTHD.TabIndex = 5;
            this.tp_CTHD.Text = "CTHD";
            this.tp_CTHD.UseVisualStyleBackColor = true;
            // 
            // Client_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_database);
            this.Name = "Client_QL";
            this.Text = "Quản lý";
            this.tc_database.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_database;
        private System.Windows.Forms.TabPage tp_NhanVien;
        private System.Windows.Forms.TabPage tp_Mon;
        private System.Windows.Forms.TabPage tp_Ban;
        private System.Windows.Forms.TabPage tp_HoaDon;
        private System.Windows.Forms.TabPage tp_KhachHang;
        private System.Windows.Forms.TabPage tp_CTHD;
    }
}