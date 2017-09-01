using System;
using System.IO;

using SQLite;
using Xamarin.Forms;

using ContactBook.DataBase;
using ContactBook.Droid.Database;

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
