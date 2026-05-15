namespace Project.Forms
{
    partial class TitleBar
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
            MinimizeButton = new Button();
            CloseButton = new Button();
            TitleLabel = new Label();
            SuspendLayout();
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.Transparent;
            MinimizeButton.BackgroundImage = Properties.Resources.remove;
            MinimizeButton.BackgroundImageLayout = ImageLayout.Center;
            MinimizeButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Location = new Point(108, 0);
            MinimizeButton.Margin = new Padding(0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(48, 32);
            MinimizeButton.TabIndex = 11;
            MinimizeButton.TabStop = false;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.BackgroundImage = Properties.Resources.close;
            CloseButton.BackgroundImageLayout = ImageLayout.Center;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(153, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(48, 32);
            CloseButton.TabIndex = 10;
            CloseButton.TabStop = false;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TitleLabel.ForeColor = SystemColors.ControlText;
            TitleLabel.Location = new Point(8, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(61, 15);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "TITLEBAR";
            TitleLabel.MouseDown += TitleBar_MouseDown;
            // 
            // TitleBar
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DarkGray;
            Controls.Add(TitleLabel);
            Controls.Add(MinimizeButton);
            Controls.Add(CloseButton);
            Margin = new Padding(0);
            Name = "TitleBar";
            Size = new Size(200, 32);
            Load += TitleBar_Load;
            MouseDown += TitleBar_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MinimizeButton;
        private Button CloseButton;
        private Label TitleLabel;
    }
}
