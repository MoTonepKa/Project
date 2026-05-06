using Microsoft.Data.Sqlite;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Project.Services
{
    public class Registration
    {
        public void Register(string name, string username, string email, string university, string password)
        {
            using (var connection = StudentDB.GetConnection())
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
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
