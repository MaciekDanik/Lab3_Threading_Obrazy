namespace Lab3_Threading_Obrazy
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBox_OGpic = new PictureBox();
            btn_LoadImage = new Button();
            picBox_Negatyw = new PictureBox();
            picBox_Gray = new PictureBox();
            picBox_Progowanie = new PictureBox();
            picBox_green = new PictureBox();
            btn_ImageOperations = new Button();
            ((System.ComponentModel.ISupportInitialize)picBox_OGpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Negatyw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Gray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Progowanie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox_green).BeginInit();
            SuspendLayout();
            // 
            // picBox_OGpic
            // 
            picBox_OGpic.Location = new Point(25, 63);
            picBox_OGpic.Name = "picBox_OGpic";
            picBox_OGpic.Size = new Size(306, 332);
            picBox_OGpic.TabIndex = 0;
            picBox_OGpic.TabStop = false;
            // 
            // btn_LoadImage
            // 
            btn_LoadImage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_LoadImage.Location = new Point(96, 425);
            btn_LoadImage.Name = "btn_LoadImage";
            btn_LoadImage.Size = new Size(120, 55);
            btn_LoadImage.TabIndex = 1;
            btn_LoadImage.Text = "Wgraj obraz";
            btn_LoadImage.UseVisualStyleBackColor = true;
            btn_LoadImage.Click += btn_LoadImage_Click;
            // 
            // picBox_Negatyw
            // 
            picBox_Negatyw.Location = new Point(464, 35);
            picBox_Negatyw.Name = "picBox_Negatyw";
            picBox_Negatyw.Size = new Size(192, 192);
            picBox_Negatyw.TabIndex = 2;
            picBox_Negatyw.TabStop = false;
            // 
            // picBox_Gray
            // 
            picBox_Gray.Location = new Point(693, 35);
            picBox_Gray.Name = "picBox_Gray";
            picBox_Gray.Size = new Size(192, 192);
            picBox_Gray.TabIndex = 3;
            picBox_Gray.TabStop = false;
            // 
            // picBox_Progowanie
            // 
            picBox_Progowanie.Location = new Point(464, 260);
            picBox_Progowanie.Name = "picBox_Progowanie";
            picBox_Progowanie.Size = new Size(192, 192);
            picBox_Progowanie.TabIndex = 4;
            picBox_Progowanie.TabStop = false;
            // 
            // picBox_green
            // 
            picBox_green.Location = new Point(693, 260);
            picBox_green.Name = "picBox_green";
            picBox_green.Size = new Size(192, 192);
            picBox_green.TabIndex = 5;
            picBox_green.TabStop = false;
            // 
            // btn_ImageOperations
            // 
            btn_ImageOperations.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_ImageOperations.Location = new Point(608, 469);
            btn_ImageOperations.Name = "btn_ImageOperations";
            btn_ImageOperations.Size = new Size(120, 55);
            btn_ImageOperations.TabIndex = 6;
            btn_ImageOperations.Text = "Procesuj";
            btn_ImageOperations.UseVisualStyleBackColor = true;
            btn_ImageOperations.Click += btn_ImageOperations_Click;
            // 
            // ImageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 536);
            Controls.Add(btn_ImageOperations);
            Controls.Add(picBox_green);
            Controls.Add(picBox_Progowanie);
            Controls.Add(picBox_Gray);
            Controls.Add(picBox_Negatyw);
            Controls.Add(btn_LoadImage);
            Controls.Add(picBox_OGpic);
            Name = "ImageForm";
            Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)picBox_OGpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Negatyw).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Gray).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_Progowanie).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox_green).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBox_OGpic;
        private Button btn_LoadImage;
        private PictureBox picBox_Negatyw;
        private PictureBox picBox_Gray;
        private PictureBox picBox_Progowanie;
        private PictureBox picBox_green;
        private Button btn_ImageOperations;
    }
}