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
                string id = add_super_id.Text;
                string name = add_super_name.Text;
                string emailid = add_super_email.Text;
                string aadharUid = add_super_aadharUid.Text;
                string aadharString = add_super_aadharString.Text;
                string password = add_super_password.Text;
                string siteid = add_super_siteId.Text;

                //Insert into database
                MySqlCommand sql_super_insert = new MySqlCommand("INSERT INTO hrm_database.supervisor_users(name,sid,email,aadhar_uid,aadhar_string,password,gid)values('" + name + "','" + int.Parse(siteid) + "','" + emailid + "','" + int.Parse(aadharUid) + "','" + aadharString + "','" + password + "','" + Utils.Session.getId() + "');", Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                sql_super_insert.ExecuteNonQuery();
                Utils.MySql.myConn.Close();
                MessageBox.Show("Successfully Added.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_super_id.Text = "";
                add_super_name.Text = "";
                add_super_email.Text = "";
                add_super_aadharUid.Text = "";
                add_super_password.Text = "";
                add_super_password.Text = "";
                add_super_siteId.Text = "";
                add_super_name.Focus();
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
