using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRM.Utils
{
    static class MySql
    {
        public static string MySqlDataSource = "datasource=192.168.1.103;port=8889;username=root;password=root;";
        public static MySqlConnection myConn = new MySqlConnection(MySqlDataSource);
        //public static MySqlDataReader myReader;

        public static MySqlCommand listSite = new MySqlCommand("SELECT sid,name,address,district,state from hrm_database.site_table;",myConn);
        public static MySqlCommand listContract = new MySqlCommand("SELECT cid,name,email,aadhar_uid,gid from hrm_database.contract_users;", myConn);
        public static MySqlCommand listSuper = new MySqlCommand("SELECT su_id,name,email,aadhar_uid,gid from hrm_database.supervisor_users;", myConn);
        public static MySqlCommand listEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table;", myConn);
        public static MySqlCommand approvedEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table where auth = 1;", myConn);
        public static MySqlCommand pendingEmployee = new MySqlCommand("SELECT eid,name,cid,auth,aadhar_uid,skill,emp_type from hrm_database.employee_table where auth = 0;", myConn);
        public static MySqlCommand listEmployeeAttendence = new MySqlCommand("SELECT atid,eid,sid,date,enter_time,exit_time from hrm_database.employee_attendance_table;", myConn);
    }
}
