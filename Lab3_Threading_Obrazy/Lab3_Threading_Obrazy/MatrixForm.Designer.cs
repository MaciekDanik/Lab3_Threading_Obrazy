namespace Lab3_Threading_Obrazy
{
    partial class MatrixForm
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
            num_matrixA_rows = new NumericUpDown();
            lbl_MatrixA_rows = new Label();
            lbl_MatrixA = new Label();
            lbl_MatrixA_cols = new Label();
            num_MatrixA_cols = new NumericUpDown();
            num_MatrixB_cols = new NumericUpDown();
            lbl_MatrixB_cols = new Label();
            lbl_MatrixB = new Label();
            lbl_MatrixB_rows = new Label();
            num_MatrixB_rows = new NumericUpDown();
            num_MatrixMaxValue = new NumericUpDown();
            lbl_MatrixMaxValue = new Label();
            btn_saveEnteredMatrix = new Button();
            txtBox_logScreen = new TextBox();
            btn_MultiplyThread = new Button();
            btn_multiplyParalell = new Button();
            num_Seed = new NumericUpDown();
            lbl_seed = new Label();
            num_threadCount = new NumericUpDown();
            lbl_threadCount = new Label();
            txtBox_time = new TextBox();
            lbl_time = new Label();
            ((System.ComponentModel.ISupportInitialize)num_matrixA_rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixA_cols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixB_cols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixB_rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixMaxValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Seed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_threadCount).BeginInit();
            SuspendLayout();
            // 
            // num_matrixA_rows
            // 
            num_matrixA_rows.Location = new Point(90, 54);
            num_matrixA_rows.Margin = new Padding(3, 2, 3, 2);
            num_matrixA_rows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_matrixA_rows.Name = "num_matrixA_rows";
            num_matrixA_rows.Size = new Size(50, 23);
            num_matrixA_rows.TabIndex = 0;
            num_matrixA_rows.ThousandsSeparator = true;
            num_matrixA_rows.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lbl_MatrixA_rows
            // 
            lbl_MatrixA_rows.AutoSize = true;
            lbl_MatrixA_rows.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_MatrixA_rows.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixA_rows.Location = new Point(10, 52);
            lbl_MatrixA_rows.Name = "lbl_MatrixA_rows";
            lbl_MatrixA_rows.Size = new Size(61, 20);
            lbl_MatrixA_rows.TabIndex = 1;
            lbl_MatrixA_rows.Text = "wiersze:";
            // 
            // lbl_MatrixA
            // 
            lbl_MatrixA.AutoSize = true;
            lbl_MatrixA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_MatrixA.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixA.Location = new Point(40, 24);
            lbl_MatrixA.Name = "lbl_MatrixA";
            lbl_MatrixA.Size = new Size(82, 21);
            lbl_MatrixA.TabIndex = 2;
            lbl_MatrixA.Text = "Macierz A";
            // 
            // lbl_MatrixA_cols
            // 
            lbl_MatrixA_cols.AutoSize = true;
            lbl_MatrixA_cols.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_MatrixA_cols.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixA_cols.Location = new Point(10, 82);
            lbl_MatrixA_cols.Name = "lbl_MatrixA_cols";
            lbl_MatrixA_cols.Size = new Size(68, 20);
            lbl_MatrixA_cols.TabIndex = 3;
            lbl_MatrixA_cols.Text = "kolumny:";
            // 
            // num_MatrixA_cols
            // 
            num_MatrixA_cols.Location = new Point(90, 84);
            num_MatrixA_cols.Margin = new Padding(3, 2, 3, 2);
            num_MatrixA_cols.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_MatrixA_cols.Name = "num_MatrixA_cols";
            num_MatrixA_cols.Size = new Size(50, 23);
            num_MatrixA_cols.TabIndex = 4;
            num_MatrixA_cols.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // num_MatrixB_cols
            // 
            num_MatrixB_cols.Location = new Point(259, 84);
            num_MatrixB_cols.Margin = new Padding(3, 2, 3, 2);
            num_MatrixB_cols.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_MatrixB_cols.Name = "num_MatrixB_cols";
            num_MatrixB_cols.Size = new Size(50, 23);
            num_MatrixB_cols.TabIndex = 9;
            num_MatrixB_cols.Value = new decimal(new int[] { 100, 0, 0, 0 });
            num_MatrixB_cols.ValueChanged += num_MatrixB_cols_ValueChanged;
            // 
            // lbl_MatrixB_cols
            // 
            lbl_MatrixB_cols.AutoSize = true;
            lbl_MatrixB_cols.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_MatrixB_cols.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixB_cols.Location = new Point(179, 82);
            lbl_MatrixB_cols.Name = "lbl_MatrixB_cols";
            lbl_MatrixB_cols.Size = new Size(68, 20);
            lbl_MatrixB_cols.TabIndex = 8;
            lbl_MatrixB_cols.Text = "kolumny:";
            // 
            // lbl_MatrixB
            // 
            lbl_MatrixB.AutoSize = true;
            lbl_MatrixB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_MatrixB.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixB.Location = new Point(209, 24);
            lbl_MatrixB.Name = "lbl_MatrixB";
            lbl_MatrixB.Size = new Size(81, 21);
            lbl_MatrixB.TabIndex = 7;
            lbl_MatrixB.Text = "Macierz B";
            // 
            // lbl_MatrixB_rows
            // 
            lbl_MatrixB_rows.AutoSize = true;
            lbl_MatrixB_rows.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_MatrixB_rows.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixB_rows.Location = new Point(179, 52);
            lbl_MatrixB_rows.Name = "lbl_MatrixB_rows";
            lbl_MatrixB_rows.Size = new Size(61, 20);
            lbl_MatrixB_rows.TabIndex = 6;
            lbl_MatrixB_rows.Text = "wiersze:";
            // 
            // num_MatrixB_rows
            // 
            num_MatrixB_rows.Location = new Point(259, 54);
            num_MatrixB_rows.Margin = new Padding(3, 2, 3, 2);
            num_MatrixB_rows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_MatrixB_rows.Name = "num_MatrixB_rows";
            num_MatrixB_rows.Size = new Size(50, 23);
            num_MatrixB_rows.TabIndex = 5;
            num_MatrixB_rows.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // num_MatrixMaxValue
            // 
            num_MatrixMaxValue.Location = new Point(174, 130);
            num_MatrixMaxValue.Margin = new Padding(3, 2, 3, 2);
            num_MatrixMaxValue.Name = "num_MatrixMaxValue";
            num_MatrixMaxValue.Size = new Size(80, 23);
            num_MatrixMaxValue.TabIndex = 11;
            num_MatrixMaxValue.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lbl_MatrixMaxValue
            // 
            lbl_MatrixMaxValue.AutoSize = true;
            lbl_MatrixMaxValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_MatrixMaxValue.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_MatrixMaxValue.Location = new Point(10, 129);
            lbl_MatrixMaxValue.Name = "lbl_MatrixMaxValue";
            lbl_MatrixMaxValue.Size = new Size(149, 20);
            lbl_MatrixMaxValue.TabIndex = 10;
            lbl_MatrixMaxValue.Text = "maksymalna wartość:";
            // 
            // btn_saveEnteredMatrix
            // 
            btn_saveEnteredMatrix.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_saveEnteredMatrix.Location = new Point(10, 257);
            btn_saveEnteredMatrix.Margin = new Padding(3, 2, 3, 2);
            btn_saveEnteredMatrix.Name = "btn_saveEnteredMatrix";
            btn_saveEnteredMatrix.Size = new Size(112, 57);
            btn_saveEnteredMatrix.TabIndex = 12;
            btn_saveEnteredMatrix.Text = "Wygeneruj macierze";
            btn_saveEnteredMatrix.UseVisualStyleBackColor = true;
            btn_saveEnteredMatrix.Click += btn_saveEnteredMatrix_Click;
            // 
            // txtBox_logScreen
            // 
            txtBox_logScreen.Location = new Point(365, 51);
            txtBox_logScreen.Margin = new Padding(3, 2, 3, 2);
            txtBox_logScreen.Multiline = true;
            txtBox_logScreen.Name = "txtBox_logScreen";
            txtBox_logScreen.ReadOnly = true;
            txtBox_logScreen.ScrollBars = ScrollBars.Vertical;
            txtBox_logScreen.Size = new Size(246, 198);
            txtBox_logScreen.TabIndex = 14;
            // 
            // btn_MultiplyThread
            // 
            btn_MultiplyThread.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_MultiplyThread.Location = new Point(365, 266);
            btn_MultiplyThread.Margin = new Padding(3, 2, 3, 2);
            btn_MultiplyThread.Name = "btn_MultiplyThread";
            btn_MultiplyThread.Size = new Size(108, 38);
            btn_MultiplyThread.TabIndex = 15;
            btn_MultiplyThread.Text = "Thread";
            btn_MultiplyThread.UseVisualStyleBackColor = true;
            btn_MultiplyThread.Visible = false;
            btn_MultiplyThread.Click += btn_Multiply_Click;
            // 
            // btn_multiplyParalell
            // 
            btn_multiplyParalell.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_multiplyParalell.Location = new Point(502, 266);
            btn_multiplyParalell.Margin = new Padding(3, 2, 3, 2);
            btn_multiplyParalell.Name = "btn_multiplyParalell";
            btn_multiplyParalell.Size = new Size(108, 38);
            btn_multiplyParalell.TabIndex = 16;
            btn_multiplyParalell.Text = "Paralell";
            btn_multiplyParalell.UseVisualStyleBackColor = true;
            btn_multiplyParalell.Visible = false;
            btn_multiplyParalell.Click += btn_multiplyParalell_Click;
            // 
            // num_Seed
            // 
            num_Seed.Location = new Point(174, 170);
            num_Seed.Margin = new Padding(3, 2, 3, 2);
            num_Seed.Name = "num_Seed";
            num_Seed.Size = new Size(80, 23);
            num_Seed.TabIndex = 18;
            num_Seed.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lbl_seed
            // 
            lbl_seed.AutoSize = true;
            lbl_seed.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_seed.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_seed.Location = new Point(10, 169);
            lbl_seed.Name = "lbl_seed";
            lbl_seed.Size = new Size(138, 20);
            lbl_seed.TabIndex = 17;
            lbl_seed.Text = "Seed do losowania:";
            // 
            // num_threadCount
            // 
            num_threadCount.Location = new Point(174, 208);
            num_threadCount.Margin = new Padding(3, 2, 3, 2);
            num_threadCount.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            num_threadCount.Name = "num_threadCount";
            num_threadCount.Size = new Size(80, 23);
            num_threadCount.TabIndex = 20;
            num_threadCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_threadCount
            // 
            lbl_threadCount.AutoSize = true;
            lbl_threadCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_threadCount.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_threadCount.Location = new Point(10, 207);
            lbl_threadCount.Name = "lbl_threadCount";
            lbl_threadCount.Size = new Size(97, 20);
            lbl_threadCount.TabIndex = 19;
            lbl_threadCount.Text = "Ilość wątków:";
            // 
            // txtBox_time
            // 
            txtBox_time.Location = new Point(203, 281);
            txtBox_time.Name = "txtBox_time";
            txtBox_time.ReadOnly = true;
            txtBox_time.Size = new Size(106, 23);
            txtBox_time.TabIndex = 21;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_time.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lbl_time.Location = new Point(170, 257);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(139, 20);
            lbl_time.TabIndex = 22;
            lbl_time.Text = "Czas działania (ms):";
            // 
            // MatrixForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 338);
            Controls.Add(lbl_time);
            Controls.Add(txtBox_time);
            Controls.Add(num_threadCount);
            Controls.Add(lbl_threadCount);
            Controls.Add(num_Seed);
            Controls.Add(lbl_seed);
            Controls.Add(btn_multiplyParalell);
            Controls.Add(btn_MultiplyThread);
            Controls.Add(txtBox_logScreen);
            Controls.Add(btn_saveEnteredMatrix);
            Controls.Add(num_MatrixMaxValue);
            Controls.Add(lbl_MatrixMaxValue);
            Controls.Add(num_MatrixB_cols);
            Controls.Add(lbl_MatrixB_cols);
            Controls.Add(lbl_MatrixB);
            Controls.Add(lbl_MatrixB_rows);
            Controls.Add(num_MatrixB_rows);
            Controls.Add(num_MatrixA_cols);
            Controls.Add(lbl_MatrixA_cols);
            Controls.Add(lbl_MatrixA);
            Controls.Add(lbl_MatrixA_rows);
            Controls.Add(num_matrixA_rows);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MatrixForm";
            Text = "Mnożenie macierzy";
            ((System.ComponentModel.ISupportInitialize)num_matrixA_rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixA_cols).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixB_cols).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixB_rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_MatrixMaxValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Seed).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_threadCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown num_matrixA_rows;
        private Label lbl_MatrixA_rows;
        private Label lbl_MatrixA;
        private Label lbl_MatrixA_cols;
        private NumericUpDown num_MatrixA_cols;
        private NumericUpDown num_MatrixB_cols;
        private Label lbl_MatrixB_cols;
        private Label lbl_MatrixB;
        private Label lbl_MatrixB_rows;
        private NumericUpDown num_MatrixB_rows;
        private NumericUpDown num_MatrixMaxValue;
        private Label lbl_MatrixMaxValue;
        private Button btn_saveEnteredMatrix;
        private TextBox txtBox_logScreen;
        private Button btn_MultiplyThread;
        private Button btn_multiplyParalell;
        private NumericUpDown num_Seed;
        private Label lbl_seed;
        private NumericUpDown num_threadCount;
        private Label lbl_threadCount;
        private TextBox txtBox_time;
        private Label lbl_time;
    }
}