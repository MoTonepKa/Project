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
            


            lblTitle.Text = ev.Title;
            lblDesc.Text = ev.Description;
            lblDate.Text = ev.Date.ToString("dd.MM.yyyy HH:mm");
            lblAuthor.Text = ev.Author;

            if (!string.IsNullOrEmpty(ev.ImagePath) && File.Exists(ev.ImagePath))
            {
                pbImage.ImageLocation = ev.ImagePath;
            }

            
        }

        private void EventPost_Load(object sender, EventArgs e)
        {
            int deltaHeight = pbImage.Size.Height;
            pbImage.Size = new Size(pbImage.Size.Width, pbImage.BackgroundImage.Height * pbImage.Size.Width / pbImage.BackgroundImage.Width - Padding.Vertical - Padding.Horizontal);
            deltaHeight -= pbImage.Size.Height;
            deltaHeight *= -1;
            Height += deltaHeight;

            DrawInterface.LoadFont(this);
            DrawInterface.LoadFont(lblTitle);
            DrawInterface.DrawBorderLine(this);
            //DrawInterface.DrawBorderLine(pbImage);
            DrawInterface.DrawRectShadow(pbImage, this);
        }
    }
}
