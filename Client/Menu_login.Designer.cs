namespace Client
{
    partial class Menu_login
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
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_QuanLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.AutoSize = true;
            this.btn_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.Location = new System.Drawing.Point(136, 178);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(216, 56);
            this.btn_NhanVien.TabIndex = 0;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.AutoSize = true;
            this.btn_QuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLy.Location = new System.Drawing.Point(448, 178);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Size = new System.Drawing.Size(216, 56);
            this.btn_QuanLy.TabIndex = 1;
            this.btn_QuanLy.Text = "Quản Lý";
            this.btn_QuanLy.UseVisualStyleBackColor = true;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // Menu_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_QuanLy);
            this.Controls.Add(this.btn_NhanVien);
            this.Name = "Menu_login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_QuanLy;
    }
}