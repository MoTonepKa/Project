using System.Windows.Forms.VisualStyles;

namespace Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            LoginGroupBox = new GroupBox();
            PasswordGroupBox = new GroupBox();
            LoginGroupBox.SuspendLayout();
            PasswordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = SystemColors.Window;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Location = new Point(13, 21);
            LoginTextBox.MaxLength = 32;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "введите логин";
            LoginTextBox.Size = new Size(272, 16);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Location = new Point(13, 21);
            PasswordTextBox.MaxLength = 16;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "введите пароль";
            PasswordTextBox.Size = new Size(272, 16);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(43, 360);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 50);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(197, 360);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(144, 50);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.Controls.Add(LoginTextBox);
            LoginGroupBox.Location = new Point(43, 204);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Padding = new Padding(10, 2, 10, 10);
            LoginGroupBox.Size = new Size(298, 50);
            LoginGroupBox.TabIndex = 4;
            LoginGroupBox.TabStop = false;
            LoginGroupBox.Text = "Логин";
            // 
            // PasswordGroupBox
            // 
            PasswordGroupBox.Controls.Add(PasswordTextBox);
            PasswordGroupBox.Location = new Point(43, 260);
            PasswordGroupBox.Name = "PasswordGroupBox";
            PasswordGroupBox.Padding = new Padding(10, 2, 10, 10);
            PasswordGroupBox.Size = new Size(298, 50);
            PasswordGroupBox.TabIndex = 5;
            PasswordGroupBox.TabStop = false;
            PasswordGroupBox.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(384, 441);
            Controls.Add(PasswordGroupBox);
            Controls.Add(LoginGroupBox);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Padding = new Padding(40, 30, 40, 30);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            LoginGroupBox.ResumeLayout(false);
            LoginGroupBox.PerformLayout();
            PasswordGroupBox.ResumeLayout(false);
            PasswordGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button RegisterButton;
        private GroupBox LoginGroupBox;
        private GroupBox PasswordGroupBox;
    }
}
