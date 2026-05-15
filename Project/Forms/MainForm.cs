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
        }
        private void LoadPosts()
        {
            pnlEvents.Controls.Clear();
            string currentUserUniversity = Program.User?.University ?? "";
            var events = _eventService.GetEventsByUniversity(currentUserUniversity);
            foreach (var ev in events)
            {
                EventPost post = new EventPost(ev);

                post.Width = pnlEvents.ClientSize.Width - (pnlEvents.Padding.Left + pnlEvents.Padding.Right);

                pnlEvents.Controls.Add(post);
            }
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
            pnlEvents.FlowDirection = FlowDirection.TopDown;
            pnlEvents.WrapContents = false;
            pnlEvents.AutoScroll = true;

            LoadPosts();
            //Font = new Font(Program.MyFontCollection.Families[0], Font.SizeInPoints, Font.Style);
            ProfileLabel.Text = Program.User.Login + "\n" + "(" + Program.User.Name + ")";

            DrawInterface.LoadFont(this);
            if (Program.User.Login == "object136") ProfileImageBox.BackgroundImage = Resources.my_avatar;
            ProfileImageBox.BackgroundImage = DrawInterface.CropToCircle(ProfileImageBox.BackgroundImage, ProfileImageBox.Width);
        }
    }
}
