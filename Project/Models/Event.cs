using System;
using System.Drawing;

namespace Project.Models
{
    public class UniversityEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
        public string Author { get; set; }
    }
}