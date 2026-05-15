namespace Project.Forms
{
    partial class CreateEventForm
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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            picPreview = new PictureBox();
            btnSelectImage = new Button();
            btnRemoveImage = new Button();
            btnPublish = new Button();
            btnCancel = new Button();
            selectImageDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Введите заголовок";
            txtTitle.Size = new Size(222, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 73);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Введите описание";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(222, 135);
            txtDescription.TabIndex = 1;
            // 
            // picPreview
            // 
            picPreview.Location = new Point(264, 44);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(364, 170);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 4;
            picPreview.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(264, 233);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(158, 23);
            btnSelectImage.TabIndex = 5;
            btnSelectImage.Text = "Добавить картинку";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Location = new Point(478, 233);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(150, 23);
            btnRemoveImage.TabIndex = 6;
            btnRemoveImage.Text = "Убрать картинку";
            btnRemoveImage.UseVisualStyleBackColor = true;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // btnPublish
            // 
            btnPublish.Location = new Point(12, 389);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(154, 49);
            btnPublish.TabIndex = 7;
            btnPublish.Text = "Опубликовать";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(474, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 49);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnPublish);
            Controls.Add(btnRemoveImage);
            Controls.Add(btnSelectImage);
            Controls.Add(picPreview);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "CreateEventForm";
            Text = "Предложить событие";
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private PictureBox picPreview;
        private Button btnSelectImage;
        private Button btnRemoveImage;
        private Button btnPublish;
        private Button btnCancel;
        private OpenFileDialog selectImageDialog;
    }
}