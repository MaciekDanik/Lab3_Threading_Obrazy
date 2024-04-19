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
        private volatile int[,] matrix_values;

        public Matrix(int n, int m)
        {
            rows = n;
            cols = m;
            matrix_values = new int[rows, cols];
        }

        public int[,] getValue()
        {
            return matrix_values;
        }

        public void setValue(int[,] value) 
        {
            matrix_values = value;
        }

        public void fillMatrix(int limit)
        {
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int tmp = rnd.Next(limit + 1);
                    matrix_values[i, j] = tmp;
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
