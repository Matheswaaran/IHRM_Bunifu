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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void list_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {   
           MySqlCommand listSite = new MySqlCommand("SELECT sid,name,address,district,state from hrm_database.site_table;", Utils.MySql.myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listSite;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT * from hrm_database.contract_users;", Utils.MySql.myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listSite;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Utils.Session.setDetails(0, "");
            MessageBox.Show("Session :  " + Utils.Session.getId().ToString() + " - " + Utils.Session.getUsername().ToString() + ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IHRM.Login login = new IHRM.Login();
            login.Show();
            this.Hide();
        }

        private void btn_supervisour_Click(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT * from hrm_database.contract_users;", Utils.MySql.myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listSite;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource; 
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
