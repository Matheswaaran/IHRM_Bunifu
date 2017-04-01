using MySql.Data.MySqlClient;
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
            login_password.Text = "";
            login_password.isPassword = true;
            login_username.Focus();
        }

        private void login_loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_username.Text))
            {
                MessageBox.Show("Please enter a username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login_username.Focus();
                return;
            }
            try
            {
                //string pass = login_password.Text;
                //string md5pass = Utils.Global.CreateMD5(pass);
                MySqlCommand select = new MySqlCommand("Select * FROM hrm_database.goverment_users where name = '" + login_username.Text + "' and password = '" + login_password.Text + "';", Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                MySqlDataReader loginReader = select.ExecuteReader();
                int count = 0;
                while (loginReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    Utils.Session.setDetails(int.Parse(loginReader["gid"].ToString()), loginReader["name"].ToString());
                    MessageBox.Show("Login successful as " + Utils.Session.getId().ToString() + " - " + Utils.Session.getUsername().ToString() + ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    List.List listForm = new List.List();
                    listForm.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a valid credentials.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Utils.MySql.myConn.Close();
            }
        }

        private void login_password_OnValueChanged(object sender, EventArgs e)
        {
            login_password.isPassword = true;
        }

        private void login_about_Click(object sender, EventArgs e)
        {
            //login_username.Text = Utils.Global.CreateMD5(login_username.ToString());
        }
    }
}
