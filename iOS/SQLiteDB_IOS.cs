using System;
using ContactBook.DataBase;
using SQLite;

using Xamarin.Forms;
using ContactBook.iOS;
using System.IO;

[assembly: Dependency(typeof(SQLiteDb_iOS))]
namespace ContactBook.iOS
{
    public class SQLiteDb_iOS :ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "ISQLiteDb");

            return new SQLiteAsyncConnection(path);
        }
    }
}
