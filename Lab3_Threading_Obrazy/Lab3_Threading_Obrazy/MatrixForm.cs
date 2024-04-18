using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Threading_Obrazy
{
    public partial class MatrixForm : Form
    {
        private Matrix matrixA;
        private Matrix matrixB;
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void num_MatrixB_cols_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_saveEnteredMatrix_Click(object sender, EventArgs e)
        {
            int rows_A = int.Parse(num_matrixA_rows.Value.ToString());
            int cols_A = int.Parse(num_MatrixA_cols.Value.ToString());
            int rows_B = int.Parse(num_MatrixB_rows.Value.ToString());
            int cols_B = int.Parse(num_MatrixB_cols.Value.ToString());
            int limit = int.Parse(num_MatrixMaxValue.Value.ToString());

            if (cols_A != rows_B)
            {
                txtBox_logScreen.Clear();
                txtBox_logScreen.Text = "Zły wymiar macierzy" + Environment.NewLine + "Kolumny A != Rzędy B";
            }
            else
            {
                matrixA = new Matrix(rows_A, cols_A, limit);
                matrixB = new Matrix(rows_B, cols_B, limit);

                string matrixes = matrixA.ToString();
                matrixes += Environment.NewLine + matrixB.ToString();
                txtBox_logScreen.Text = matrixes;
            }
        }

        private void btn_rndMatrix_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int limit = int.Parse(num_MatrixMaxValue.Value.ToString()) +1;
            int rows_A = rnd.Next(limit);
            int cols_A = rnd.Next(limit);
            int rows_B = cols_A;
            int cols_B = rnd.Next(limit);

            matrixA = new Matrix(rows_A, cols_A, limit);
            matrixB = new Matrix(rows_B, cols_B, limit);

            num_MatrixA_cols.Value = cols_A;
            num_matrixA_rows.Value = rows_A;
            num_MatrixB_cols.Value = cols_B;
            num_MatrixB_rows.Value = rows_B;

            string matrixes = matrixA.ToString();
            matrixes += Environment.NewLine + matrixB.ToString();
            txtBox_logScreen.Text = matrixes;
        }
    }
}
