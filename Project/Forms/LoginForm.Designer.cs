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
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = SystemColors.Window;
            LoginTextBox.Location = new Point(43, 191);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Ваш логин:";
            LoginTextBox.Size = new Size(298, 45);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(43, 259);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Ваш пароль:";
            PasswordTextBox.Size = new Size(298, 45);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(43, 358);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(144, 50);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(197, 358);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(144, 50);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(384, 441);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Font = new Font("Roboto Slab", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Padding = new Padding(40, 30, 40, 30);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button RegisterButton;
    }
}
