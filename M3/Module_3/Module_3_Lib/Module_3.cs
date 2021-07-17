using System;

namespace Module_3_Lib
{
    public class Module_3
    {
        public static double FindNthRoot(double number, int degree, double accuracy)
        {
            if (degree <= 0 || accuracy <= 0)
            {
                throw new ArgumentException();
            }

            if (number < 0 && degree % 2 == 0)
            {
                throw new ArgumentException();
            }

            double init = number / degree;
            double prev = init, next = Math.Pow(degree, -1) * ((degree - 1) * prev + number / Math.Pow(prev, (degree - 1)));

            while (Math.Abs(next - prev) > accuracy)
            {
                prev = next;
                next = Math.Pow(degree, -1) * ((degree - 1) * prev + number / Math.Pow(prev, (degree - 1)));
            }

            return (double)System.Math.Round(next, 3);
        }
    }


    public class MyMatrix
    {
        public int[,] Matrix { get; set; }

        private int RowNumber { get; }
        private int ColNumber { get; }

        public MyMatrix(int rowNum, int colNum)
        {
            RowNumber = rowNum;
            ColNumber = colNum;

            Matrix = new int[RowNumber, ColNumber];
        }

        public void MatrixSortByCondition(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {

                        for (int k = 0; k < Matrix.GetLength(1); k++)
                        {
                            int temp = Matrix[i, k];
                            Matrix[i, k] = Matrix[j, k];
                            Matrix[j, k] = temp;
                        }

                        int tempArr = array[i];
                        array[i] = array[j];
                        array[j] = tempArr;
                    }
                }
            }
        }

        public int[] ArrayOfMinOrMaxElement(bool maxima = true)
        {
            int[] array = new int[Matrix.GetLength(0)];
            int element;
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                element = Matrix[row, 0];
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (maxima)
                    {
                        element = (Matrix[row, col] > element) ? Matrix[row, col] : element;
                    }
                    else
                    {
                        element = (Matrix[row, col] < element) ? Matrix[row, col] : element;
                    }
                }

                array[row] = element;
            }

            return array;
        }

        public int[] ArrayOfRowSum()
        {
            int[] sumArray = new int[Matrix.GetLength(0)];
            int sum = 0;
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    sum += Matrix[row, col];
                }

                sumArray[row] = sum;
                sum = 0;
            }

            return sumArray;
        }

        public void MatrixFill(int numRange = 2)
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

        public void MatrixPrint()
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
}