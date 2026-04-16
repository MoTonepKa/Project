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
        public MainForm()
        {
            InitializeComponent();
            Program.LoadFont(this);
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
    }
}
