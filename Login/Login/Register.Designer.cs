namespace Login
{
    partial class Register
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
            cbShowPass = new CheckBox();
            label = new Label();
            btn_register = new Button();
            label2 = new Label();
            lb_username = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            txtConfirmPass = new TextBox();
            lb_backtologin = new LinkLabel();
            label4 = new Label();
            txt_fullname = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Checked = true;
            cbShowPass.CheckState = CheckState.Checked;
            cbShowPass.Location = new Point(275, 354);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(164, 29);
            cbShowPass.TabIndex = 16;
            cbShowPass.Text = "Show password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(156, 449);
            label.Name = "label";
            label.Size = new Size(218, 25);
            label.TabIndex = 14;
            label.Text = "Already have an account ?";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(204, 401);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(112, 34);
            btn_register.TabIndex = 13;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 265);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(79, 202);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(95, 25);
            lb_username.TabIndex = 11;
            lb_username.Text = "Username:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(204, 196);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(235, 31);
            txt_username.TabIndex = 10;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(204, 259);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(235, 31);
            txt_password.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 323);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 18;
            label1.Text = "Confirm password:";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(204, 317);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(235, 31);
            txtConfirmPass.TabIndex = 17;
            // 
            // lb_backtologin
            // 
            lb_backtologin.AutoSize = true;
            lb_backtologin.Location = new Point(204, 492);
            lb_backtologin.Name = "lb_backtologin";
            lb_backtologin.Size = new Size(115, 25);
            lb_backtologin.TabIndex = 19;
            lb_backtologin.TabStop = true;
            lb_backtologin.Text = "Back to login";
            lb_backtologin.LinkClicked += lb_backtologin_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 136);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 21;
            label4.Text = "Full name:";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(204, 130);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(235, 31);
            txt_fullname.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 56);
            label3.Name = "label3";
            label3.Size = new Size(174, 41);
            label3.TabIndex = 24;
            label3.Text = "Get started!";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 542);
            Controls.Add(label3);
            Controls.Add(txt_fullname);
            Controls.Add(label4);
            Controls.Add(lb_backtologin);
            Controls.Add(label1);
            Controls.Add(txtConfirmPass);
            Controls.Add(cbShowPass);
            Controls.Add(label);
            Controls.Add(btn_register);
            Controls.Add(label2);
            Controls.Add(lb_username);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbShowPass;
        private Label label;
        private Button btn_register;
        private Label label2;
        private Label lb_username;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private TextBox txtConfirmPass;
        private LinkLabel lb_backtologin;
        private Label label4;
        private TextBox txt_fullname;
        private Label label3;
    }
}