using Microsoft.Data.Sqlite;
using Project.Data;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Project.Services
{
    public class Registration
    {
        public void Register(string name, string login, string university, string password)
        {
            // --- ЛОГИКА ПРОВЕРКИ (Валидация) ---
            if (string.IsNullOrWhiteSpace(login))
                throw new Exception("Логин не может быть пустым!");

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                throw new Exception("Пароль должен содержать не менее 8 символов!");

            if (string.IsNullOrWhiteSpace(university))
                throw new Exception("Необходимо выбрать университет!");

            // Если имя не ввели, назначаем стандартное
            string finalName = string.IsNullOrWhiteSpace(name) ? "Аноним" : name;

            // --- РАБОТА С БАЗОЙ ---
            using (var connection = StudentDB.GetConnection())
            {
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    INSERT INTO Users (Name, Login, University, PasswordHash)
                    VALUES (@name, @login, @university, @password);";

                cmd.Parameters.AddWithValue("@name", finalName);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@university", university);
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