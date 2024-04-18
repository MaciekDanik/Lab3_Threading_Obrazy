using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Threading_Obrazy
{
    internal class Matrix
    {
        private int rows; //number of rows
        private int cols; //number of cols
        private int[,] matrix_values;

        public Matrix(int n, int m, int limit)
        {
            rows = n;
            cols = m;
            matrix_values = new int[rows, cols];

            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int tmp = rnd.Next(limit+1);
                    matrix_values[i,j] = tmp;
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < cols; j++) 
                {
                    result += matrix_values[i,j] +" ";
                }
                result+= Environment.NewLine;
            }
            return result;
        }
    }
}
