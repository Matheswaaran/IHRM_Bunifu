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
    public partial class Add_Contract : Form
    {
        public Add_Contract()
        {
            InitializeComponent();
        }

        private void add_contract_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_contract_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_contract_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_contract_add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = add_Contract_id.Text;
                string name = add_Contract_name.Text;
                string emailid = add_Contract_email.Text;
                string aadharUid = add_Contract_aadharUid.Text;
                string aadharString = add_Contract_aadharString.Text;
                string password = add_Contract_password.Text;
                string siteid = add_Contract_siteId.Text;

                //Insert into database
                MySqlCommand sql_contract_insert = new MySqlCommand("INSERT INTO hrm_database.contract_users(name,sid,email,aadhar_uid,aadhar_string,password,gid)values('" + name + "','" + int.Parse(siteid) + "','" + emailid + "','" + int.Parse(aadharUid) + "','" + aadharString + "','" + password + "','" + Utils.Session.getId() + "');", Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                sql_contract_insert.ExecuteNonQuery();
                Utils.MySql.myConn.Close();
                MessageBox.Show("Successfully Added.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_Contract_id.Text = "";
                add_Contract_name.Text = "";
                add_Contract_email.Text = "";
                add_Contract_aadharUid.Text = "";
                add_Contract_aadharString.Text = "";
                add_Contract_password.Text = "";
                add_Contract_siteId.Text = "";
                add_Contract_name.Focus();
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
