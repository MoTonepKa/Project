using Microsoft.Data.Sqlite;
using Project.Data;
using Project.Models;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Project.Services
{
    public class Authentication
    {
        public User Login(string login, string password)
        {
            // 1. Базовая валидация (чтобы не дергать базу зря)
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Введите логин и пароль!");

            using (var connection = StudentDB.GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Id, Name, Login, University, PasswordHash, Role FROM Users WHERE Login = @login";
                cmd.Parameters.AddWithValue("@login", login);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string savedHash = reader.GetString(4);
                        string inputHash = Hash(password);

                        // 2. Сверяем хэши
                        if (savedHash == inputHash)
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.IsDBNull(1) ? "Аноним" : reader.GetString(1),
                                Login = reader.GetString(2),
                                University = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                PasswordHash = savedHash,
                                Role = (UserRole)reader.GetInt32(5)
                            };
                        }
                    }
                }
            }

            // 3. Если не нашли или пароль не подошел
            throw new Exception("Неверный логин или пароль!");
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