using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Components
{
    public partial class EventPost : UserControl
    {
        public EventPost(UniversityEvent ev)
        {
            InitializeComponent();

            TitleLabel.Text = ev.Title;
            TextLabel.Text = ev.Description;
            DateLabel.Text = "Дата поста: " + ev.EventDate.ToString("dd.MM.yyyy HH:mm");
            AuthorLabel.Text = ev.AuthorName;

            if (!string.IsNullOrEmpty(ev.ImagePath) && File.Exists(ev.ImagePath))
            {
                PostPictureBox.ImageLocation = ev.ImagePath;
            }

            Start();
        }

        private void EventPost_Load(object sender, EventArgs e)
        {
            DrawInterface.LoadFont(this);
            DrawInterface.CropToCircle(ProfilePictureBox.BackgroundImage, ProfilePictureBox.Width);
        }

        private async void Start()
        {
            await Task.Delay(1);

            DrawInterface.LoadFont(TitleLabel);
            PostPictureBox.Width = Width;
            DrawInterface.MakeRoundedCorners(PostPictureBox);
        }
    }
}
