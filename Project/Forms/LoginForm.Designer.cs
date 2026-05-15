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
            PasswordShowButton = new Button();
            RememberCheckBox = new CheckBox();
            TitleBar = new Project.Forms.TitleBar();
            LoginPanel = new Panel();
            PasswordPanel = new Panel();
            PasswordLabel = new Label();
            label1 = new Label();
            LoginPanel.SuspendLayout();
            PasswordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Location = new Point(13, 13);
            LoginTextBox.MaxLength = 32;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "введите логин";
            LoginTextBox.Size = new Size(288, 16);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Location = new Point(13, 13);
            PasswordTextBox.MaxLength = 16;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "введите пароль";
            PasswordTextBox.Size = new Size(258, 16);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Location = new Point(43, 417);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 50);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Location = new Point(207, 417);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 50);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // PasswordShowButton
            // 
            PasswordShowButton.BackgroundImage = Properties.Resources.invisible;
            PasswordShowButton.BackgroundImageLayout = ImageLayout.Center;
            PasswordShowButton.FlatAppearance.BorderSize = 0;
            PasswordShowButton.FlatStyle = FlatStyle.Flat;
            PasswordShowButton.Location = new Point(277, 4);
            PasswordShowButton.Name = "PasswordShowButton";
            PasswordShowButton.Size = new Size(32, 32);
            PasswordShowButton.TabIndex = 2;
            PasswordShowButton.TabStop = false;
            PasswordShowButton.UseVisualStyleBackColor = true;
            PasswordShowButton.MouseDown += PasswordShowButton_MouseDown;
            PasswordShowButton.MouseUp += PasswordShowButton_MouseUp;
            // 
            // RememberCheckBox
            // 
            RememberCheckBox.FlatAppearance.BorderSize = 2;
            RememberCheckBox.FlatStyle = FlatStyle.Flat;
            RememberCheckBox.Location = new Point(56, 373);
            RememberCheckBox.Name = "RememberCheckBox";
            RememberCheckBox.Size = new Size(137, 30);
            RememberCheckBox.TabIndex = 2;
            RememberCheckBox.TabStop = false;
            RememberCheckBox.Text = "Запомнить меня";
            RememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // TitleBar
            // 
            TitleBar.AutoValidate = AutoValidate.EnablePreventFocusChange;
            TitleBar.BackColor = Color.Tomato;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Margin = new Padding(0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(400, 32);
            TitleBar.TabIndex = 6;
            TitleBar.TitleBarColor = Color.Tomato;
            TitleBar.TitleText = "Вход в систему";
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LoginTextBox);
            LoginPanel.Location = new Point(43, 255);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Padding = new Padding(10);
            LoginPanel.Size = new Size(314, 42);
            LoginPanel.TabIndex = 7;
            // 
            // PasswordPanel
            // 
            PasswordPanel.Controls.Add(PasswordShowButton);
            PasswordPanel.Controls.Add(PasswordTextBox);
            PasswordPanel.Location = new Point(43, 318);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Padding = new Padding(10);
            PasswordPanel.Size = new Size(314, 42);
            PasswordPanel.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(60, 310);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Padding = new Padding(4, 0, 4, 0);
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Пароль";
            PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 248);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 4, 0);
            label1.Size = new Size(49, 15);
            label1.TabIndex = 10;
            label1.Text = "Логин";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 500);
            Controls.Add(label1);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordPanel);
            Controls.Add(LoginPanel);
            Controls.Add(TitleBar);
            Controls.Add(RememberCheckBox);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            Load += LoginForm_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button RegisterButton;
        private CheckBox RememberCheckBox;
        private Forms.TitleBar TitleBar;
        private Button PasswordShowButton;
        private Panel LoginPanel;
        private Panel PasswordPanel;
        private Label PasswordLabel;
        private Label label1;
    }
}
