using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.Common;

namespace Login
{
    public partial class Register : Form
    { 
        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - CTIQ4C3\SQLEXPRESS; Initial Catalog = Restaurant_Management; Integrated Security = True");
        SqlCommand command;
        public SqlDataAdapter adapter;
        List<SqlParameter>parameters = new List<SqlParameter>();
        public DataTable dataTable;
        public int recordcount;
        public string exception;

        public void query(string name)
        {
            recordcount = 0;
            exception = null;
            try
            {
                connection.Open();
                command = new SqlCommand(name, connection);
                parameters.ForEach(p => command.Parameters.Add(p));
                parameters.Clear();
                dataTable = new DataTable();
                adapter = new SqlDataAdapter(command);
                recordcount = adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close(); 
                }    
            }
        }

        public void Param(string name, object value)
        {
            SqlParameter mew_parameter = new SqlParameter(name, value);
            parameters.Add(mew_parameter);
        }

        public bool Checking_Error(bool error = false)
        {
            if(string.IsNullOrEmpty(exception))
            {
                return false;
            }    
            if(error == true)
            {
                MessageBox.Show(exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            return true;
        }

        public Register()
        {
            InitializeComponent();
        }

        void register_func()
        {
            Param("@fullname", txt_fullname.Text);
            Param("@user", txt_username.Text);
            Param("@pass", txt_password.Text);
            query("insert into taikhoan (MATK, TENDANGNHAP, HOTEN, MATKHAU, VAITRO) values (@matk, @user, @fullname, @pass, @vaitro)");
            if(Checking_Error(true))
            {
                return;
            }
            MessageBox.Show("Bạn đã tạo tài khoản thành công!");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           
            if (txt_password.Text == txtConfirmPass.Text)
            {
                register_func();
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không trùng khớp! Vui lòng nhập lại");
            }

            
        }

        private void lb_backtologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txt_password.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }
    }
}
