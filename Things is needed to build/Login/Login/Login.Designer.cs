namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lb_username = new Label();
            label2 = new Label();
            btn_login = new Button();
            label1 = new Label();
            cbShowPass = new CheckBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(128, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 234);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(128, 341);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(235, 31);
            txt_password.TabIndex = 1;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(128, 269);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(235, 31);
            txt_username.TabIndex = 2;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(10, 275);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(95, 25);
            lb_username.TabIndex = 3;
            lb_username.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 347);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(184, 428);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 477);
            label1.Name = "label1";
            label1.Size = new Size(419, 25);
            label1.TabIndex = 6;
            label1.Text = "If you don't have any account, please register here !";
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Checked = true;
            cbShowPass.CheckState = CheckState.Checked;
            cbShowPass.Location = new Point(242, 393);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(164, 29);
            cbShowPass.TabIndex = 8;
            cbShowPass.Text = "Show password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(196, 515);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(506, 564);
            Controls.Add(linkLabel1);
            Controls.Add(cbShowPass);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(lb_username);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label lb_username;
        private Label label2;
        private Button btn_login;
        private Label label1;
        private CheckBox cbShowPass;
        private LinkLabel linkLabel1;
    }
}