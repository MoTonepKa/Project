namespace Project.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            RegisterButton = new Button();
            NameTextBox = new TextBox();
            LoginTextBox = new TextBox();
            UniversityComboBox = new ComboBox();
            UniversityLabel = new Label();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(197, 358);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(144, 50);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(43, 79);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Ваше имя (необязательно):";
            NameTextBox.Size = new Size(298, 45);
            NameTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(43, 130);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Ваш логин (обязательно):";
            LoginTextBox.Size = new Size(298, 45);
            LoginTextBox.TabIndex = 2;
            // 
            // UniversityComboBox
            // 
            UniversityComboBox.FormattingEnabled = true;
            UniversityComboBox.Items.AddRange(new object[] { "ТГТУ", "ТУИТ", "ТГЭУ" });
            UniversityComboBox.Location = new Point(43, 226);
            UniversityComboBox.Name = "UniversityComboBox";
            UniversityComboBox.Size = new Size(298, 25);
            UniversityComboBox.TabIndex = 3;
            UniversityComboBox.Text = "Пусто";
            // 
            // UniversityLabel
            // 
            UniversityLabel.AutoSize = true;
            UniversityLabel.Location = new Point(43, 206);
            UniversityLabel.Name = "UniversityLabel";
            UniversityLabel.Size = new Size(116, 17);
            UniversityLabel.TabIndex = 4;
            UniversityLabel.Text = "Ваш университет:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(43, 266);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Ваш пароль (обязательно):";
            PasswordTextBox.Size = new Size(298, 45);
            PasswordTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(43, 358);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 50);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Назад";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(384, 441);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UniversityLabel);
            Controls.Add(UniversityComboBox);
            Controls.Add(LoginTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(RegisterButton);
            Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Padding = new Padding(40, 30, 40, 30);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Регистрация";
            FormClosed += RegisterForm_Closed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private TextBox NameTextBox;
        private TextBox LoginTextBox;
        private ComboBox UniversityComboBox;
        private Label UniversityLabel;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}