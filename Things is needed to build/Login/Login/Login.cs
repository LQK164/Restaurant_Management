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

namespace Login
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - CTIQ4C3\SQLEXPRESS; Initial Catalog = Restaurant_Management; Integrated Security = True");
        SqlCommand command;
        public SqlDataAdapter adapter;
        List<SqlParameter> parameters = new List<SqlParameter>();
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
                if (connection.State == ConnectionState.Open)
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
            if (string.IsNullOrEmpty(exception))
            {
                return false;
            }
            if (error == true)
            {
                MessageBox.Show(exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        bool login()
        {
            
            Param("@user", txt_username.Text);
            Param("@pass", txt_password.Text);
            query("select count(*) from taikhoan where usr = @usr and pass = @pass");
            if ((int)dataTable.Rows[0][0] == 1)
            {
                return true;
            }
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ !");
            return false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        
    }
}