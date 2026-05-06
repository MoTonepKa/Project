using Microsoft.Data.Sqlite;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Project.Data
{
    public static class EventDB
    {
        private const string DbName = "event.db";
        public static string ConnectionString => $"Data Source={DbName}";

        public static void Initialize()
        {
            // Microsoft.Data.Sqlite сам создаст файл, если его нет при открытии
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Events (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Title TEXT NOT NULL,
                                Description TEXT,
                                EventDate TEXT,
                                ImagePath TEXT
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

                // Проверяем, есть ли уже данные, чтобы не дублировать их при каждом запуске
                string checkSql = "SELECT COUNT(*) FROM Events";
                using (var checkCmd = new SqliteCommand(checkSql, connection))
                {
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0) return;
                }

                string insertSql = @"
            INSERT INTO Events (Title, Description, EventDate, ImagePath) VALUES 
            ('Семинар по квантовой физике', 'Обсуждение излучения абсолютно черного тела и фотоэффекта. Аудитория 402.', '2026-05-10 14:00:00', 'images/physics.jpg'),
            ('Мастер-класс: Ряды Фурье', 'Разбор задач по высшей математике и подготовка к защите.', '2026-05-12 10:30:00', 'images/math.jpg'),
            ('Дискуссия: Философия истории', 'Линейный подход и мифологическое сознание в культуре.', '2026-05-15 16:00:00', 'images/philosophy.jpg');";

                using (var command = new SqliteCommand(insertSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}