using System;
using System.Drawing;
using System.Windows.Forms;
using Project.Services;

namespace Project.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly Registration _registrationService = new Registration();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!AgreementCheckBox.Checked)
            {
                MessageBox.Show("Вы не согласились с условиями приложения", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Просто передаем данные в сервис. 
                // Сервис сам проверит их и, если что-то не так, упадет в блок catch.
                _registrationService.Register(
                    NameTextBox.Text,
                    LoginTextBox.Text,
                    UniversityComboBox.SelectedItem?.ToString(),
                    PasswordTextBox.Text
                );

                MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Показываем пользователю сообщение об ошибке, которое пришло из сервиса
                MessageBox.Show(ex.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Closed(object sender, FormClosedEventArgs e)
        {
            Program.MainForm.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            DrawInterface.LoadFont(this);
        }
    }
}