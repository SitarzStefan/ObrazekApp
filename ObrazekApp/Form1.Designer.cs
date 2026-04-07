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
            radio90 = new RadioButton();
            radio180 = new RadioButton();
            radio270 = new RadioButton();
            buttonRotate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(12, 333);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 29);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Location = new Point(112, 12);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(259, 350);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 1;
            pictureBoxImage.TabStop = false;
            // 
            // radio90
            // 
            radio90.AutoSize = true;
            radio90.Location = new Point(12, 12);
            radio90.Name = "radio90";
            radio90.Size = new Size(46, 24);
            radio90.TabIndex = 2;
            radio90.TabStop = true;
            radio90.Text = "90";
            radio90.UseVisualStyleBackColor = true;
            // 
            // radio180
            // 
            radio180.AutoSize = true;
            radio180.Location = new Point(12, 42);
            radio180.Name = "radio180";
            radio180.Size = new Size(54, 24);
            radio180.TabIndex = 3;
            radio180.TabStop = true;
            radio180.Text = "180";
            radio180.UseVisualStyleBackColor = true;
            // 
            // radio270
            // 
            radio270.AutoSize = true;
            radio270.Location = new Point(12, 73);
            radio270.Name = "radio270";
            radio270.Size = new Size(54, 24);
            radio270.TabIndex = 4;
            radio270.TabStop = true;
            radio270.Text = "270";
            radio270.UseVisualStyleBackColor = true;
            // 
            // buttonRotate
            // 
            buttonRotate.Location = new Point(12, 102);
            buttonRotate.Name = "buttonRotate";
            buttonRotate.Size = new Size(94, 29);
            buttonRotate.TabIndex = 5;
            buttonRotate.Text = "Rotate";
            buttonRotate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 374);
            Controls.Add(buttonRotate);
            Controls.Add(radio270);
            Controls.Add(radio180);
            Controls.Add(radio90);
            Controls.Add(pictureBoxImage);
            Controls.Add(buttonLoad);
            Name = "Form1";
            Text = "Image App";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private RadioButton radio90;
        private RadioButton radio180;
        private RadioButton radio270;
        private Button buttonRotate;
    }
}