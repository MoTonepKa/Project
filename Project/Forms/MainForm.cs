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
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.MainForm.Show();
            Close();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            //Program.MainForm.Close();
            // При выходе из аккаунта есть баг при котором окно закрывается
            Program.MainForm.Show();
        }
    }
}
