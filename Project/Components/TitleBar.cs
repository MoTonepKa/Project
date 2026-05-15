using System.ComponentModel;
using System.Drawing;

namespace Project.Forms
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TitleText
        {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TitleBarColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        public const int WM_NLCBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(FindForm().Handle, WM_NLCBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleBar_Load(object sender, EventArgs e)
        {
            DrawInterface.LoadFont(TitleLabel);
            DrawInterface.DrawBorderLine(this);

            MinimizeButton.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(BackColor, 0.01f);
            MinimizeButton.FlatAppearance.MouseOverBackColor = ControlPaint.LightLight(BackColor);

            CloseButton.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(BackColor, 0.01f);
            CloseButton.FlatAppearance.MouseOverBackColor = ControlPaint.LightLight(BackColor);
        }
    }
}
