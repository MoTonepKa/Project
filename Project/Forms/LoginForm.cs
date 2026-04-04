using System.Runtime.InteropServices;
using Project.Forms;
using Project.Models;
using MyFunctions;

namespace Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            LoginTextBox.SetPadding(new Padding(10, 10, 10, 10)); 
            PasswordTextBox.SetPadding(new Padding(10, 10, 10, 10));
            this.AddGlobalKeyPress();
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
                MessageBox.Show("Добро пожаловать, " + user.Name);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
                // дальше откроем главное окно
            }
            else
            {
                MessageBox.Show("Неверный email или пароль");
            }
        }
    }
}
