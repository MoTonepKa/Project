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
            AvatarImageBox = new PictureBox();
            ProfileLabel = new Label();
            pnlEvents = new FlowLayoutPanel();
            ProfilePanel = new Panel();
            titleBar2 = new TitleBar();
            SidebarPanel = new Panel();
            HomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AvatarImageBox).BeginInit();
            ProfilePanel.SuspendLayout();
            SidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Location = new Point(32, 626);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(260, 50);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AddPostButton
            // 
            AddPostButton.FlatStyle = FlatStyle.Flat;
            AddPostButton.Location = new Point(32, 178);
            AddPostButton.Margin = new Padding(8);
            AddPostButton.Name = "AddPostButton";
            AddPostButton.Size = new Size(260, 50);
            AddPostButton.TabIndex = 1;
            AddPostButton.Text = "Предложить событие";
            AddPostButton.UseVisualStyleBackColor = true;
            // 
            // ModerationButton
            // 
            ModerationButton.BackColor = SystemColors.Window;
            ModerationButton.FlatStyle = FlatStyle.Flat;
            ModerationButton.Location = new Point(32, 244);
            ModerationButton.Margin = new Padding(8);
            ModerationButton.Name = "ModerationButton";
            ModerationButton.Size = new Size(260, 50);
            ModerationButton.TabIndex = 0;
            ModerationButton.Text = "Модерация";
            ModerationButton.UseVisualStyleBackColor = false;
            ModerationButton.Click += ModerationButton_Click;
            // 
            // AvatarImageBox
            // 
            AvatarImageBox.BackgroundImageLayout = ImageLayout.Center;
            AvatarImageBox.Cursor = Cursors.Help;
            AvatarImageBox.Image = (Image)resources.GetObject("AvatarImageBox.Image");
            AvatarImageBox.Location = new Point(13, 13);
            AvatarImageBox.Name = "AvatarImageBox";
            AvatarImageBox.Size = new Size(64, 64);
            AvatarImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            AvatarImageBox.TabIndex = 6;
            AvatarImageBox.TabStop = false;
            // 
            // ProfileLabel
            // 
            ProfileLabel.Location = new Point(83, 13);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(224, 64);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "[Username]";
            ProfileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEvents
            // 
            pnlEvents.AutoScroll = true;
            pnlEvents.BackColor = SystemColors.MenuBar;
            pnlEvents.Location = new Point(355, 32);
            pnlEvents.Margin = new Padding(32, 0, 32, 0);
            pnlEvents.Name = "pnlEvents";
            pnlEvents.Padding = new Padding(64, 16, 64, 32);
            pnlEvents.Size = new Size(884, 688);
            pnlEvents.TabIndex = 8;
            // 
            // ProfilePanel
            // 
            ProfilePanel.Controls.Add(AvatarImageBox);
            ProfilePanel.Controls.Add(ProfileLabel);
            ProfilePanel.Location = new Point(0, -1);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Padding = new Padding(10);
            ProfilePanel.Size = new Size(320, 90);
            ProfilePanel.TabIndex = 0;
            // 
            // titleBar2
            // 
            titleBar2.AutoValidate = AutoValidate.EnablePreventFocusChange;
            titleBar2.BackColor = Color.DodgerBlue;
            titleBar2.Dock = DockStyle.Top;
            titleBar2.Location = new Point(0, 0);
            titleBar2.Margin = new Padding(0);
            titleBar2.Name = "titleBar2";
            titleBar2.Size = new Size(1280, 32);
            titleBar2.TabIndex = 0;
            titleBar2.TitleBarColor = Color.DodgerBlue;
            titleBar2.TitleText = "MainForm";
            // 
            // SidebarPanel
            // 
            SidebarPanel.Controls.Add(HomeButton);
            SidebarPanel.Controls.Add(ProfilePanel);
            SidebarPanel.Controls.Add(ModerationButton);
            SidebarPanel.Controls.Add(AddPostButton);
            SidebarPanel.Controls.Add(LogoutButton);
            SidebarPanel.Location = new Point(0, 32);
            SidebarPanel.Margin = new Padding(8);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Padding = new Padding(8);
            SidebarPanel.Size = new Size(320, 688);
            SidebarPanel.TabIndex = 9;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = SystemColors.Window;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Location = new Point(32, 112);
            HomeButton.Margin = new Padding(8);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(260, 50);
            HomeButton.TabIndex = 3;
            HomeButton.Text = "Главная страница";
            HomeButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            CausesValidation = false;
            ClientSize = new Size(1280, 720);
            Controls.Add(SidebarPanel);
            Controls.Add(titleBar2);
            Controls.Add(pnlEvents);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += MainForm_Closed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)AvatarImageBox).EndInit();
            ProfilePanel.ResumeLayout(false);
            SidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button AddPostButton;
        private Button ModerationButton;
        private PictureBox AvatarImageBox;
        private Label ProfileLabel;
        private FlowLayoutPanel pnlEvents;
        private TitleBar titleBar1;
        private Panel ProfilePanel;
        private TitleBar titleBar2;
        private Panel SidebarPanel;
        private Button HomeButton;
    }
}