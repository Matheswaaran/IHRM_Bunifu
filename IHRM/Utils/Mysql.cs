﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRM.Utils
{
    static class MySql
    {
        public static string MySqlDataSource = "datasource=127.0.0.1;port=3306;username=root;password=root;";
        public static MySqlConnection myConn = new MySqlConnection(MySqlDataSource);
        //public static MySqlDataReader myReader;
    }
}
