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

        private void list_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Site_add_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(add_Contract_id.Text);
                string name = add_Contract_name.Text;
                string emailid= add_Contract_email.Text;
                int aadharUid = int.Parse(add_Contract_aadharUid.Text);
                string aadharString = add_Contract_aadharString.Text;
                string password = add_Contract_password.Text;

                //Insert into database
                MySqlCommand sql_site_insert = new MySqlCommand("INSERT INTO contract_users(id,name,email,aadhar_uid,aadhar_string,password,gid)values(" + id + ",'" + name + "','" + emailid + "','" + aadharUid + "','" + aadharString + "'," + password + "'" + Utils.Session.getUsername() + "');", Utils.MySql.myConn);
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
