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
            NameGroupBox = new GroupBox();
            LoginGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TitleBar = new TitleBar();
            AgreementCheckBox = new CheckBox();
            NameGroupBox.SuspendLayout();
            LoginGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(203, 418);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(154, 50);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Location = new Point(13, 22);
            NameTextBox.MaxLength = 32;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "введите имя (необязательно)";
            NameTextBox.Size = new Size(288, 16);
            NameTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Location = new Point(13, 22);
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
            UniversityComboBox.FlatStyle = FlatStyle.System;
            UniversityComboBox.FormattingEnabled = true;
            UniversityComboBox.Items.AddRange(new object[] { "Не учусь", "ТУИТ", "ТГТУ", "ТГЭУ" });
            UniversityComboBox.Location = new Point(43, 276);
            UniversityComboBox.Name = "UniversityComboBox";
            UniversityComboBox.Size = new Size(314, 23);
            UniversityComboBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Location = new Point(13, 22);
            PasswordTextBox.MaxLength = 16;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "введите пароль (обязательно)";
            PasswordTextBox.Size = new Size(288, 16);
            PasswordTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(43, 418);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(154, 50);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Назад";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // NameGroupBox
            // 
            NameGroupBox.Controls.Add(NameTextBox);
            NameGroupBox.Location = new Point(43, 112);
            NameGroupBox.Name = "NameGroupBox";
            NameGroupBox.Padding = new Padding(10, 2, 10, 10);
            NameGroupBox.Size = new Size(314, 50);
            NameGroupBox.TabIndex = 7;
            NameGroupBox.TabStop = false;
            NameGroupBox.Text = "Имя";
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.Controls.Add(LoginTextBox);
            LoginGroupBox.Location = new Point(43, 168);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Padding = new Padding(10, 2, 10, 10);
            LoginGroupBox.Size = new Size(314, 50);
            LoginGroupBox.TabIndex = 8;
            LoginGroupBox.TabStop = false;
            LoginGroupBox.Text = "Логин";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PasswordTextBox);
            groupBox1.Location = new Point(43, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 2, 10, 10);
            groupBox1.Size = new Size(314, 50);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 254);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 10;
            label1.Text = "Университет";
            // 
            // TitleBar
            // 
            TitleBar.AutoValidate = AutoValidate.EnablePreventFocusChange;
            TitleBar.BackColor = Color.DarkGray;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Margin = new Padding(0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(400, 32);
            TitleBar.TabIndex = 11;
            TitleBar.Title = "Регистрация";
            // 
            // AgreementCheckBox
            // 
            AgreementCheckBox.FlatStyle = FlatStyle.System;
            AgreementCheckBox.Location = new Point(56, 373);
            AgreementCheckBox.Name = "AgreementCheckBox";
            AgreementCheckBox.Size = new Size(250, 30);
            AgreementCheckBox.TabIndex = 12;
            AgreementCheckBox.Text = "Я согласен c условиями приложения";
            AgreementCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 500);
            Controls.Add(AgreementCheckBox);
            Controls.Add(TitleBar);
            Controls.Add(label1);
            Controls.Add(UniversityComboBox);
            Controls.Add(groupBox1);
            Controls.Add(LoginGroupBox);
            Controls.Add(NameGroupBox);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
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
            NameGroupBox.ResumeLayout(false);
            NameGroupBox.PerformLayout();
            LoginGroupBox.ResumeLayout(false);
            LoginGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox NameGroupBox;
        private GroupBox LoginGroupBox;
        private GroupBox groupBox1;
        private Label label1;
        private TitleBar TitleBar;
        private CheckBox AgreementCheckBox;
    }
}