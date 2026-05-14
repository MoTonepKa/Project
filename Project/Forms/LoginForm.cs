using Microsoft.VisualBasic.ApplicationServices;
using Project.Forms;
using Project.Models;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Font = new Font(Program.MyFontCollection.Families[0], Font.SizeInPoints, Font.Style);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // форма открывается модально (поверх основной формы)
        }
        private Authentication _auth = new Authentication();
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Введите email и пароль");
                return;
            }

            var user = _auth.Login(
                LoginTextBox.Text,
                PasswordTextBox.Text
            );

            if (user != null)
            {
                Program.User = user;

                MessageBox.Show("Вход выполнен!\n" + "Добро пожаловать, " + user.Name);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();

                if (RememberCheckBox.Checked)
                {
                    Properties.Settings.Default.login = user.Email;
                    Properties.Settings.Default.remeberMe = true;
                }
                else
                {
                    Properties.Settings.Default.login = "";
                    Properties.Settings.Default.remeberMe = false;
                }
                Properties.Settings.Default.Save();
                // дальше откроем главное окно
            }
            else
            {
                MessageBox.Show("Неверный email или пароль");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Program.LoadFont(this);

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
