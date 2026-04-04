using System.Runtime.InteropServices;
using Project.Forms;
using Project.Models;
using MyFunctions;
using System.Text;

namespace Project
{
    public partial class LoginForm : Form
    {
        string password;

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
                password
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
