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
        private Matrix resultMatrix;
        int size;
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
                matrixA = new Matrix(rows_A, cols_A);
                matrixB = new Matrix(rows_B, cols_B);
                resultMatrix = new Matrix(rows_A, cols_B);
                int seed = int.Parse(num_Seed.Value.ToString());

                matrixA.fillMatrix(limit, seed);
                matrixB.fillMatrix(limit, seed);

                //string matrixes = matrixA.ToString();
                //matrixes += Environment.NewLine + matrixB.ToString();
                txtBox_logScreen.Text = "Wygenerowano Macierze.";

                btn_MultiplyThread.Visible = true;
                btn_multiplyParalell.Visible = true;
            }
        }

        private static void Multiply(int i, int resCols, int Arows, int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
        {
            for (int j = 0; j < resCols; ++j) //koluny wynikowej
            {
                for (int k = 0; k < Arows; ++k) //liczba wierszy A
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            int[,] matA = matrixA.getValue();
            int[,] matB = matrixB.getValue();
            int[,] matRes = resultMatrix.getValue();
            int resRows = int.Parse(num_matrixA_rows.Value.ToString());
            int resCols = int.Parse(num_MatrixB_cols.Value.ToString());
            int Arows = resRows;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < resRows; ++i) //wiersze wynik i =start size = end
            {
                Multiply(i, resCols, Arows, matA, matB, matRes);
            }
            watch.Stop();

            txtBox_logScreen.Clear();
            //txtBox_logScreen.Text = resultMatrix.ToString();
            txtBox_logScreen.Text = "Policzono poprawnie";
            txtBox_time.Text = watch.ElapsedMilliseconds.ToString();
            watch.Reset();
        }

        private void btn_multiplyParalell_Click(object sender, EventArgs e)
        {
            int[,] matA = matrixA.getValue();
            int[,] matB = matrixB.getValue();
            int[,] matRes = resultMatrix.getValue();
            int resRows = int.Parse(num_matrixA_rows.Value.ToString());
            int resCols = int.Parse(num_MatrixB_cols.Value.ToString());
            int Arows = resRows;

            int thread_count = int.Parse(num_threadCount.Value.ToString());

            ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = thread_count};

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Parallel.For(0, resRows, opt, x =>
            {
                Multiply(x, resCols, Arows, matA, matB, matRes);
            });
            watch.Stop();

            txtBox_logScreen.Clear();
            //txtBox_logScreen.Text = resultMatrix.ToString();
            txtBox_logScreen.Text = "Policzono poprawnie";
            txtBox_time.Text = watch.ElapsedMilliseconds.ToString();
            watch.Reset();
        }
    }
}
