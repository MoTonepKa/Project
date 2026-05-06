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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LogoutButton = new Button();
            AddPostButton = new Button();
            ModerationButton = new Button();
            SearchTextBox = new TextBox();
            SearchPanel = new Panel();
            ProfileImageBox = new PictureBox();
            ProfileLabel = new Label();
            pnlEvents = new FlowLayoutPanel();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfileImageBox).BeginInit();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(26, 459);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(200, 50);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AddPostButton
            // 
            AddPostButton.Location = new Point(26, 403);
            AddPostButton.Name = "AddPostButton";
            AddPostButton.Size = new Size(200, 50);
            AddPostButton.TabIndex = 1;
            AddPostButton.Text = "Предложить событие";
            AddPostButton.UseVisualStyleBackColor = true;
            // 
            // ModerationButton
            // 
            ModerationButton.BackColor = SystemColors.Window;
            ModerationButton.FlatStyle = FlatStyle.System;
            ModerationButton.Location = new Point(26, 347);
            ModerationButton.Name = "ModerationButton";
            ModerationButton.Size = new Size(200, 50);
            ModerationButton.TabIndex = 0;
            ModerationButton.Text = "Модерация";
            ModerationButton.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderStyle = BorderStyle.None;
            SearchTextBox.Location = new Point(13, 13);
            SearchTextBox.MaxLength = 64;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Поиск... (пока что не работает)";
            SearchTextBox.Size = new Size(567, 16);
            SearchTextBox.TabIndex = 3;
            // 
            // SearchPanel
            // 
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(SearchTextBox);
            SearchPanel.Location = new Point(248, 9);
            SearchPanel.Margin = new Padding(0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Padding = new Padding(10);
            SearchPanel.Size = new Size(595, 44);
            SearchPanel.TabIndex = 5;
            // 
            // ProfileImageBox
            // 
            ProfileImageBox.BackgroundImageLayout = ImageLayout.None;
            ProfileImageBox.Cursor = Cursors.Help;
            ProfileImageBox.Image = (Image)resources.GetObject("ProfileImageBox.Image");
            ProfileImageBox.Location = new Point(12, 7);
            ProfileImageBox.Name = "ProfileImageBox";
            ProfileImageBox.Size = new Size(229, 150);
            ProfileImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfileImageBox.TabIndex = 6;
            ProfileImageBox.TabStop = false;
            // 
            // ProfileLabel
            // 
            ProfileLabel.Location = new Point(12, 160);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(229, 32);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "[ProfileUsername]";
            ProfileLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEvents
            // 
            pnlEvents.Location = new Point(248, 57);
            pnlEvents.Name = "pnlEvents";
            pnlEvents.Size = new Size(595, 452);
            pnlEvents.TabIndex = 8;
            // 
            // MainForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            CausesValidation = false;
            ClientSize = new Size(864, 521);
            Controls.Add(pnlEvents);
            Controls.Add(ProfileLabel);
            Controls.Add(ProfileImageBox);
            Controls.Add(SearchPanel);
            Controls.Add(ModerationButton);
            Controls.Add(AddPostButton);
            Controls.Add(LogoutButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += MainForm_Closed;
            Load += MainForm_Load;
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfileImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button AddPostButton;
        private Button ModerationButton;
        private TextBox SearchTextBox;
        private Panel SearchPanel;
        private PictureBox ProfileImageBox;
        private Label ProfileLabel;
        private FlowLayoutPanel pnlEvents;
    }
}