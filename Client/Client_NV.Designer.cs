namespace Client
{
    partial class Client_NV
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
            this.lb_table_status = new System.Windows.Forms.Label();
            this.lb_total_payment = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_order_table = new System.Windows.Forms.Button();
            this.cb_name = new System.Windows.Forms.ComboBox();
            this.btn_add_dish = new System.Windows.Forms.Button();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_NGAYHD = new System.Windows.Forms.TextBox();
            this.lb_NGAYHD = new System.Windows.Forms.Label();
            this.txt_MABAN = new System.Windows.Forms.TextBox();
            this.lb_MABAN = new System.Windows.Forms.Label();
            this.txt_MANV = new System.Windows.Forms.TextBox();
            this.lb_MANV = new System.Windows.Forms.Label();
            this.txt_MAHD = new System.Windows.Forms.TextBox();
            this.lb_MAHD = new System.Windows.Forms.Label();
            this.txt_MAKH = new System.Windows.Forms.TextBox();
            this.lb_MAKH = new System.Windows.Forms.Label();
            this.btn_table1 = new System.Windows.Forms.Button();
            this.btn_table2 = new System.Windows.Forms.Button();
            this.btn_table3 = new System.Windows.Forms.Button();
            this.btn_table4 = new System.Windows.Forms.Button();
            this.btn_table5 = new System.Windows.Forms.Button();
            this.btn_table6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.TENMON = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.THANHTIEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_table_status
            // 
            this.lb_table_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_table_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_table_status.Location = new System.Drawing.Point(12, 474);
            this.lb_table_status.Name = "lb_table_status";
            this.lb_table_status.Size = new System.Drawing.Size(410, 39);
            this.lb_table_status.TabIndex = 6;
            this.lb_table_status.Text = "Tình trạng bàn:";
            // 
            // lb_total_payment
            // 
            this.lb_total_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_total_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_payment.Location = new System.Drawing.Point(12, 513);
            this.lb_total_payment.Name = "lb_total_payment";
            this.lb_total_payment.Size = new System.Drawing.Size(410, 39);
            this.lb_total_payment.TabIndex = 7;
            this.lb_total_payment.Text = "Tổng tiền:";
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(13, 560);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(194, 72);
            this.btn_pay.TabIndex = 8;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_order_table
            // 
            this.btn_order_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_table.Location = new System.Drawing.Point(229, 560);
            this.btn_order_table.Name = "btn_order_table";
            this.btn_order_table.Size = new System.Drawing.Size(194, 72);
            this.btn_order_table.TabIndex = 9;
            this.btn_order_table.Text = "Đặt bàn";
            this.btn_order_table.UseVisualStyleBackColor = true;
            this.btn_order_table.Click += new System.EventHandler(this.btn_order_table_Click);
            // 
            // cb_name
            // 
            this.cb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_name.FormattingEnabled = true;
            this.cb_name.Location = new System.Drawing.Point(437, 16);
            this.cb_name.Name = "cb_name";
            this.cb_name.Size = new System.Drawing.Size(435, 40);
            this.cb_name.TabIndex = 12;
            this.cb_name.Text = "Tên món";
            // 
            // btn_add_dish
            // 
            this.btn_add_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_dish.Location = new System.Drawing.Point(871, 13);
            this.btn_add_dish.Name = "btn_add_dish";
            this.btn_add_dish.Size = new System.Drawing.Size(133, 86);
            this.btn_add_dish.TabIndex = 13;
            this.btn_add_dish.Text = "Thêm món";
            this.btn_add_dish.UseVisualStyleBackColor = true;
            this.btn_add_dish.Click += new System.EventHandler(this.btn_add_dish_Click);
            // 
            // lb_quantity
            // 
            this.lb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantity.Location = new System.Drawing.Point(430, 110);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(158, 52);
            this.lb_quantity.TabIndex = 14;
            this.lb_quantity.Text = "Số lượng:";
            this.lb_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(595, 110);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 51);
            this.txt_quantity.TabIndex = 15;
            // 
            // txt_NGAYHD
            // 
            this.txt_NGAYHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NGAYHD.Location = new System.Drawing.Point(1195, 290);
            this.txt_NGAYHD.Name = "txt_NGAYHD";
            this.txt_NGAYHD.Size = new System.Drawing.Size(252, 51);
            this.txt_NGAYHD.TabIndex = 19;
            // 
            // lb_NGAYHD
            // 
            this.lb_NGAYHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NGAYHD.Location = new System.Drawing.Point(1010, 290);
            this.lb_NGAYHD.Name = "lb_NGAYHD";
            this.lb_NGAYHD.Size = new System.Drawing.Size(179, 52);
            this.lb_NGAYHD.TabIndex = 18;
            this.lb_NGAYHD.Text = "NGAYHD:";
            this.lb_NGAYHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MABAN
            // 
            this.txt_MABAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MABAN.Location = new System.Drawing.Point(1195, 224);
            this.txt_MABAN.Name = "txt_MABAN";
            this.txt_MABAN.Size = new System.Drawing.Size(252, 51);
            this.txt_MABAN.TabIndex = 21;
            // 
            // lb_MABAN
            // 
            this.lb_MABAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MABAN.Location = new System.Drawing.Point(1010, 224);
            this.lb_MABAN.Name = "lb_MABAN";
            this.lb_MABAN.Size = new System.Drawing.Size(179, 52);
            this.lb_MABAN.TabIndex = 20;
            this.lb_MABAN.Text = "MABAN:";
            this.lb_MABAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MANV
            // 
            this.txt_MANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANV.Location = new System.Drawing.Point(1195, 154);
            this.txt_MANV.Name = "txt_MANV";
            this.txt_MANV.Size = new System.Drawing.Size(252, 51);
            this.txt_MANV.TabIndex = 23;
            // 
            // lb_MANV
            // 
            this.lb_MANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MANV.Location = new System.Drawing.Point(1010, 154);
            this.lb_MANV.Name = "lb_MANV";
            this.lb_MANV.Size = new System.Drawing.Size(179, 52);
            this.lb_MANV.TabIndex = 22;
            this.lb_MANV.Text = "MANV:";
            this.lb_MANV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MAHD
            // 
            this.txt_MAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAHD.Location = new System.Drawing.Point(1195, 16);
            this.txt_MAHD.Name = "txt_MAHD";
            this.txt_MAHD.Size = new System.Drawing.Size(252, 51);
            this.txt_MAHD.TabIndex = 25;
            // 
            // lb_MAHD
            // 
            this.lb_MAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MAHD.Location = new System.Drawing.Point(1010, 16);
            this.lb_MAHD.Name = "lb_MAHD";
            this.lb_MAHD.Size = new System.Drawing.Size(179, 52);
            this.lb_MAHD.TabIndex = 24;
            this.lb_MAHD.Text = "MAHD:";
            this.lb_MAHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MAKH
            // 
            this.txt_MAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKH.Location = new System.Drawing.Point(1195, 83);
            this.txt_MAKH.Name = "txt_MAKH";
            this.txt_MAKH.Size = new System.Drawing.Size(252, 51);
            this.txt_MAKH.TabIndex = 29;
            // 
            // lb_MAKH
            // 
            this.lb_MAKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MAKH.Location = new System.Drawing.Point(1010, 83);
            this.lb_MAKH.Name = "lb_MAKH";
            this.lb_MAKH.Size = new System.Drawing.Size(179, 52);
            this.lb_MAKH.TabIndex = 28;
            this.lb_MAKH.Text = "MAKH:";
            this.lb_MAKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_table1
            // 
            this.btn_table1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table1.Location = new System.Drawing.Point(12, 12);
            this.btn_table1.Name = "btn_table1";
            this.btn_table1.Size = new System.Drawing.Size(133, 129);
            this.btn_table1.TabIndex = 0;
            this.btn_table1.Text = "Bàn 1";
            this.btn_table1.UseVisualStyleBackColor = true;
            this.btn_table1.Click += new System.EventHandler(this.btn_table1_Click);
            // 
            // btn_table2
            // 
            this.btn_table2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table2.Location = new System.Drawing.Point(151, 12);
            this.btn_table2.Name = "btn_table2";
            this.btn_table2.Size = new System.Drawing.Size(133, 129);
            this.btn_table2.TabIndex = 1;
            this.btn_table2.Text = "Bàn 2";
            this.btn_table2.UseVisualStyleBackColor = true;
            this.btn_table2.Click += new System.EventHandler(this.btn_table2_Click);
            // 
            // btn_table3
            // 
            this.btn_table3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table3.Location = new System.Drawing.Point(290, 12);
            this.btn_table3.Name = "btn_table3";
            this.btn_table3.Size = new System.Drawing.Size(133, 129);
            this.btn_table3.TabIndex = 2;
            this.btn_table3.Text = "Bàn 3";
            this.btn_table3.UseVisualStyleBackColor = true;
            this.btn_table3.Click += new System.EventHandler(this.btn_table3_Click);
            // 
            // btn_table4
            // 
            this.btn_table4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table4.Location = new System.Drawing.Point(12, 167);
            this.btn_table4.Name = "btn_table4";
            this.btn_table4.Size = new System.Drawing.Size(133, 129);
            this.btn_table4.TabIndex = 3;
            this.btn_table4.Text = "Bàn 4";
            this.btn_table4.UseVisualStyleBackColor = true;
            this.btn_table4.Click += new System.EventHandler(this.btn_table4_Click);
            // 
            // btn_table5
            // 
            this.btn_table5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table5.Location = new System.Drawing.Point(151, 167);
            this.btn_table5.Name = "btn_table5";
            this.btn_table5.Size = new System.Drawing.Size(133, 129);
            this.btn_table5.TabIndex = 4;
            this.btn_table5.Text = "Bàn 5";
            this.btn_table5.UseVisualStyleBackColor = true;
            this.btn_table5.Click += new System.EventHandler(this.btn_table5_Click);
            // 
            // btn_table6
            // 
            this.btn_table6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table6.Location = new System.Drawing.Point(290, 167);
            this.btn_table6.Name = "btn_table6";
            this.btn_table6.Size = new System.Drawing.Size(133, 129);
            this.btn_table6.TabIndex = 5;
            this.btn_table6.Text = "Bàn 6";
            this.btn_table6.UseVisualStyleBackColor = true;
            this.btn_table6.Click += new System.EventHandler(this.btn_table6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(86, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 44);
            this.textBox1.TabIndex = 30;
            // 
            // lv_Bill
            // 
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TENMON,
            this.SOLUONG,
            this.GIA,
            this.THANHTIEN});
            this.lv_Bill.HideSelection = false;
            this.lv_Bill.Location = new System.Drawing.Point(437, 165);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(574, 466);
            this.lv_Bill.TabIndex = 31;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // TENMON
            // 
            this.TENMON.Text = "Tên món ăn";
            this.TENMON.Width = 100;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Text = "Số lượng";
            this.SOLUONG.Width = 90;
            // 
            // GIA
            // 
            this.GIA.Text = "Giá (VND)";
            this.GIA.Width = 95;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.Text = "Thành tiền (VND)";
            this.THANHTIEN.Width = 164;
            // 
            // Client_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 644);
            this.Controls.Add(this.lv_Bill);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_MAKH);
            this.Controls.Add(this.lb_MAKH);
            this.Controls.Add(this.txt_MAHD);
            this.Controls.Add(this.lb_MAHD);
            this.Controls.Add(this.txt_MANV);
            this.Controls.Add(this.lb_MANV);
            this.Controls.Add(this.txt_MABAN);
            this.Controls.Add(this.lb_MABAN);
            this.Controls.Add(this.txt_NGAYHD);
            this.Controls.Add(this.lb_NGAYHD);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lb_quantity);
            this.Controls.Add(this.btn_add_dish);
            this.Controls.Add(this.cb_name);
            this.Controls.Add(this.btn_order_table);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.lb_total_payment);
            this.Controls.Add(this.lb_table_status);
            this.Controls.Add(this.btn_table6);
            this.Controls.Add(this.btn_table5);
            this.Controls.Add(this.btn_table4);
            this.Controls.Add(this.btn_table3);
            this.Controls.Add(this.btn_table2);
            this.Controls.Add(this.btn_table1);
            this.Name = "Client_NV";
            this.Text = "Nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_table_status;
        private System.Windows.Forms.Label lb_total_payment;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_order_table;
        private System.Windows.Forms.ComboBox cb_name;
        private System.Windows.Forms.Button btn_add_dish;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_NGAYHD;
        private System.Windows.Forms.Label lb_NGAYHD;
        private System.Windows.Forms.TextBox txt_MABAN;
        private System.Windows.Forms.Label lb_MABAN;
        private System.Windows.Forms.TextBox txt_MANV;
        private System.Windows.Forms.Label lb_MANV;
        private System.Windows.Forms.TextBox txt_MAHD;
        private System.Windows.Forms.Label lb_MAHD;
        private System.Windows.Forms.TextBox txt_MAKH;
        private System.Windows.Forms.Label lb_MAKH;
        private System.Windows.Forms.Button btn_table1;
        private System.Windows.Forms.Button btn_table2;
        private System.Windows.Forms.Button btn_table3;
        private System.Windows.Forms.Button btn_table4;
        private System.Windows.Forms.Button btn_table5;
        private System.Windows.Forms.Button btn_table6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.ColumnHeader TENMON;
        private System.Windows.Forms.ColumnHeader SOLUONG;
        private System.Windows.Forms.ColumnHeader GIA;
        private System.Windows.Forms.ColumnHeader THANHTIEN;
    }
}

