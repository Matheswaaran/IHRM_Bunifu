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
    public partial class Add_Site : Form
    {
        public Add_Site()
        {
            InitializeComponent();
        }

        private void add_Site_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Site_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Site_add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = add_Site_id.Text;
                string name = add_Site_name.Text;
                string address = add_Site_address.Text;
                string district = add_Site_district.Text;
                string state = add_Site_state.Text;
                string type = add_Site_type.Text;

                //Insert into database
                MySqlCommand sql_site_insert = new MySqlCommand("INSERT INTO hrm_database.site_table(name,address,district,state,type)values('" + name + "','" + address + "','" + district + "','" + state + "'," + type + ");", Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                //MySqlDataReader insert_site = sql_site_insert.ExecuteReader();
                sql_site_insert.ExecuteNonQuery();
                MessageBox.Show("Successfully Added.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_Site_id.Text = "";
                add_Site_name.Text = "";
                add_Site_address.Text = "";
                add_Site_district.Text = "";
                add_Site_state.Text = "";
                add_Site_type.Text = "";
                add_Site_name.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                Utils.MySql.myConn.Close();
            }

        }
    }
}
