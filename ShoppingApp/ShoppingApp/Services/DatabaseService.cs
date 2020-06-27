using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ShoppingApp.Models.Database;
using System.IO;

namespace ShoppingApp.Services
{
    public class DatabaseService
    {
        public SQLiteConnection Connection
        {
            get => connection;
            set { }
        }

        private const string DB_FILE_NAME = "db.sqlite";
        private SQLiteConnection connection;

        public DatabaseService()
        {
            connection = new SQLiteConnection(getPath(), SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex);
            connection.CreateTable<Stock>();
        }

        private string getPath()
        {
            return Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                DB_FILE_NAME
            );
        }
    }
}
