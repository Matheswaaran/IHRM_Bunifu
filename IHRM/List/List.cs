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
        private bool check = false;
        private string table;

        public List()
        {
            InitializeComponent();
        }

        private void list_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkbox()
        {
            //Add a CheckBox Column to the DataGridView at the first position.
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            site_Datagrid.Columns.Insert(0, checkBoxColumn);
            check = true;
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
                table = "site_table";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check == false)
            {
                checkbox();
            }
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT cid,name,email,aadhar_uid,gid from hrm_database.contract_users;", Utils.MySql.myConn);
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
                table = "contract_users";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check == false)
            {
                checkbox();
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
            MySqlCommand listSite = new MySqlCommand("SELECT su_id,name,email,aadhar_uid,gid from hrm_database.supervisour_users;", Utils.MySql.myConn);
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
                table = "supervisour_users";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check == false)
            {
                checkbox();
            }
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table;", Utils.MySql.myConn);
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
                table = "employee_table";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check == false)
            {
                checkbox();
            }
        }

        private void btn_empVerification_Click(object sender, EventArgs e)
        {
            //MySqlCommand listSite = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table;", Utils.MySql.myConn);
            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = listSite;
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    BindingSource bSource = new BindingSource();

            //    bSource.DataSource = dt;
            //    site_Datagrid.DataSource = bSource;
            //    sda.Update(dt);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void site_add_Click(object sender, EventArgs e)
        {
            switch (table)
            {
                case "site_table":
                    Data.Add_Site addSite = new Data.Add_Site();
                    addSite.Show();
                    break;
                case "contract_users":
                    Data.Add_Contract addContract = new Data.Add_Contract();
                    addContract.Show();
                    break;
                case "supervisour_users":
                    Data.Add_Super addSuper = new Data.Add_Super();
                    addSuper.Show();
                    break;
                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
