using System;
using System.Collections;
using System.Collections.Generic;

namespace Module_3
{
    class MyMatrix
    {
        public int[,] Matrix { get; set; }

        public int RowNumber { get; }
        public int ColNumber { get; }
        public ISortable Sortable { private get; set; }

        public MyMatrix(int rowNum, int colNum, ISortable sort)
        {
            RowNumber = rowNum;
            ColNumber = colNum;

            Matrix = new int[RowNumber, ColNumber];
            Sortable = sort;
        }

        public void Sort(int orderBy)
        {
            Sortable.MatrixSort(Matrix, new Comparison(), orderBy);
        }

        public void Fill(int numRange = 2)
        {
            Random generator = new Random();
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Matrix[row, col] = generator.Next(0, numRange);
                }
            }
        }

        public void Print()
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    string numOutput = Matrix[row, col].ToString().Length == 1 ? " " + Matrix[row, col] : Matrix[row, col].ToString();
                    Console.Write(numOutput + " ");
                }
                Console.WriteLine();
            }
        }
    }

    public class Comparison : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }        
    }
}
