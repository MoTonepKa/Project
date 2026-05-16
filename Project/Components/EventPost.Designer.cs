namespace Project.Components
{
    partial class EventPost
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPost));
            PostPictureBox = new PictureBox();
            TitleLabel = new Label();
            TextLabel = new Label();
            AuthorLabel = new Label();
            DateLabel = new Label();
            AlarmIcon = new PictureBox();
            ProfilePictureBox = new PictureBox();
            StudenthatImage = new PictureBox();
            FavoriteLabel = new Label();
            HeartIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PostPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlarmIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudenthatImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeartIcon).BeginInit();
            SuspendLayout();
            // 
            // PostPictureBox
            // 
            PostPictureBox.BackgroundImage = (Image)resources.GetObject("PostPictureBox.BackgroundImage");
            PostPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            PostPictureBox.Location = new Point(0, 70);
            PostPictureBox.Name = "PostPictureBox";
            PostPictureBox.Size = new Size(600, 420);
            PostPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PostPictureBox.TabIndex = 0;
            PostPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TitleLabel.Location = new Point(32, 510);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(273, 20);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Заголовок";
            // 
            // TextLabel
            // 
            TextLabel.Location = new Point(28, 542);
            TextLabel.Name = "TextLabel";
            TextLabel.Size = new Size(538, 65);
            TextLabel.TabIndex = 2;
            TextLabel.Text = "Описание";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(90, 34);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(61, 15);
            AuthorLabel.TabIndex = 3;
            AuthorLabel.Text = "Nickname";
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateLabel.Location = new Point(370, 34);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(171, 16);
            DateLabel.TabIndex = 4;
            DateLabel.Text = "Дата поста: 00. 00. 0000";
            DateLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AlarmIcon
            // 
            AlarmIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AlarmIcon.Image = Properties.Resources.alarm;
            AlarmIcon.Location = new Point(548, 28);
            AlarmIcon.Name = "AlarmIcon";
            AlarmIcon.Size = new Size(24, 24);
            AlarmIcon.TabIndex = 5;
            AlarmIcon.TabStop = false;
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.BackgroundImage = Properties.Resources.default_avatar;
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(28, 22);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(38, 38);
            ProfilePictureBox.TabIndex = 6;
            ProfilePictureBox.TabStop = false;
            // 
            // StudenthatImage
            // 
            StudenthatImage.BackColor = Color.Transparent;
            StudenthatImage.BackgroundImage = Properties.Resources.student_hat;
            StudenthatImage.BackgroundImageLayout = ImageLayout.Zoom;
            StudenthatImage.Cursor = Cursors.Help;
            StudenthatImage.Location = new Point(34, 7);
            StudenthatImage.Name = "StudenthatImage";
            StudenthatImage.Size = new Size(50, 36);
            StudenthatImage.SizeMode = PictureBoxSizeMode.Zoom;
            StudenthatImage.TabIndex = 9;
            StudenthatImage.TabStop = false;
            // 
            // FavoriteLabel
            // 
            FavoriteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FavoriteLabel.Location = new Point(281, 515);
            FavoriteLabel.Name = "FavoriteLabel";
            FavoriteLabel.Size = new Size(260, 20);
            FavoriteLabel.TabIndex = 10;
            FavoriteLabel.Text = "Количество реакций: 134 тыс.";
            FavoriteLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // HeartIcon
            // 
            HeartIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HeartIcon.Image = Properties.Resources.heart;
            HeartIcon.Location = new Point(548, 511);
            HeartIcon.Name = "HeartIcon";
            HeartIcon.Size = new Size(24, 24);
            HeartIcon.TabIndex = 11;
            HeartIcon.TabStop = false;
            // 
            // EventPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(HeartIcon);
            Controls.Add(FavoriteLabel);
            Controls.Add(ProfilePictureBox);
            Controls.Add(AlarmIcon);
            Controls.Add(AuthorLabel);
            Controls.Add(DateLabel);
            Controls.Add(TextLabel);
            Controls.Add(TitleLabel);
            Controls.Add(PostPictureBox);
            Controls.Add(StudenthatImage);
            Margin = new Padding(0);
            Name = "EventPost";
            Padding = new Padding(8);
            Size = new Size(600, 628);
            ((System.ComponentModel.ISupportInitialize)PostPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlarmIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudenthatImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeartIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PostPictureBox;
        private Label TitleLabel;
        private Label TextLabel;
        private Label AuthorLabel;
        private Label DateLabel;
        private PictureBox AlarmIcon;
        private PictureBox ProfilePictureBox;
        private PictureBox StudenthatImage;
        private Label FavoriteLabel;
        private PictureBox HeartIcon;
    }
}
