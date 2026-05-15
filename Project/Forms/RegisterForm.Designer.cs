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
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            label1 = new Label();
            TitleBar = new TitleBar();
            PasswordPanel = new Panel();
            LoginPanel = new Panel();
            NamePanel = new Panel();
            UniversityPanel = new Panel();
            PasswordLabel = new Label();
            NameLabel = new Label();
            label2 = new Label();
            PasswordPanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            UniversityPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Location = new Point(207, 417);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 50);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Location = new Point(13, 13);
            NameTextBox.MaxLength = 32;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "введите имя (необязательно)";
            NameTextBox.Size = new Size(288, 16);
            NameTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Location = new Point(13, 13);
            LoginTextBox.MaxLength = 32;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "введите логин (обязательно)";
            LoginTextBox.Size = new Size(288, 16);
            LoginTextBox.TabIndex = 2;
            // 
            // UniversityComboBox
            // 
            UniversityComboBox.BackColor = SystemColors.Window;
            UniversityComboBox.DisplayMember = "0";
            UniversityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UniversityComboBox.FlatStyle = FlatStyle.Flat;
            UniversityComboBox.FormattingEnabled = true;
            UniversityComboBox.Items.AddRange(new object[] { "Не учусь", "ТУИТ", "ТГТУ", "ТГЭУ" });
            UniversityComboBox.Location = new Point(8, 9);
            UniversityComboBox.Name = "UniversityComboBox";
            UniversityComboBox.Size = new Size(298, 23);
            UniversityComboBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Location = new Point(13, 13);
            PasswordTextBox.MaxLength = 16;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "введите пароль (обязательно)";
            PasswordTextBox.Size = new Size(288, 16);
            PasswordTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Location = new Point(43, 417);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 50);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Назад";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 248);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Padding = new Padding(4, 0, 4, 0);
            label1.Size = new Size(84, 15);
            label1.TabIndex = 10;
            label1.Text = "Университет";
            // 
            // TitleBar
            // 
            TitleBar.AutoValidate = AutoValidate.EnablePreventFocusChange;
            TitleBar.BackColor = Color.SpringGreen;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Margin = new Padding(0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(400, 32);
            TitleBar.TabIndex = 11;
            TitleBar.TitleBarColor = Color.SpringGreen;
            TitleBar.TitleText = "Регистрация";
            // 
            // PasswordPanel
            // 
            PasswordPanel.Controls.Add(LoginTextBox);
            PasswordPanel.Location = new Point(43, 170);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Padding = new Padding(10);
            PasswordPanel.Size = new Size(314, 42);
            PasswordPanel.TabIndex = 13;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(PasswordTextBox);
            LoginPanel.Location = new Point(43, 318);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Padding = new Padding(10);
            LoginPanel.Size = new Size(314, 42);
            LoginPanel.TabIndex = 12;
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(NameTextBox);
            NamePanel.Location = new Point(43, 112);
            NamePanel.Name = "NamePanel";
            NamePanel.Padding = new Padding(10);
            NamePanel.Size = new Size(314, 42);
            NamePanel.TabIndex = 14;
            // 
            // UniversityPanel
            // 
            UniversityPanel.Controls.Add(UniversityComboBox);
            UniversityPanel.Location = new Point(43, 255);
            UniversityPanel.Name = "UniversityPanel";
            UniversityPanel.Padding = new Padding(10);
            UniversityPanel.Size = new Size(314, 42);
            UniversityPanel.TabIndex = 13;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(60, 310);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Padding = new Padding(4, 0, 4, 0);
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 10;
            PasswordLabel.Text = "Пароль";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(60, 104);
            NameLabel.Name = "NameLabel";
            NameLabel.Padding = new Padding(4, 0, 4, 0);
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 15;
            NameLabel.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 164);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 0, 4, 0);
            label2.Size = new Size(49, 15);
            label2.TabIndex = 16;
            label2.Text = "Логин";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 500);
            Controls.Add(label2);
            Controls.Add(NameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(NamePanel);
            Controls.Add(PasswordPanel);
            Controls.Add(LoginPanel);
            Controls.Add(TitleBar);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(UniversityPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Padding = new Padding(40, 29, 40, 29);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Регистрация";
            FormClosed += RegisterForm_Closed;
            Load += RegisterForm_Load;
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            UniversityPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private TextBox NameTextBox;
        private TextBox LoginTextBox;
        private ComboBox UniversityComboBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Label label1;
        private TitleBar TitleBar;
        private Panel PasswordPanel;
        private Panel LoginPanel;
        private Panel NamePanel;
        private Panel UniversityPanel;
        private Label PasswordLabel;
        private Label NameLabel;
        private Label label2;
    }
}