using System;
using System.IO;

using SQLite;
using Xamarin.Forms;

using ContactBook.iOS;
using ContactBook.DataBase;

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
