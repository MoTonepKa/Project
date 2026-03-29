using Project.Forms;
using Project.Models;

namespace Project
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
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

                // дальше откроем главное окно
            }
            else
            {
                MessageBox.Show("Неверный email или пароль");
            }
        }
    }
}
