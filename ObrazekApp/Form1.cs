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
            buttonGreen.Click += buttonGreen_Click;
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

        private void buttonGreen_Click(object? sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap result = new Bitmap(currentImage);

            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    Color px = result.GetPixel(x, y);

                    result.SetPixel(x, y, Color.FromArgb(
                        px.A,
                        0,
                        px.G,
                        0
                    ));
                }
            }

            currentImage = result;
            pictureBoxImage.Image = currentImage;
        }
    }
}