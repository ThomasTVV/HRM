﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataLibrary.DataAccess {
    public static class SqlDataAccess {
        public static string GetConnectionString(string connectionName = "Database")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        // Normally should allow parameters
        // More elaborate datasystem should be implemented later
        // Pass connectionstring to get data
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        // Saves data gathered to sql
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }

        }
    }
}
