using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHRM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_reset_Click(object sender, EventArgs e)
        {
            login_username.Text = "";
            login_password.Text = "1";
            login_password.isPassword = true;
            login_username.Focus();
        }

        private void login_loginBtn_Click(object sender, EventArgs e)
        {
            List.List lsit = new List.List();
            lsit.Show();
        }

        private void login_password_OnValueChanged(object sender, EventArgs e)
        {
            login_password.isPassword = true;
        }
    }
}
