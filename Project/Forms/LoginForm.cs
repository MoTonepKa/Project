using System;
using System.Drawing;
using System.Windows.Forms;
using Project.Models;
using Project.Services;
using Project.Forms; // Добавили, чтобы видеть RegisterForm и MainForm

namespace Project // Исправили: теперь совпадает с Designer.cs
{
    public partial class LoginForm : Form
    {
        private readonly Authentication _authService = new Authentication();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Пытаемся войти через сервис
                var user = _authService.Login(LoginTextBox.Text, PasswordTextBox.Text);

                // Если данные верны, сохраняем пользователя в глобальную переменную
                Program.User = user;

                // Сохраняем настройки "Запомнить меня"
                SaveLoginSettings(user.Login);

                MessageBox.Show($"Добро пожаловать, {user.Name}!", "Вход выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Выводим ошибку (например, "Неверный логин или пароль")
                MessageBox.Show(ex.Message, "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveLoginSettings(string login)
        {
            if (RememberCheckBox.Checked)
            {
                Properties.Settings.Default.login = login;
                Properties.Settings.Default.remeberMe = true;
            }
            else
            {
                Properties.Settings.Default.login = "";
                Properties.Settings.Default.remeberMe = false;
            }
            Properties.Settings.Default.Save();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Используем полное имя или убеждаемся, что RegisterForm в Project.Forms
            using (RegisterForm registerForm = new RegisterForm())
            {
                registerForm.ShowDialog();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DrawInterface.LoadFont(this);

            if (Properties.Settings.Default.remeberMe)
            {
                LoginTextBox.Text = Properties.Settings.Default.login;
                RememberCheckBox.Checked = true;
            }
        }

        private void PasswordShowButton_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordShowButton.BackgroundImage = Properties.Resources.visible;
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void PasswordShowButton_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordShowButton.BackgroundImage = Properties.Resources.invisible;
            PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}