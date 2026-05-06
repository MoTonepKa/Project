using Project.Components;
using Project.Data;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            // Настраиваем панель для красивого вывода
            pnlEvents.FlowDirection = FlowDirection.TopDown;
            pnlEvents.WrapContents = false;
            pnlEvents.AutoScroll = true;

            LoadPosts();
            Program.LoadFont(this);
            ProfileLabel.Text = Program.User.Username;
        }
        private void LoadPosts()
        {
            pnlEvents.Controls.Clear();
            var events = _eventService.GetAllEvents();

            foreach (var ev in events)
            {
                // Создаем карточку
                EventPost post = new EventPost(ev);

                // Растягиваем карточку по ширине панели
                post.Width = pnlEvents.ClientSize.Width - 25;

                // Добавляем в ленту
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
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
