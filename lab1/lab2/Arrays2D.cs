using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab2
{
    internal class Arrays2D
    {
        private readonly int[,] matrix;
        private int[] aValues;

        public int Rows { get; } = 3;
        public int Cols { get; } = 3;

        public int[] A => (int[])aValues.Clone();

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= Rows || j < 0 || j >= Cols)
                    throw new IndexOutOfRangeException("Індекс поза межами матриці");
                return matrix[i, j];
            }
        }

        public Arrays2D()
        {
            matrix = new int[Rows, Cols];
            aValues = new int[] { 1, 2, 3 };
            GenerateMatrix();
        }

        public Arrays2D(int a1, int a2, int a3)
        {
            matrix = new int[Rows, Cols];
            aValues = new int[] { a1, a2, a3 };
            GenerateMatrix();
        }

        private void GenerateMatrix()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    matrix[i, j] = (int)(Math.Pow(aValues[i], i + 1) - 3 * Math.Pow(aValues[j], j + 1));
        }

        public void SetA(int index, int value)
        {
            if (index < 0 || index >= 3)
                throw new IndexOutOfRangeException("Індекс повинен бути 0..2");
            aValues[index] = value;
            GenerateMatrix();
        }

        public string ToMatrixString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                    sb.Append(matrix[i, j].ToString().PadLeft(8));
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public override string ToString() => ToMatrixString();
    }
}
