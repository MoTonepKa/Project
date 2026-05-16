using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Project.Components;
using Project.Data;
using Project.Models;
using Project.Properties;
using Project.Services;

namespace Project.Forms
{
    public partial class MainForm : Form
    {
        private readonly EventService _eventService = new EventService();
        public MainForm()
        {
            InitializeComponent();

            EventDB.Initialize();
            EventDB.SeedData();
            LoadPosts();

            
        }
        private async void LoadPosts()
        {
            EventsPanel.Controls.Clear();
            string currentUserUniversity = Program.User?.University ?? "";
            var events = _eventService.GetEventsByUniversity(currentUserUniversity);
            int i = 0;
            foreach (var ev in events)
            {
                EventPost post = new EventPost(ev);
                post.Width = EventsPanel.Width - EventsPanel.Padding.Horizontal;
                post.BackColor = BackColor;
                EventsPanel.Controls.Add(post);

                if (i < events.Count - 1)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(post.Width, 1);
                    pictureBox.Margin = new Padding(0, 16, 0, 32);
                    pictureBox.BackColor = Line0.BackColor;
                    EventsPanel.Controls.Add(pictureBox);
                }
                i++;
            }

            await Task.Delay(1);
            EventsPanel.AutoScrollMinSize = new Size(0, EventsPanel.Controls[EventsPanel.Controls.Count - 1].Bottom + EventsPanel.Padding.Vertical);
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.Show();
            Close();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            if (!Program.MainForm.Visible) Program.MainForm.Close();
        }

        private void AddPostButton_Click(object sender, EventArgs e)
        {
            using (CreateEventForm createForm = new CreateEventForm())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPosts();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EventsPanel.FlowDirection = FlowDirection.TopDown;
            EventsPanel.WrapContents = false;
            EventsPanel.AutoScroll = true;
            
            ProfileLabel.Text = "Логин: " + Program.User.Login + "\n" +
                "Имя пользователя: " + Program.User.Name + "\n" +
                "Университет: " + Program.User.University;

            DrawInterface.LoadFont(this);
            DrawInterface.MakeRoundedCorners(SidebarFlowLayoutPanel);
            DrawInterface.MakeRoundedCorners(ModerationButton);
            DrawInterface.MakeRoundedCorners(AddPostButton);
            DrawInterface.MakeRoundedCorners(LanguageButton);
            DrawInterface.MakeRoundedCorners(LogoutButton);


            if (Program.User.Login == "object136") ProfileImageBox.BackgroundImage = Resources.my_avatar;
            ProfileImageBox.BackgroundImage = DrawInterface.CropToCircle(ProfileImageBox.BackgroundImage, ProfileImageBox.Width);
        }
    }
}
