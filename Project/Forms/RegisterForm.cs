using Project.Services;

namespace Project.Forms
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private Registration _authService = new Registration();

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text) || UniversityComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }
            else if (PasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Пароль должен состоять не менее 8 символов!");
                return;
            }

            string name = string.IsNullOrWhiteSpace(NameTextBox.Text)
                ? "Аноним"
                : NameTextBox.Text;

            string password = PasswordTextBox.Text;

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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            DrawInterface.LoadFont(this);
            DrawInterface.DrawBorderLine(this);
            DrawInterface.DrawRectShadow(LoginButton, this);
            DrawInterface.DrawRectShadow(RegisterButton, this);

            DrawInterface.DrawBorderLine(LoginPanel);
            DrawInterface.DrawBorderLine(PasswordPanel);
            DrawInterface.DrawBorderLine(UniversityPanel);
            DrawInterface.DrawBorderLine(NamePanel);

            DrawInterface.DrawRectShadow(LoginPanel, this);
            DrawInterface.DrawRectShadow(PasswordPanel, this);
            DrawInterface.DrawRectShadow(UniversityPanel, this);
            DrawInterface.DrawRectShadow(NamePanel, this);
        }
    }
}
