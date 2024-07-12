using System;
using System.IO;

namespace SQLiteNET {
    class dBFunctions
    {
        public static string ConnectionStringSQLite
        {
            get
            {
                string database = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\Contact.s3db";
                string connectionString = @"Data Source=" + Path.GetFullPath(database);
                return connectionString;
            }
        }
    }
}