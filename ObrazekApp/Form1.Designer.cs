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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.radio90 = new System.Windows.Forms.RadioButton();
            this.radio180 = new System.Windows.Forms.RadioButton();
            this.radio270 = new System.Windows.Forms.RadioButton();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.buttonFlip = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();

            // buttonLoad
            this.buttonLoad.Location = new System.Drawing.Point(12, 333);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 29);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;

            // pictureBoxImage
            this.pictureBoxImage.Location = new System.Drawing.Point(112, 12);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(259, 350);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;

            // radio90
            this.radio90.AutoSize = true;
            this.radio90.Location = new System.Drawing.Point(12, 12);
            this.radio90.Name = "radio90";
            this.radio90.Size = new System.Drawing.Size(46, 24);
            this.radio90.TabIndex = 2;
            this.radio90.TabStop = true;
            this.radio90.Text = "90";
            this.radio90.UseVisualStyleBackColor = true;

            // radio180
            this.radio180.AutoSize = true;
            this.radio180.Location = new System.Drawing.Point(12, 42);
            this.radio180.Name = "radio180";
            this.radio180.Size = new System.Drawing.Size(54, 24);
            this.radio180.TabIndex = 3;
            this.radio180.TabStop = true;
            this.radio180.Text = "180";
            this.radio180.UseVisualStyleBackColor = true;

            // radio270
            this.radio270.AutoSize = true;
            this.radio270.Location = new System.Drawing.Point(12, 73);
            this.radio270.Name = "radio270";
            this.radio270.Size = new System.Drawing.Size(54, 24);
            this.radio270.TabIndex = 4;
            this.radio270.TabStop = true;
            this.radio270.Text = "270";
            this.radio270.UseVisualStyleBackColor = true;

            // buttonRotate
            this.buttonRotate.Location = new System.Drawing.Point(12, 102);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(94, 29);
            this.buttonRotate.TabIndex = 5;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;

            // buttonInvert
            this.buttonInvert.Location = new System.Drawing.Point(12, 137);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(94, 48);
            this.buttonInvert.TabIndex = 6;
            this.buttonInvert.Text = "Invert Colors";
            this.buttonInvert.UseVisualStyleBackColor = true;

            // buttonFlip
            this.buttonFlip.Location = new System.Drawing.Point(12, 191);
            this.buttonFlip.Name = "buttonFlip";
            this.buttonFlip.Size = new System.Drawing.Size(94, 49);
            this.buttonFlip.TabIndex = 7;
            this.buttonFlip.Text = "Upside Down";
            this.buttonFlip.UseVisualStyleBackColor = true;

            // buttonGreen
            this.buttonGreen.Location = new System.Drawing.Point(12, 246);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(94, 29);
            this.buttonGreen.TabIndex = 8;
            this.buttonGreen.Text = "Green";
            this.buttonGreen.UseVisualStyleBackColor = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(401, 374);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonFlip);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.radio270);
            this.Controls.Add(this.radio180);
            this.Controls.Add(this.radio90);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonLoad);

            this.Name = "Form1";
            this.Text = "Image App";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.RadioButton radio90;
        private System.Windows.Forms.RadioButton radio180;
        private System.Windows.Forms.RadioButton radio270;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Button buttonFlip;
        private System.Windows.Forms.Button buttonGreen;
    }
}