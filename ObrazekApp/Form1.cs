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
            buttonRotate.Click += buttonRotate_Click;
            buttonInvert.Click += buttonInvert_Click;
            buttonFlip.Click += buttonFlip_Click;
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

        private void buttonRotate_Click(object? sender, EventArgs e)
        {
            if (currentImage == null) return;

            float angle = 0;

            if (radio90.Checked)
                angle = 90;
            else if (radio180.Checked)
                angle = 180;
            else if (radio270.Checked)
                angle = 270;
            else
                return;

            Bitmap rotated = new Bitmap(currentImage.Width, currentImage.Height);

            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.TranslateTransform(currentImage.Width / 2f, currentImage.Height / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-currentImage.Width / 2f, -currentImage.Height / 2f);
                g.DrawImage(currentImage, new Point(0, 0));
            }

            currentImage = rotated;
            pictureBoxImage.Image = currentImage;
        }

        
        private void buttonInvert_Click(object? sender, EventArgs e)
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
                        255 - px.R,
                        255 - px.G,
                        255 - px.B
                    ));
                }
            }

            currentImage = result;
            pictureBoxImage.Image = currentImage;
        }

     
        private void buttonFlip_Click(object? sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap result = new Bitmap(currentImage.Width, currentImage.Height);

            for (int y = 0; y < currentImage.Height; y++)
            {
                for (int x = 0; x < currentImage.Width; x++)
                {
                    Color px = currentImage.GetPixel(x, y);

                    result.SetPixel(x, currentImage.Height - 1 - y, px);
                }
            }

            currentImage = result;
            pictureBoxImage.Image = currentImage;
        }
    }
}