using System;
using SQLite;

namespace ContactBook.DataBase
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
