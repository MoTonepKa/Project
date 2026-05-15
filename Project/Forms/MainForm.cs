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
using Project.Services;

namespace Project.Forms
{
    public partial class MainForm : Form
    {
        private readonly EventService _eventService = new EventService();
        public MainForm()
        {
            InitializeComponent();

            // Инициализируем БД и создаем тестовые записи
            EventDB.Initialize();
            EventDB.SeedData();

            AvatarImageBox.Image = DrawInterface.CropToCircle(AvatarImageBox.Image, Math.Min(AvatarImageBox.Width, AvatarImageBox.Height));
        }

        private void LoadPosts()
        {
            pnlEvents.Controls.Clear();
            var events = _eventService.GetAllEvents();

            foreach (var ev in events)
            {
                EventPost post = new EventPost(ev);
                post.Width = pnlEvents.Width - (pnlEvents.Padding.Left + pnlEvents.Padding.Right);
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
            if (!Program.MainForm.Visible) Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pnlEvents.FlowDirection = FlowDirection.TopDown;
            pnlEvents.WrapContents = false;
            pnlEvents.AutoScroll = true;

            LoadPosts();
            DrawInterface.LoadFont(this);
            DrawInterface.DrawBorderLine(this);
            DrawInterface.DrawBorderLine(SidebarPanel);
            DrawInterface.DrawBorderLine(ProfilePanel);
            //DrawInterface.DrawBorderLine(pnlEvents);
            DrawInterface.DrawRectShadow(HomeButton, SidebarPanel);
            DrawInterface.DrawRectShadow(AddPostButton, SidebarPanel);
            DrawInterface.DrawRectShadow(ModerationButton, SidebarPanel);
            DrawInterface.DrawRectShadow(LogoutButton, SidebarPanel);

            ProfileLabel.Text = Program.User.Email + "\n" + "(" + Program.User.Name + ")";
            pnlEvents.AutoScrollMinSize = new Size(0, pnlEvents.Controls[pnlEvents.Controls.Count - 1].Bottom + pnlEvents.Padding.Bottom);
        }

        private void ModerationButton_Click(object sender, EventArgs e)
        {

        }

    }
}
