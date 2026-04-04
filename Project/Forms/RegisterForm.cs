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
        string password;

        public RegisterForm()
        {
            InitializeComponent();

            NameTextBox.SetPadding(new Padding(10, 10, 10, 10));
            LoginTextBox.SetPadding(new Padding(10, 10, 10, 10));
            PasswordTextBox.SetPadding(new Padding(10, 10, 10, 10));
            this.AddGlobalKeyPress();
        }

        private Registration _authService = new Registration();

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text) || UniversityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }
            else if (LoginTextBox.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен состоять не менее 8 символов!");
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
                    password
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

        private void Password_Write(object sender, KeyPressEventArgs e)
        {
            char password_char = '*';
            if (e.KeyChar != (char)Keys.Back) e.Handled = true;

            for (int i = Convert.ToInt32('0'); i <= Convert.ToInt32('9'); i++)
            {
                if (e.KeyChar == (char)i)
                {
                    password += Convert.ToChar(i);
                    PasswordTextBox.Text += password_char;
                }
            }
            for (int i = Convert.ToInt32('a'); i < Convert.ToInt32('z'); i++)
            {
                if (e.KeyChar == (char)i)
                {
                    password += Convert.ToChar(i);
                    PasswordTextBox.Text += password_char;
                }
            }
            for (int i = Convert.ToInt32('A'); i < Convert.ToInt32('Z'); i++)
            {
                if (e.KeyChar == (char)i)
                {
                    password += Convert.ToChar(i);
                    PasswordTextBox.Text += password_char;
                }
            }
            if (e.KeyChar == (char)Convert.ToInt32('_'))
            {
                password += '_';
                PasswordTextBox.Text += password_char;
            }
            PasswordTextBox.SelectionStart += PasswordTextBox.TextLength;
        }
    }
}
