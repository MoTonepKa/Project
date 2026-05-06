using Microsoft.VisualBasic.ApplicationServices;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using Project.Models;


namespace Project.Models
{
    public class Authentication
    {
        public User Login(string email, string password)
        {
            using (var connection = StudentDB.GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText =
                @"
                  SELECT Id, Name, Username, Email, University, PasswordHash, Role
                  FROM Users
                  WHERE Email = @email AND PasswordHash = @password;
                ";

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", Hash(password));

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.IsDBNull(1) ? "Аноним" : reader.GetString(1),
                            Username = reader.GetString(2),
                            Email = reader.GetString(3),
                            University = reader.GetString(4),
                            PasswordHash = reader.GetString(5),
                            Role = (UserRole)reader.GetInt32(6)
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
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
