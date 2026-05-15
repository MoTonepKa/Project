using Microsoft.Data.Sqlite;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project.Data
{
    public static class EventDB
    {
        private const string DbName = "event.db";
        public static string ConnectionString => $"Data Source={DbName}";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }

        public static void Initialize()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Events (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Title TEXT NOT NULL,
                                Description TEXT,
                                EventDate TEXT,
                                ImagePath TEXT,
                                AuthorName TEXT,
                                University TEXT
                             );";
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void SeedData()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string checkSql = "SELECT COUNT(*) FROM Events";
                using (var checkCmd = new SqliteCommand(checkSql, connection))
                {
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0) return;
                }

                string insertSql = @"
INSERT INTO Events (Title, Description, EventDate, ImagePath, AuthorName, University) VALUES 
('Семинар по квантовой физике', 'Обсуждение излучения абсолютно черного тела и фотоэффекта.', '2026-05-10 14:00:00', '', 'Кафедра Физики', 'ТУИТ'),
('Мастер-класс: Ряды Фурье', 'Разбор задач по высшей математике.', '2026-05-12 10:30:00', '', 'Профком', 'ТУИТ');";

                using (var command = new SqliteCommand(insertSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}