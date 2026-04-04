using System.Runtime.InteropServices;

// Здесь лежат кастомные функции

namespace MyFunctions
{
    public static class TextBoxExtensions
    {
        private const int EM_SETRECT = 0xB3;

        [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public readonly int Left;
            public readonly int Top;
            public readonly int Right;
            public readonly int Bottom;

            private RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom) {}
        }

        public static void SetPadding(this TextBox textBox, Padding padding)
        {
            var rect = new Rectangle(padding.Left, padding.Top, textBox.ClientSize.Width - padding.Left - padding.Right, textBox.ClientSize.Height - padding.Top - padding.Bottom);
            RECT rc = new RECT(rect);

            SendMessageRefRect(textBox.Handle, EM_SETRECT, 0, ref rc);
            textBox.SetPlaceholder();
        }

        public static void SetPlaceholder(this TextBox tb)
        {
            Color foreColor = tb.ForeColor;
            Color placeHolderColor = Color.Gray;

            void Set()
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tb.Text = tb.PlaceholderText;
                    tb.ForeColor = placeHolderColor;
                    tb.Tag = "placeholder";
                }
            }

            void Remove()
            {
                if ((string)tb.Tag == "placeholder")
                {
                    tb.Text = "";
                    tb.ForeColor = foreColor;
                    tb.Tag = null;
                }
            }

            tb.Enter += (s, e) => Remove();
            tb.Leave += (s, e) => Set();

            Set();
        }

        public static void AddGlobalKeyPress(this Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox tb)
                    tb.KeyPress += TextBox_KeyPress;

                if (control.HasChildren)
                    control.AddGlobalKeyPress();
            }
        }

        static void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
        }
    }
}
