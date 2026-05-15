using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal static class DrawInterface
    {
        public static PrivateFontCollection MyFontCollection = new PrivateFontCollection();
        public static void SetupFont()
        {
            string fontPath;

            fontPath = Path.Combine(Application.StartupPath, "Resources", "RobotoSlab-Regular.ttf");
            MyFontCollection.AddFontFile(fontPath);
            fontPath = Path.Combine(Application.StartupPath, "Resources", "SpriteGraffiti-Regular.ttf");
            MyFontCollection.AddFontFile(fontPath);
            fontPath = Path.Combine(Application.StartupPath, "Resources", "SpriteGraffiti-Shadow.ttf");
            MyFontCollection.AddFontFile(fontPath);
        }

        public static void LoadFont(Control control, int style = 0)
        {
            control.Font = new Font(
                MyFontCollection.Families[0],
                control.Font.SizeInPoints,
                control.Font.Style
            );
        }

        static int fade_delay = 5;

        public static async void CloseWithAnimation(Form form)
        {
            form.Opacity = 1;
            while (form.Opacity > 0)
            {
                form.Opacity -= 0.05;
                await Task.Delay(fade_delay);
            }

            form.Close();
        }

        public static async void HideWithAnimation(Form form)
        {
            form.Opacity = 1;
            while (form.Opacity > 0)
            {
                form.Opacity -= 0.05;
                await Task.Delay(fade_delay);
            }

            form.Hide();
        }

        public static async void OpenWithAnimation(Form form)
        {
            form.Opacity = 0;
            while (form.Opacity < 1)
            {
                form.Opacity += 0.05;
                await Task.Delay(fade_delay);
            }
        }

        public static void DrawBorderLine(Control control, int size = 1)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Pen pen = new Pen(Color.Black, size);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawRectangle(pen, new Rectangle(size / 2, size / 2, control.Width - size / 2 - 1, control.Height - size / 2 - 1));

            control.BackgroundImage = bitmap;
        }

        public static void DrawRectShadow(Control control, Control parent, int x_offset = 4, int y_offset = 4)
        {
            Graphics g = Graphics.FromImage(parent.BackgroundImage);

            using (SolidBrush shadowBrush = new SolidBrush(Color.Black))
            {
                g.FillRectangle(shadowBrush,
                    new Rectangle(x_offset + control.Left, y_offset + control.Top, control.Width, control.Height));
            }
        }

        public static Bitmap CropToCircle(Image image, int size)
        {
            Bitmap result = new Bitmap(size, size, PixelFormat.Format64bppArgb);

            using (Graphics g = Graphics.FromImage(result))
            {
                // Максимальное сглаживание
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.Clear(Color.Transparent);

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, size - 1, size - 1);

                    using (TextureBrush brush = new TextureBrush(image))
                    {
                        // Масштабирование изображения
                        float scale = Math.Max(
                            (float)size / image.Width,
                            (float)size / image.Height
                        );

                        float x = (size - image.Width * scale) / 2f;
                        float y = (size - image.Height * scale) / 2f;

                        brush.Transform = new Matrix(
                            scale, 0,
                            0, scale,
                            x, y
                        );

                        g.FillPath(brush, path);
                    }
                }
            }

            return result;
        }



        public static Bitmap ConvertDithering(Image image)
        {
            Bitmap result = new Bitmap(image);
            result.ConvertFormat(PixelFormat.Format8bppIndexed, DitherType.Ordered8x8, PaletteType.FixedHalftone125);
            return result;
        }
    }
}
