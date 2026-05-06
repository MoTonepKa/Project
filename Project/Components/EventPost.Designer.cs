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
            pbImage.Location = new Point(12, 29);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(350, 170);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(9, 211);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(65, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Заголовок";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(9, 235);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(62, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Описание";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(12, 11);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(40, 15);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Автор";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(324, 11);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(32, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата";
            // 
            // EventPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDate);
            Controls.Add(lblAuthor);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(pbImage);
            Name = "EventPost";
            Size = new Size(379, 311);
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
