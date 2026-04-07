using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObrazekApp
{
    public partial class Form1 : Form
    {
        private Bitmap? currentImage;

        public Form1()
        {
            InitializeComponent();

            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            buttonLoad.Click += buttonLoad_Click;
        }

        private void buttonLoad_Click(object? sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BMP files (*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentImage = new Bitmap(ofd.FileName);
                pictureBoxImage.Image = currentImage;
            }
        }
    }
}