namespace Lab3_Threading_Obrazy
{
    partial class Form_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Matrix = new Button();
            btn_imgProcessing = new Button();
            SuspendLayout();
            // 
            // btn_Matrix
            // 
            btn_Matrix.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_Matrix.Location = new Point(124, 107);
            btn_Matrix.Name = "btn_Matrix";
            btn_Matrix.Size = new Size(139, 66);
            btn_Matrix.TabIndex = 0;
            btn_Matrix.Text = "Macierze";
            btn_Matrix.UseVisualStyleBackColor = true;
            btn_Matrix.Click += btn_Matrix_Click;
            // 
            // btn_imgProcessing
            // 
            btn_imgProcessing.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_imgProcessing.Location = new Point(337, 107);
            btn_imgProcessing.Name = "btn_imgProcessing";
            btn_imgProcessing.Size = new Size(139, 66);
            btn_imgProcessing.TabIndex = 1;
            btn_imgProcessing.Text = "Obrazy";
            btn_imgProcessing.UseVisualStyleBackColor = true;
            btn_imgProcessing.Click += btn_imgProcessing_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 317);
            Controls.Add(btn_imgProcessing);
            Controls.Add(btn_Matrix);
            Name = "Form_Menu";
            Text = "Menu";
            Load += Form_Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Matrix;
        private Button btn_imgProcessing;
    }
}
