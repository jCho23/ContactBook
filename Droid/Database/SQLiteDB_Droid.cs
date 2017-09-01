using System;
using Xamarin.Forms;
using SQLite;
using ContactBook.Droid.Database;
using ContactBook.DataBase;
using System.IO;

[assembly: Dependency(typeof(SQLiteDB_Droid))]

namespace ContactBook.Droid.Database                 

{
    public class SQLiteDB_Droid : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
