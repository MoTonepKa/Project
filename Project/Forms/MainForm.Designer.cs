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
            ExitButton = new Button();
            AddPostButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(673, 7);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(98, 25);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddPostButton);
            Controls.Add(ExitButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button AddPostButton;
    }
}