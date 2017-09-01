using System;
using ContactBook.DataBase;
using SQLite;

using Xamarin.Forms;
using ContactBook.iOS;

[assembly: Dependency(typeof(SQLiteDb_iOS))]
namespace ContactBook.iOS
{
    public class SQLiteDb_iOS :ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            //
        }
    }
}
