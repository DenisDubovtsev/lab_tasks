﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module_3
{
    /// <summary>
    /// In ascending order of the minimum elements of the matrix rows
    /// </summary>
    class StrategyTwo : ISortable
    {
        public void MatrixSort(int[,] mtrx)
        {
            int[] array = new int[mtrx.GetLength(0)];
            int min;
            for (int row = 0; row < mtrx.GetLength(0); row++)
            {
                min = mtrx[row, 0];
                for (int col = 0; col < mtrx.GetLength(1); col++)
                {
                    min = (mtrx[row, col] < min) ? mtrx[row, col] : min;
                }

                array[row] = min;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
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
