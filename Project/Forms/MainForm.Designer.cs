namespace Project.Forms
{
    partial class MainForm
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
            LogoutButton = new Button();
            AddPostButton = new Button();
            ModerationButton = new Button();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(673, 7);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(98, 25);
            LogoutButton.TabIndex = 0;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AddPostButton
            // 
            AddPostButton.Location = new Point(645, 415);
            AddPostButton.Name = "AddPostButton";
            AddPostButton.Size = new Size(143, 23);
            AddPostButton.TabIndex = 1;
            AddPostButton.Text = "Предложить событие";
            AddPostButton.UseVisualStyleBackColor = true;
            // 
            // ModerationButton
            // 
            ModerationButton.Location = new Point(646, 379);
            ModerationButton.Name = "ModerationButton";
            ModerationButton.Size = new Size(142, 23);
            ModerationButton.TabIndex = 2;
            ModerationButton.Text = "Модерация";
            ModerationButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModerationButton);
            Controls.Add(AddPostButton);
            Controls.Add(LogoutButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button AddPostButton;
        private Button ModerationButton;
    }
}