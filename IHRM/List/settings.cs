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

namespace IHRM.List
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            try
            {
                //string pass = login_password.Text;
                //string md5pass = Utils.Global.CreateMD5(pass);
                MySqlCommand select = new MySqlCommand("Select * FROM hrm_database.goverment_users where name = '" + Utils.Session.getUsername() + "' and password = '" + settings_cpwd.Text + "';", Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                MySqlDataReader loginReader = select.ExecuteReader();
                int count = 0;
                while (loginReader.Read())
                {
                    count = count + 1;
                }
                Utils.MySql.myConn.Close();
                if (count == 1)
                {
                    if(settings_newpwd.Text == settings_confimpwd.Text)
                    {
                        Utils.MySql.myConn.Open();
                        MySqlCommand changePass = new MySqlCommand("UPDATE hrm_database.goverment_users set Password = '" + settings_newpwd.Text + "' WHERE gid = " + Utils.Session.getId() + ";",Utils.MySql.myConn);
                        changePass.ExecuteNonQuery();
                        MessageBox.Show("The password changed Sucessfully.", "Change Passsword", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Utils.MySql.myConn.Close();
                    }
                    else
                    {
                        MessageBox.Show("The passwords does not match.","Change Password",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Current password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
