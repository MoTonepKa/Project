using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using MyFunctions;
using Project.Services;

namespace Project.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            NameTextBox.SetPadding(new Padding(10, 10, 10, 10));
            LoginTextBox.SetPadding(new Padding(10, 10, 10, 10));
            PasswordTextBox.SetPadding(new Padding(10, 10, 10, 10));
        }

        private Registration _authService = new Registration();

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text) || UniversityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }

            string name = string.IsNullOrWhiteSpace(NameTextBox.Text)
                ? "Аноним"
                : NameTextBox.Text;

            try
            {
                _authService.Register(
                    name,
                    NameTextBox.Text,
                    LoginTextBox.Text,
                    UniversityComboBox.SelectedItem.ToString(),
                    PasswordTextBox.Text
                );

                MessageBox.Show("Регистрация успешна!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка регистрации: " + ex.Message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterForm_Closed(object sender, FormClosedEventArgs e) 
        {
            Program.MainForm.Show();
        }
    }
}
