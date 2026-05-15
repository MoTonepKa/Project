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
            PasswordShowButton = new Button();
            RememberCheckBox = new CheckBox();
            TitleBar = new Project.Forms.TitleBar();
            LoginGroupBox.SuspendLayout();
            PasswordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Location = new Point(13, 21);
            LoginTextBox.MaxLength = 32;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "введите логин";
            LoginTextBox.Size = new Size(288, 16);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Location = new Point(13, 21);
            PasswordTextBox.MaxLength = 16;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "введите пароль";
            PasswordTextBox.Size = new Size(272, 16);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(43, 417);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 50);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(207, 417);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 50);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.Controls.Add(LoginTextBox);
            LoginGroupBox.Location = new Point(43, 261);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Padding = new Padding(10, 2, 10, 10);
            LoginGroupBox.Size = new Size(314, 50);
            LoginGroupBox.TabIndex = 4;
            LoginGroupBox.TabStop = false;
            LoginGroupBox.Text = "Логин";
            // 
            // PasswordGroupBox
            // 
            PasswordGroupBox.Controls.Add(PasswordShowButton);
            PasswordGroupBox.Controls.Add(PasswordTextBox);
            PasswordGroupBox.Location = new Point(43, 317);
            PasswordGroupBox.Name = "PasswordGroupBox";
            PasswordGroupBox.Padding = new Padding(10, 2, 10, 10);
            PasswordGroupBox.Size = new Size(314, 50);
            PasswordGroupBox.TabIndex = 5;
            PasswordGroupBox.TabStop = false;
            PasswordGroupBox.Text = "Пароль";
            // 
            // PasswordShowButton
            // 
            PasswordShowButton.BackgroundImage = Properties.Resources.invisible;
            PasswordShowButton.BackgroundImageLayout = ImageLayout.Center;
            PasswordShowButton.FlatAppearance.BorderSize = 0;
            PasswordShowButton.FlatStyle = FlatStyle.Flat;
            PasswordShowButton.Location = new Point(274, 9);
            PasswordShowButton.Name = "PasswordShowButton";
            PasswordShowButton.Size = new Size(38, 38);
            PasswordShowButton.TabIndex = 2;
            PasswordShowButton.UseVisualStyleBackColor = true;
            PasswordShowButton.MouseDown += PasswordShowButton_MouseDown;
            PasswordShowButton.MouseUp += PasswordShowButton_MouseUp;
            // 
            // RememberCheckBox
            // 
            RememberCheckBox.FlatStyle = FlatStyle.System;
            RememberCheckBox.Location = new Point(56, 373);
            RememberCheckBox.Name = "RememberCheckBox";
            RememberCheckBox.Size = new Size(137, 30);
            RememberCheckBox.TabIndex = 2;
            RememberCheckBox.Text = " Запомнить меня";
            RememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // TitleBar
            // 
            TitleBar.AutoValidate = AutoValidate.EnablePreventFocusChange;
            TitleBar.BackColor = Color.DarkGray;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Margin = new Padding(0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(400, 32);
            TitleBar.TabIndex = 6;
            TitleBar.Title = "Вход в систему";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 500);
            Controls.Add(TitleBar);
            Controls.Add(RememberCheckBox);
            Controls.Add(PasswordGroupBox);
            Controls.Add(LoginGroupBox);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Padding = new Padding(40, 30, 40, 30);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            Load += LoginForm_Load;
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
        private CheckBox RememberCheckBox;
        private Forms.TitleBar TitleBar;
        private Button PasswordShowButton;
    }
}
