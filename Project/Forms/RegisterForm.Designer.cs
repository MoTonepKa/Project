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
            RegisterButton = new Button();
            NameTextBox = new TextBox();
            LoginTextBox1 = new TextBox();
            UniversityComboBox = new ComboBox();
            UniversityLabel = new Label();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(310, 267);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(145, 32);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(311, 84);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Ваше имя (необязательно):";
            NameTextBox.Size = new Size(176, 23);
            NameTextBox.TabIndex = 1;
            // 
            // LoginTextBox1
            // 
            LoginTextBox1.Location = new Point(311, 123);
            LoginTextBox1.Name = "LoginTextBox1";
            LoginTextBox1.PlaceholderText = "Ваш логин (обязательно):";
            LoginTextBox1.Size = new Size(176, 23);
            LoginTextBox1.TabIndex = 2;
            // 
            // UniversityComboBox
            // 
            UniversityComboBox.FormattingEnabled = true;
            UniversityComboBox.Items.AddRange(new object[] { "ТГТУ", "ТУИТ", "ТГЭУ" });
            UniversityComboBox.Location = new Point(311, 176);
            UniversityComboBox.Name = "UniversityComboBox";
            UniversityComboBox.Size = new Size(140, 23);
            UniversityComboBox.TabIndex = 3;
            // 
            // UniversityLabel
            // 
            UniversityLabel.AutoSize = true;
            UniversityLabel.Location = new Point(311, 158);
            UniversityLabel.Name = "UniversityLabel";
            UniversityLabel.Size = new Size(105, 15);
            UniversityLabel.TabIndex = 4;
            UniversityLabel.Text = "Ваш университет:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(310, 213);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Ваш пароль (обязательно):";
            PasswordTextBox.Size = new Size(177, 23);
            PasswordTextBox.TabIndex = 5;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordTextBox);
            Controls.Add(UniversityLabel);
            Controls.Add(UniversityComboBox);
            Controls.Add(LoginTextBox1);
            Controls.Add(NameTextBox);
            Controls.Add(RegisterButton);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private TextBox NameTextBox;
        private TextBox LoginTextBox1;
        private ComboBox UniversityComboBox;
        private Label UniversityLabel;
        private TextBox PasswordTextBox;
    }
}