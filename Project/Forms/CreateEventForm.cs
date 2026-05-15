using Project.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class CreateEventForm : Form
    {
        private string _sourceFilePath = ""; // Путь к исходному файлу на диске
        private readonly EventService _eventService = new EventService();
        public CreateEventForm()
        {
            InitializeComponent();
        }
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _sourceFilePath = ofd.FileName;

                    if (picPreview.Image != null) picPreview.Image.Dispose();
                    picPreview.Image = Image.FromFile(_sourceFilePath);
                }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            _sourceFilePath = "";
            if (picPreview.Image != null)
            {
                picPreview.Image.Dispose();
                picPreview.Image = null;
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля без try-catch
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Заполните заголовок и описание!");
                return;
            }

            string finalImagePath = "";

            if (_sourceFilePath != "")
            {
                string uploadsFolder = Path.Combine(Application.StartupPath, "uploads");
                if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);

                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(_sourceFilePath);
                finalImagePath = Path.Combine("uploads", fileName);

                File.Copy(_sourceFilePath, Path.Combine(Application.StartupPath, finalImagePath));
            }

            _eventService.CreateEvent(
                txtTitle.Text,
                txtDescription.Text,
                Program.User.Name,
                Program.User.University,
                finalImagePath
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
