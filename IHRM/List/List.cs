﻿using MySql.Data.MySqlClient;
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

        private void setButtonText(string tablename)
        {
            switch (table)
            {
                case "site_table":
                    site_add.ButtonText = "Add";
                    site_delete.ButtonText = "Delete";
                    site_modify.ButtonText = "Modify";
                    break;
                case "contract_users":
                    site_add.ButtonText = "Add";
                    site_delete.ButtonText = "Delete";
                    site_modify.ButtonText = "Modify";
                    break;
                case "supervisor_users":
                    site_add.ButtonText = "Add";
                    site_delete.ButtonText = "Delete";
                    site_modify.ButtonText = "Modify";
                    break;
                case "employee_table":
                    site_add.ButtonText = "Approved";
                    site_delete.ButtonText = "Pending";
                    site_modify.ButtonText = "Approve";
                    break;
                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
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

        //private void setDatagrid(MySqlCommand query)
        //{
        //    MySqlDataAdapter sda = new MySqlDataAdapter();
        //    sda.SelectCommand = query;
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    BindingSource bSource = new BindingSource();

        //    bSource.DataSource = dt;
        //    site_Datagrid.DataSource = bSource;
        //    sda.Update(dt);
        //}

        //private void setDatagridTable(MySqlCommand query, string table)
        //{
        //    MySqlDataAdapter sda = new MySqlDataAdapter();
        //    sda.SelectCommand = query;
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    BindingSource bSource = new BindingSource();

        //    bSource.DataSource = dt;
        //    site_Datagrid.DataSource = bSource;
        //    sda.Update(dt);
        //    setButtonText(table);
        //}

        private void btn_home_Click(object sender, EventArgs e)
        {
            
            MySqlCommand listSite = new MySqlCommand("SELECT sid,name,address,district,state from hrm_database.site_table;", Utils.MySql.myConn);
            try
            {
                //setDatagridTable(listSite, "site_table");
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listSite;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource;
                sda.Update(dt);
                table = "site_table";
                setButtonText(table);
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
            MySqlCommand listContract = new MySqlCommand("SELECT cid,name,email,aadhar_uid,gid from hrm_database.contract_users;", Utils.MySql.myConn);
            try
            {
                //setDatagridTable(listContract, "contract_users");
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listContract;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource;
                sda.Update(dt);
                table = "contract_users";
                setButtonText(table);
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
            MySqlCommand listSuper = new MySqlCommand("SELECT su_id,name,email,aadhar_uid,gid from hrm_database.supervisor_users;", Utils.MySql.myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listSuper;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource; 
                sda.Update(dt);
                table = "supervisor_users";
                setButtonText(table);
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
            MySqlCommand listEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table;", Utils.MySql.myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listEmployee;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                site_Datagrid.DataSource = bSource;
                sda.Update(dt);
                table = "employee_table";
                setButtonText(table);
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
                case "supervisor_users":
                    Data.Add_Super addSuper = new Data.Add_Super();
                    addSuper.Show();
                    break;
                case "employee_table":
                    MySqlCommand approvedEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table where auth = 1;", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = approvedEmployee;
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dt;
                        site_Datagrid.DataSource = bSource;
                        sda.Update(dt);
                        //table = "employee_table";
                        //setButtonText(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (check == false)
                    {
                        checkbox();
                    }
                    break;
                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void site_delete_Click(object sender, EventArgs e)
        {
            switch (table)
            {
                case "site_table":
                    string messageSite = string.Empty;
                    foreach (DataGridViewRow row in site_Datagrid.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                        if (isSelected)
                        {
                            messageSite += Environment.NewLine;
                            messageSite += row.Cells["name"].Value.ToString();
                        }
                    }
                    MessageBox.Show("Selected Values" + string.Empty);
                    break;

                case "contract_users":
                    string msgContract = string.Empty;
                    foreach (DataGridViewRow row in site_Datagrid.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                        if (isSelected)
                        {
                            msgContract += Environment.NewLine;
                            msgContract += row.Cells["name"].Value.ToString();
                        }
                    }
                    MessageBox.Show("Selected Values" + msgContract);
                    break;

                case "supervisor_users":
                    string messageSuper = string.Empty;
                    foreach (DataGridViewRow row in site_Datagrid.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                        if (isSelected)
                        {
                            messageSuper += Environment.NewLine;
                            messageSuper += row.Cells["name"].Value.ToString();
                        }
                    }
                    MessageBox.Show("Selected Values" + messageSuper);
                    break;
                    
                case "employee_table":
                    MySqlCommand pendingEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table where auth = 0;", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = pendingEmployee;
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dt;
                        site_Datagrid.DataSource = bSource;
                        sda.Update(dt);
                        //table = "employee_table";
                        //setButtonText(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (check == false)
                    {
                        checkbox();
                    }
                    break;

                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void site_searchBtn_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(site_search.Text);
            if (string.IsNullOrEmpty(site_search.Text))
            {
                MessageBox.Show("Please enter an ID to search.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                site_search.Focus();
                return;
            }
            foreach(char c in site_search.Text)
            {
                if (!Char.IsNumber(c))
                {
                    MessageBox.Show("The value of the ID should be a Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    site_search.Focus();
                    return;
                }
            }
            switch (table)
            {
                case "site_table":
                    MySqlCommand searchSite = new MySqlCommand("SELECT sid,name,address,district,state from hrm_database.site_table where sid =" + int.Parse(site_search.Text) + ";", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = searchSite;
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dt;
                        site_Datagrid.DataSource = bSource;
                        sda.Update(dt);
                        //table = "employee_table";
                        //setButtonText(table);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (check == false)
                    {
                        checkbox();
                    }
                    break;

                case "contract_users":
                    MySqlCommand searchContract = new MySqlCommand("SELECT cid,name,email,aadhar_uid,gid from hrm_database.contract_users where cid =" + int.Parse(site_search.Text) + ";", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = searchContract;
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
                    if (check == false)
                    {
                        checkbox();
                    }
                    break;

                case "supervisor_users":
                    MySqlCommand searchSupervisor = new MySqlCommand("SELECT su_id,name,email,aadhar_uid,gid from hrm_database.supervisor_users where su_id =" + int.Parse(site_search.Text) + ";", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = searchSupervisor;
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
                    if (check == false)
                    {
                        checkbox();
                    }
                    break;

                case "employee_table":
                    MySqlCommand searchEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table where eid =" + int.Parse(site_search.Text) + ";", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = searchEmployee;
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
                    if (check == false)
                    {
                        checkbox();
                    }
                    break;

                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
