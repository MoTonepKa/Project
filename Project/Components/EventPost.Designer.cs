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
            pbImage = new PictureBox();
            lblTitle = new Label();
            lblDesc = new Label();
            lblAuthor = new Label();
            lblDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BackgroundImage = (Image)resources.GetObject("pbImage.BackgroundImage");
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Dock = DockStyle.Top;
            pbImage.Location = new Point(16, 16);
            pbImage.Margin = new Padding(3, 3, 3, 16);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(448, 180);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(16, 212);
            lblTitle.Margin = new Padding(3, 0, 3, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(8, 0, 8, 0);
            lblTitle.Size = new Size(109, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Заголовок";
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDesc.Location = new Point(19, 241);
            lblDesc.Name = "lblDesc";
            lblDesc.Padding = new Padding(4);
            lblDesc.Size = new Size(442, 26);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Описание";
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(16, 287);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(40, 15);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Автор";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDate.Location = new Point(374, 287);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(90, 16);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата";
            lblDate.TextAlign = ContentAlignment.BottomRight;
            // 
            // EventPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(lblDate);
            Controls.Add(lblAuthor);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(pbImage);
            Margin = new Padding(0, 16, 0, 0);
            Name = "EventPost";
            Padding = new Padding(16);
            Size = new Size(480, 320);
            Load += EventPost_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Label lblTitle;
        private Label lblDesc;
        private Label lblAuthor;
        private Label lblDate;
    }
}
