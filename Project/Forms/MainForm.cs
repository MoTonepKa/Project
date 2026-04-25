using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project.Models;

namespace Project.Forms
{
    public partial class MainForm : Form
    {
        Post[] posts = new Post[8];
        public MainForm()
        {
            posts[0] = new Post(
                "TITLE",
                "TEXT",
                "ByME"
            );
            posts[1] = new Post(
                "TITLE",
                "TEXT",
                "ByME"
            );
            posts[2] = new Post(
                "TITLE",
                "TEXT",
                "ByME"
            );

            InitializeComponent();
            Program.LoadFont(this);
            ProfileLabel.Text = Program.User.Username;
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

        Panel CreatePost(int x, int y, Post post)
        {
            Panel postPanel = new Panel();
            MainPanel.Controls.Add(postPanel);
            postPanel.Location = new Point(x, y);
            postPanel.BorderStyle = BorderStyle.FixedSingle;
            postPanel.Size = new Size(MainPanel.Width - (MainPanel.Padding.Left + MainPanel.Padding.Right + 24), 240);
            postPanel.Padding = new Padding(16, 10, 16, 10); 

            Label
                titleLabel = new Label(),
                mainTextLabel = new Label(),
                writerLabel = new Label(),
                timeLabel = new Label();
            postPanel.Controls.Add(titleLabel);
            postPanel.Controls.Add(mainTextLabel);
            postPanel.Controls.Add(writerLabel);
            postPanel.Controls.Add(timeLabel);

            int post_height = postPanel.Padding.Top, text_height = 22;

            

            titleLabel.Text = post.Title;
            titleLabel.Location = new Point(postPanel.Padding.Left, post_height);
            titleLabel.Font = new Font(titleLabel.Font.FontFamily, titleLabel.Font.Size * 1.5f, FontStyle.Bold);
            titleLabel.Size = new Size(postPanel.Width - (postPanel.Padding.Left + postPanel.Padding.Right), text_height);
            post_height += (int)(text_height * 1.25f);

            mainTextLabel.Text = "<<" + post.MainText + ">>";
            mainTextLabel.Location = new Point(postPanel.Padding.Left, post_height);
            mainTextLabel.AutoSize = true;
            post_height += mainTextLabel.Height + 4;

            writerLabel.Text = "Автор: " + post.Writer;
            writerLabel.Location = new Point(postPanel.Padding.Left, post_height);
            writerLabel.Font = new Font(writerLabel.Font.FontFamily, writerLabel.Font.Size, FontStyle.Italic);
            writerLabel.AutoSize = true;
            

            timeLabel.Text = post.PostedTime.ToString("dd-MMMM, HH:mm");
            timeLabel.TextAlign = ContentAlignment.TopRight;
            timeLabel.Location = new Point(postPanel.Padding.Left, post_height);
            timeLabel.Font = new Font(writerLabel.Font.FontFamily, writerLabel.Font.Size, FontStyle.Italic);
            timeLabel.Size = new Size(postPanel.Width - (postPanel.Padding.Left + postPanel.Padding.Right), text_height);
            post_height += text_height;

            post_height += 8;
            postPanel.Size = new Size(postPanel.Width, post_height);

            return postPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int x = MainPanel.Padding.Left, y = MainPanel.Padding.Top;
            foreach (Post post in posts) {
                if (post != null) {
                    var postPanel = CreatePost(x, y, post);
                    y += postPanel.Height + 12;
                }
            }
            MainPanel.VerticalScroll.SmallChange = 5;
            MainPanel.VerticalScroll.LargeChange = 10;
        }
    }
}
