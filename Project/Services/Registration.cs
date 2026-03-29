using Microsoft.Data.Sqlite;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Services
{
    public class Registration
    {
        public void Register(string name, string username, string email, string university, string password)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText =
                @"
                INSERT INTO Users (Name, Username, Email, University, PasswordHash)
                VALUES (@name, @username, @email, @university, @password);
                ";

                cmd.Parameters.AddWithValue("@name", string.IsNullOrWhiteSpace(name) ? DBNull.Value : name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@university", string.IsNullOrWhiteSpace(university) ? DBNull.Value : university);
                cmd.Parameters.AddWithValue("@password", Hash(password));
                cmd.ExecuteNonQuery();
            }
        }

        private string Hash(string input)
        {
            return input.GetHashCode().ToString(); // простой хеш для теста
        }
    }
}
