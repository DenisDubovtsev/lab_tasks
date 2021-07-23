using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3
{
    /// <summary>
    /// In ascending order of the maximum elements of the matrix rows
    /// </summary>
    class StrategyOne : ISortable
    {
        public void MatrixSort(int[,] mtrx, Comparison comparer, int orderBy)
        {
            int[] array = new int[mtrx.GetLength(0)];
            int max;
            for (int row = 0; row < mtrx.GetLength(0); row++)
            {
                max = mtrx[row, 0];
                for (int col = 0; col < mtrx.GetLength(1); col++)
                {
                    max = (mtrx[row, col] > max) ? mtrx[row, col] : max;
                }

                array[row] = max;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) == orderBy)
                    {

                        for (int k = 0; k < mtrx.GetLength(1); k++)
                        {
                            int temp = mtrx[i, k];
                            mtrx[i, k] = mtrx[j, k];
                            mtrx[j, k] = temp;
                        }

                        int tempArr = array[i];
                        array[i] = array[j];
                        array[j] = tempArr;
                    }
                }
            }
        }
    }
}


