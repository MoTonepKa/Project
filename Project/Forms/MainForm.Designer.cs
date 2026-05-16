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
            ProfileImageBox = new PictureBox();
            ProfileLabel = new Label();
            EventsPanel = new FlowLayoutPanel();
            SidebarFlowLayoutPanel = new FlowLayoutPanel();
            ProfilePanel = new Panel();
            StudenthatImage = new PictureBox();
            Line2 = new PictureBox();
            Line1 = new PictureBox();
            Line0 = new PictureBox();
            TitleBar = new TitleBar();
            FooterPanel = new Panel();
            pictureBox1 = new PictureBox();
            Line3 = new PictureBox();
            LanguageButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfileImageBox).BeginInit();
            SidebarFlowLayoutPanel.SuspendLayout();
            ProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudenthatImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Line2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Line1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Line0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Line3).BeginInit();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.DarkRed;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = SystemColors.Window;
            LogoutButton.Location = new Point(48, 496);
            LogoutButton.Margin = new Padding(16, 16, 16, 3);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(296, 50);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AddPostButton
            // 
            AddPostButton.BackColor = Color.DarkRed;
            AddPostButton.FlatAppearance.BorderSize = 0;
            AddPostButton.FlatStyle = FlatStyle.Flat;
            AddPostButton.ForeColor = SystemColors.Window;
            AddPostButton.Location = new Point(48, 318);
            AddPostButton.Margin = new Padding(16, 16, 16, 3);
            AddPostButton.Name = "AddPostButton";
            AddPostButton.Size = new Size(296, 50);
            AddPostButton.TabIndex = 1;
            AddPostButton.Text = "Добавить пост";
            AddPostButton.UseVisualStyleBackColor = false;
            AddPostButton.Click += AddPostButton_Click;
            // 
            // ModerationButton
            // 
            ModerationButton.BackColor = Color.DarkRed;
            ModerationButton.FlatAppearance.BorderSize = 0;
            ModerationButton.FlatStyle = FlatStyle.Flat;
            ModerationButton.ForeColor = SystemColors.Window;
            ModerationButton.Location = new Point(48, 229);
            ModerationButton.Margin = new Padding(16, 16, 16, 3);
            ModerationButton.Name = "ModerationButton";
            ModerationButton.Size = new Size(296, 50);
            ModerationButton.TabIndex = 0;
            ModerationButton.Text = "Модерация";
            ModerationButton.UseVisualStyleBackColor = false;
            // 
            // ProfileImageBox
            // 
            ProfileImageBox.Anchor = AnchorStyles.Top;
            ProfileImageBox.BackColor = Color.Transparent;
            ProfileImageBox.BackgroundImage = Properties.Resources.default_avatar;
            ProfileImageBox.BackgroundImageLayout = ImageLayout.Stretch;
            ProfileImageBox.Cursor = Cursors.Help;
            ProfileImageBox.Location = new Point(132, 19);
            ProfileImageBox.Name = "ProfileImageBox";
            ProfileImageBox.Size = new Size(60, 60);
            ProfileImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfileImageBox.TabIndex = 6;
            ProfileImageBox.TabStop = false;
            // 
            // ProfileLabel
            // 
            ProfileLabel.Dock = DockStyle.Bottom;
            ProfileLabel.Location = new Point(16, 95);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(293, 60);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "[Username]";
            // 
            // EventsPanel
            // 
            EventsPanel.AutoScroll = true;
            EventsPanel.Location = new Point(540, 60);
            EventsPanel.Name = "EventsPanel";
            EventsPanel.Padding = new Padding(32, 8, 32, 16);
            EventsPanel.Size = new Size(720, 597);
            EventsPanel.TabIndex = 8;
            // 
            // SidebarFlowLayoutPanel
            // 
            SidebarFlowLayoutPanel.BackColor = Color.FromArgb(255, 246, 246);
            SidebarFlowLayoutPanel.Controls.Add(ProfilePanel);
            SidebarFlowLayoutPanel.Controls.Add(Line0);
            SidebarFlowLayoutPanel.Controls.Add(ModerationButton);
            SidebarFlowLayoutPanel.Controls.Add(Line1);
            SidebarFlowLayoutPanel.Controls.Add(AddPostButton);
            SidebarFlowLayoutPanel.Controls.Add(Line2);
            SidebarFlowLayoutPanel.Controls.Add(LanguageButton);
            SidebarFlowLayoutPanel.Controls.Add(Line3);
            SidebarFlowLayoutPanel.Controls.Add(LogoutButton);
            SidebarFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            SidebarFlowLayoutPanel.Location = new Point(24, 60);
            SidebarFlowLayoutPanel.Margin = new Padding(0);
            SidebarFlowLayoutPanel.Name = "SidebarFlowLayoutPanel";
            SidebarFlowLayoutPanel.Padding = new Padding(32, 16, 0, 8);
            SidebarFlowLayoutPanel.Size = new Size(400, 597);
            SidebarFlowLayoutPanel.TabIndex = 10;
            // 
            // ProfilePanel
            // 
            ProfilePanel.Controls.Add(ProfileImageBox);
            ProfilePanel.Controls.Add(ProfileLabel);
            ProfilePanel.Controls.Add(StudenthatImage);
            ProfilePanel.Location = new Point(35, 19);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Padding = new Padding(16);
            ProfilePanel.Size = new Size(325, 171);
            ProfilePanel.TabIndex = 0;
            // 
            // StudenthatImage
            // 
            StudenthatImage.Anchor = AnchorStyles.Top;
            StudenthatImage.BackColor = Color.Transparent;
            StudenthatImage.BackgroundImage = Properties.Resources.student_hat;
            StudenthatImage.BackgroundImageLayout = ImageLayout.Zoom;
            StudenthatImage.Cursor = Cursors.Help;
            StudenthatImage.Location = new Point(144, -4);
            StudenthatImage.Name = "StudenthatImage";
            StudenthatImage.Size = new Size(72, 56);
            StudenthatImage.SizeMode = PictureBoxSizeMode.Zoom;
            StudenthatImage.TabIndex = 8;
            StudenthatImage.TabStop = false;
            // 
            // Line2
            // 
            Line2.BackColor = Color.FromArgb(97, 20, 20);
            Line2.Location = new Point(35, 387);
            Line2.Margin = new Padding(3, 16, 3, 3);
            Line2.Name = "Line2";
            Line2.Size = new Size(325, 1);
            Line2.TabIndex = 5;
            Line2.TabStop = false;
            // 
            // Line1
            // 
            Line1.BackColor = Color.FromArgb(97, 20, 20);
            Line1.Location = new Point(35, 298);
            Line1.Margin = new Padding(3, 16, 3, 3);
            Line1.Name = "Line1";
            Line1.Size = new Size(325, 1);
            Line1.TabIndex = 4;
            Line1.TabStop = false;
            // 
            // Line0
            // 
            Line0.BackColor = Color.FromArgb(97, 20, 20);
            Line0.Location = new Point(35, 209);
            Line0.Margin = new Padding(3, 16, 3, 3);
            Line0.Name = "Line0";
            Line0.Size = new Size(325, 1);
            Line0.TabIndex = 3;
            Line0.TabStop = false;
            // 
            // TitleBar
            // 
            TitleBar.AutoValidate = AutoValidate.EnablePreventFocusChange;
            TitleBar.BackColor = Color.FromArgb(97, 20, 20);
            TitleBar.Dock = DockStyle.Top;
            TitleBar.Location = new Point(0, 0);
            TitleBar.Margin = new Padding(0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(1280, 32);
            TitleBar.TabIndex = 0;
            TitleBar.Title = "MainForm";
            TitleBar.TitlebarColor = Color.FromArgb(97, 20, 20);
            TitleBar.TitlelabelColor = SystemColors.Window;
            // 
            // FooterPanel
            // 
            FooterPanel.BackColor = Color.FromArgb(97, 20, 20);
            FooterPanel.Dock = DockStyle.Bottom;
            FooterPanel.Location = new Point(0, 688);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new Size(1280, 32);
            FooterPanel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.texture1;
            pictureBox1.Location = new Point(434, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 660);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Line3
            // 
            Line3.BackColor = Color.FromArgb(97, 20, 20);
            Line3.Location = new Point(35, 476);
            Line3.Margin = new Padding(3, 16, 3, 3);
            Line3.Name = "Line3";
            Line3.Size = new Size(325, 1);
            Line3.TabIndex = 6;
            Line3.TabStop = false;
            // 
            // LanguageButton
            // 
            LanguageButton.BackColor = Color.DarkRed;
            LanguageButton.FlatAppearance.BorderSize = 0;
            LanguageButton.FlatStyle = FlatStyle.Flat;
            LanguageButton.ForeColor = SystemColors.Window;
            LanguageButton.Location = new Point(48, 407);
            LanguageButton.Margin = new Padding(16, 16, 16, 3);
            LanguageButton.Name = "LanguageButton";
            LanguageButton.Size = new Size(296, 50);
            LanguageButton.TabIndex = 7;
            LanguageButton.Text = "Добавить пост";
            LanguageButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(253, 253, 253);
            CausesValidation = false;
            ClientSize = new Size(1280, 720);
            Controls.Add(FooterPanel);
            Controls.Add(TitleBar);
            Controls.Add(SidebarFlowLayoutPanel);
            Controls.Add(EventsPanel);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += MainForm_Closed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfileImageBox).EndInit();
            SidebarFlowLayoutPanel.ResumeLayout(false);
            ProfilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudenthatImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Line2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Line1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Line0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Line3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button AddPostButton;
        private Button ModerationButton;
        private PictureBox ProfileImageBox;
        private Label ProfileLabel;
        private FlowLayoutPanel EventsPanel;
        private TitleBar titleBar1;
        private FlowLayoutPanel SidebarFlowLayoutPanel;
        private Panel ProfilePanel;
        private TitleBar TitleBar;
        private Panel FooterPanel;
        private PictureBox Line0;
        private PictureBox Line2;
        private PictureBox Line1;
        private PictureBox StudenthatImage;
        private PictureBox pictureBox1;
        private Button LanguageButton;
        private PictureBox Line3;
    }
}