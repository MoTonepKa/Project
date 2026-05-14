using System.ComponentModel;

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
        public string Title
        {
            get => TitleLabel.Text;
            set => TitleLabel.Text = value;
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
            TitleLabel.Font = new Font(Program.MyFontCollection.Families[1], Font.SizeInPoints, Font.Style);
        }
    }
}
