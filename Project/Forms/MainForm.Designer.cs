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
            pnlEvents = new FlowLayoutPanel();
            SidebarFlowLayoutPanel = new FlowLayoutPanel();
            ProfilePanel = new Panel();
            titleBar2 = new TitleBar();
            ((System.ComponentModel.ISupportInitialize)ProfileImageBox).BeginInit();
            SidebarFlowLayoutPanel.SuspendLayout();
            ProfilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(11, 219);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(197, 50);
            LogoutButton.TabIndex = 2;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AddPostButton
            // 
            AddPostButton.Location = new Point(11, 163);
            AddPostButton.Name = "AddPostButton";
            AddPostButton.Size = new Size(197, 50);
            AddPostButton.TabIndex = 1;
            AddPostButton.Text = "Предложить событие";
            AddPostButton.UseVisualStyleBackColor = true;
            AddPostButton.Click += AddPostButton_Click;
            // 
            // ModerationButton
            // 
            ModerationButton.BackColor = SystemColors.Window;
            ModerationButton.FlatStyle = FlatStyle.System;
            ModerationButton.Location = new Point(11, 107);
            ModerationButton.Name = "ModerationButton";
            ModerationButton.Size = new Size(197, 50);
            ModerationButton.TabIndex = 0;
            ModerationButton.Text = "Модерация";
            ModerationButton.UseVisualStyleBackColor = false;
            // 
            // ProfileImageBox
            // 
            ProfileImageBox.BackgroundImage = Properties.Resources.default_avatar;
            ProfileImageBox.BackgroundImageLayout = ImageLayout.Stretch;
            ProfileImageBox.Cursor = Cursors.Help;
            ProfileImageBox.Location = new Point(13, 13);
            ProfileImageBox.Name = "ProfileImageBox";
            ProfileImageBox.Size = new Size(64, 64);
            ProfileImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfileImageBox.TabIndex = 6;
            ProfileImageBox.TabStop = false;
            // 
            // ProfileLabel
            // 
            ProfileLabel.Location = new Point(83, 13);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(101, 64);
            ProfileLabel.TabIndex = 7;
            ProfileLabel.Text = "[Username]";
            ProfileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlEvents
            // 
            pnlEvents.AutoScroll = true;
            pnlEvents.BackColor = SystemColors.MenuBar;
            pnlEvents.Location = new Point(240, 35);
            pnlEvents.Name = "pnlEvents";
            pnlEvents.Padding = new Padding(32, 8, 32, 8);
            pnlEvents.Size = new Size(628, 513);
            pnlEvents.TabIndex = 8;
            // 
            // SidebarFlowLayoutPanel
            // 
            SidebarFlowLayoutPanel.Controls.Add(ProfilePanel);
            SidebarFlowLayoutPanel.Controls.Add(ModerationButton);
            SidebarFlowLayoutPanel.Controls.Add(AddPostButton);
            SidebarFlowLayoutPanel.Controls.Add(LogoutButton);
            SidebarFlowLayoutPanel.Location = new Point(0, 32);
            SidebarFlowLayoutPanel.Margin = new Padding(0);
            SidebarFlowLayoutPanel.Name = "SidebarFlowLayoutPanel";
            SidebarFlowLayoutPanel.Padding = new Padding(8);
            SidebarFlowLayoutPanel.Size = new Size(220, 528);
            SidebarFlowLayoutPanel.TabIndex = 10;
            // 
            // ProfilePanel
            // 
            ProfilePanel.Controls.Add(ProfileImageBox);
            ProfilePanel.Controls.Add(ProfileLabel);
            ProfilePanel.Location = new Point(11, 11);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Padding = new Padding(10);
            ProfilePanel.Size = new Size(197, 90);
            ProfilePanel.TabIndex = 0;
            // 
            // titleBar2
            // 
            titleBar2.AutoValidate = AutoValidate.EnablePreventFocusChange;
            titleBar2.BackColor = Color.DarkGray;
            titleBar2.Location = new Point(0, 0);
            titleBar2.Margin = new Padding(0);
            titleBar2.Name = "titleBar2";
            titleBar2.Size = new Size(880, 32);
            titleBar2.TabIndex = 0;
            titleBar2.Title = "MainForm";
            // 
            // MainForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            CausesValidation = false;
            ClientSize = new Size(880, 560);
            Controls.Add(titleBar2);
            Controls.Add(SidebarFlowLayoutPanel);
            Controls.Add(pnlEvents);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Padding = new Padding(0, 32, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosed += MainForm_Closed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfileImageBox).EndInit();
            SidebarFlowLayoutPanel.ResumeLayout(false);
            ProfilePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button AddPostButton;
        private Button ModerationButton;
        private PictureBox ProfileImageBox;
        private Label ProfileLabel;
        private FlowLayoutPanel pnlEvents;
        private TitleBar titleBar1;
        private FlowLayoutPanel SidebarFlowLayoutPanel;
        private Panel ProfilePanel;
        private TitleBar titleBar2;
    }
}