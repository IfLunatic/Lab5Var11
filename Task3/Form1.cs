using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private ImageList imageList = new ImageList();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog(); // Додано OpenFileDialog

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Установка imageList як ImageList для вікна вибору файлів
            openFileDialog1.Multiselect = true; // Дозволяє вибір кількох файлів
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    string fileName = Path.GetFileName(file);
                    listBox.Items.Add(fileName);
                    imageList.Images.Add(Image.FromFile(file));
                }
                listBox.Refresh();
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                pictureBox.Image = imageList.Images[listBox.SelectedIndex];
            }
        }
    }
}
