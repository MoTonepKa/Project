using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public enum UserRole
    {
        User = 0,
        Moderator = 1,
        Admin = 2
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string University { get; set; }
        public string PasswordHash { get; set; }

        public UserRole Role { get; set; }
    }
}
