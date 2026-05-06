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

    }
}
