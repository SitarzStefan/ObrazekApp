namespace ObrazekApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            buttonLoad = new Button();
            pictureBoxImage = new PictureBox();
            buttonGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();

            // buttonLoad
            buttonLoad.Location = new Point(12, 333);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 29);
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;

            // pictureBoxImage
            pictureBoxImage.Location = new Point(112, 12);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(259, 350);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;

            // buttonGreen
            buttonGreen.Location = new Point(12, 298);
            buttonGreen.Name = "buttonGreen";
            buttonGreen.Size = new Size(94, 29);
            buttonGreen.Text = "Only Green";
            buttonGreen.UseVisualStyleBackColor = true;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 374);
            Controls.Add(buttonGreen);
            Controls.Add(pictureBoxImage);
            Controls.Add(buttonLoad);
            Name = "Form1";
            Text = "Image App";

            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoad;
        private PictureBox pictureBoxImage;
        private Button buttonGreen;
    }
}