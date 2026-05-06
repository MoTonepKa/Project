using Microsoft.Data.Sqlite;

namespace Project.Data
{
    public static class StudentDB
    {
        private static string connectionString = "Data Source=student_app.db";

        public static void Initialize()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                MessageBox.Show("База открыта: " + connection.DataSource);
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Username TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE,
                    University TEXT NOT NULL,
                    PasswordHash TEXT NOT NULL,
                    Role INTEGER NOT NULL DEFAULT 0
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