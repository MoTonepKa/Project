using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite; // Используем Microsoft
using Project.Data;
using Project.Models;

namespace Project.Services
{
    public class EventService
    {
        public List<UniversityEvent> GetAllEvents()
        {
            var events = new List<UniversityEvent>();

            using (var connection = new SqliteConnection(EventDB.ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Events";

                using (var command = new SqliteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        events.Add(new UniversityEvent
                        {
                            Id = reader.GetInt32(0), // Можно получать по индексу
                            Title = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            Date = DateTime.Parse(reader.GetString(3)),
                            ImagePath = reader.IsDBNull(4) ? "" : reader.GetString(4)
                        });
                    }
                }
            }
            return events;
        }
        public static void SeedData()
        {
            using (var connection = new SqliteConnection(EventDB.ConnectionString))
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