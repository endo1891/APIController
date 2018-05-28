using System;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using System.Collections;
using System.Collections.Generic;

namespace APIController.Framework.Helpers
{
    public static class DapperExtensions
    {
        internal static string ConnectionString = ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString;

        internal static IEnumerable<T> Query<T>(this string sql, object param = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                return conn.Query<T>(sql, param);

            }
        }

        internal static int Execute (this string sql, object param = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                return conn.Execute(sql, param);

            }
        }
    }
}