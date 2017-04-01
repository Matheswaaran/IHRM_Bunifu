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

        private void setButtonText(string tablename)
        {
            switch (table)
            {
                case "site_table":
                    site_add.ButtonText = "Add";
                    site_delete.ButtonText = "Delete";
                    site_modify.ButtonText = "Modify";
                    site_add.Visible = true;
                    site_delete.Visible = true;
                    site_modify.Visible = false;
                    break;
                case "contract_users":
                    site_add.ButtonText = "Add";
                    site_delete.ButtonText = "Delete";
                    site_modify.ButtonText = "Modify";
                    site_add.Visible = true;
                    site_delete.Visible = true;
                    site_modify.Visible = false;
                    break;
                case "supervisor_users":
                    site_add.ButtonText = "Add";
                    site_delete.ButtonText = "Delete";
                    site_modify.ButtonText = "Modify";
                    site_add.Visible = true;
                    site_delete.Visible = true;
                    site_modify.Visible = false;
                    break;
                case "employee_table":
                    site_add.ButtonText = "Approved";
                    site_delete.ButtonText = "Pending";
                    site_modify.ButtonText = "Approve";
                    site_add.Visible = true;
                    site_delete.Visible = true;
                    site_modify.Visible = true;
                    break;

                case "employee_attendance_table":
                    site_add.Visible = false;
                    site_delete.Visible = false;
                    site_modify.Visible = false;
                    break;
                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        public void checkbox()
        {
            //Add a CheckBox Column to the DataGridView at the first position.
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
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

                case "employee_attendance_table":
                    break;

                default:
                    MessageBox.Show("Select a button from the navigation menu", "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void site_delete_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell checkboxCell;
            switch (table)
            {
                case "site_table":
                    foreach (DataGridViewRow row in site_Datagrid.Rows)
                    {
                        checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                        bool isSelected = (null != checkboxCell && null != checkboxCell.EditedFormattedValue && true == (bool)checkboxCell.EditedFormattedValue);
                        if (true == isSelected)
                        {
                            MySqlCommand delete_Sites = new MySqlCommand("delete from hrm_database.site_table where sid = " + row.Cells["sid"].Value + ";", Utils.MySql.myConn);
                            Utils.MySql.myConn.Open();
                            delete_Sites.ExecuteNonQuery();
                            Utils.MySql.myConn.Close();
                        }
                    }
                    break;

                case "contract_users":
                    foreach (DataGridViewRow row in site_Datagrid.Rows)
                    {
                        checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                        bool isSelected = (null != checkboxCell && null != checkboxCell.EditedFormattedValue && true == (bool)checkboxCell.EditedFormattedValue);
                        if (true == isSelected)
                        {
                            MySqlCommand delete_Sites = new MySqlCommand("delete from hrm_database.contract_users where cid = " + row.Cells["cid"].Value + ";", Utils.MySql.myConn);
                            Utils.MySql.myConn.Open();
                            delete_Sites.ExecuteNonQuery();
                            Utils.MySql.myConn.Close();
                        }
                    }
                    break;

                case "supervisor_users":
                    foreach (DataGridViewRow row in site_Datagrid.Rows)
                    {
                        checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                        bool isSelected = (null != checkboxCell && null != checkboxCell.EditedFormattedValue && true == (bool)checkboxCell.EditedFormattedValue);
                        if (true == isSelected)
                        {
                            MySqlCommand delete_Sites = new MySqlCommand("delete from hrm_database.supervisor_users where su_id = " + row.Cells["su_id"].Value + ";", Utils.MySql.myConn);
                            Utils.MySql.myConn.Open();
                            delete_Sites.ExecuteNonQuery();
                            Utils.MySql.myConn.Close();
                        }
                    }
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

                case "employee_attendance_table":
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

                case "employee_attendance_table":
                    MySqlCommand searchEmployeeAttendance = new MySqlCommand("SELECT atid,eid,sid,date,enter_time,exit_time from hrm_database.employee_attendance_table where eid =" + int.Parse(site_search.Text) + ";", Utils.MySql.myConn);
                    try
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter();
                        sda.SelectCommand = searchEmployeeAttendance;
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

        private void site_modify_Click(object sender, EventArgs e)
        {
            if (table == "employee_table")
            { 
                foreach (DataGridViewRow row in site_Datagrid.Rows)
                {
                    DataGridViewCheckBoxCell checkboxCell;
                    checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                    bool isSelected = (null != checkboxCell && null != checkboxCell.EditedFormattedValue && true == (bool)checkboxCell.EditedFormattedValue);
                    if (true == isSelected)
                    {
                        MySqlCommand delete_Sites = new MySqlCommand("UPDATE hrm_database.employee_users SET auth = 1 where eid = " + row.Cells["eid"].Value + ";", Utils.MySql.myConn);
                        Utils.MySql.myConn.Open();
                        delete_Sites.ExecuteNonQuery();
                        Utils.MySql.myConn.Close();
                    }
                }
            }
        }

        private void btn_empAttendance_Click(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT atid,eid,sid,date,enter_time,exit_time from hrm_database.employee_attendance_table;", Utils.MySql.myConn);
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
                table = "employee_attendance_table";
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

        private void btn_setting_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.Show();
        }
    }
}
