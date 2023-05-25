using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Menu_login : Form
    {
        public Menu_login()
        {
            InitializeComponent();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Client_NV NV = new Client_NV();
            NV.ShowDialog();
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            Client_QL QL = new Client_QL();
            QL.ShowDialog();
        }
    }
}
