using Microsoft.Data.Sqlite;

namespace Project.Data
{
    public static class Database
    {
        private static string connectionString = "Data Source=student_app.db";

        public static void Initialize()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    Role INTEGER NOT NULL
                );
                ";

                command.ExecuteNonQuery();
            }
        }

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}