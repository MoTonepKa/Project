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
            pbImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbImage.Dock = DockStyle.Top;
            pbImage.Location = new Point(8, 8);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(364, 170);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(8, 180);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Заголовок";
            // 
            // lblDesc
            // 
            lblDesc.Location = new Point(8, 210);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(364, 65);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Описание";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(8, 288);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(40, 15);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Автор";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.Location = new Point(282, 288);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(90, 16);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата";
            lblDate.TextAlign = ContentAlignment.TopRight;
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
            Padding = new Padding(8);
            Size = new Size(380, 312);
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
