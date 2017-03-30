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

namespace IHRM.Data
{
    public partial class Add_Super : Form
    {
        public Add_Super()
        {
            InitializeComponent();
        }

        private void add_super_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_super_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_super_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_super_add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(add_super_id.Text);
                string name = add_super_name.Text;
                string emailid = add_super_email.Text;
                int aadharUid = int.Parse(add_super_aadharUid.Text);
                string aadharString = add_super_aadharString.Text;
                string password = add_super_password.Text;

                //Insert into database
                MySqlCommand sql_site_insert = new MySqlCommand("INSERT INTO supervisour_users(id,name,email,aadhar_uid,aadhar_string,password,gid)values(" + id + ",'" + name + "','" + emailid + "','" + aadharUid + "','" + aadharString + "'," + password + "'" + Utils.Session.getUsername() + "');", Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                MySqlDataReader insert_site = sql_site_insert.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Utils.MySql.myConn.Close();
            }
        }
    }
}
