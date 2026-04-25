using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainText { get; set; }
        public string Writer { get; set; }
        public DateTime PostedTime { get; set; }

        public Post(string title, string text, string writer)
        {
            Title = title;
            MainText = text;
            Writer = writer;
            PostedTime = DateTime.Now;
        }
    }
}
