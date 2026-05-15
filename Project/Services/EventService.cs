using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Project.Data;
using Project.Models;

namespace Project.Services
{
    public class EventService
    {
        public void CreateEvent(string title, string description, string authorName, string university, string imagePath)
        {
            using (var connection = EventDB.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO Events (Title, Description, EventDate, AuthorName, University, ImagePath)
                    VALUES (@title, @desc, @date, @author, @uni, @path);";

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@author", authorName);
                cmd.Parameters.AddWithValue("@uni", university);
                cmd.Parameters.AddWithValue("@path", imagePath ?? "");

                cmd.ExecuteNonQuery();
            }
        }
        public List<UniversityEvent> GetEventsByUniversity(string userUniversity)
        {
            var events = new List<UniversityEvent>();

            using (var connection = new SqliteConnection(EventDB.ConnectionString))
            {
                connection.Open();
                string sql = @"SELECT Id, Title, Description, EventDate, ImagePath, AuthorName, University 
                               FROM Events 
                               WHERE University = @university";

                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@university", userUniversity);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            events.Add(new UniversityEvent
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                EventDate = DateTime.Parse(reader.GetString(3)), 
                                ImagePath = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                AuthorName = reader.IsDBNull(5) ? "" : reader.GetString(5), 
                                University = reader.IsDBNull(6) ? "" : reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return events;
        }
    }
}