using System;
using Module_3_Lib;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {            
            MyMatrix mtrx = new MyMatrix(5, 5);
            int number = 30;
            mtrx.MatrixFill(number); // filling randomly from 0 to number

            Console.WriteLine("\nThe original matrix: ");
            mtrx.MatrixPrint();

            Console.WriteLine("\n1. In ascending order of the sums of the elements of the rows of the matrix:");
            int[] arrayWithSum = mtrx.ArrayOfRowSum();            
            mtrx.MatrixSortByCondition(arrayWithSum);
            mtrx.MatrixPrint();

            Console.WriteLine("\n2. In ascending order of the maximum elements of the rows of the matrix:");
            int[] arrayWithMax = mtrx.ArrayOfMinOrMaxElement();
            mtrx.MatrixSortByCondition(arrayWithMax);
            mtrx.MatrixPrint();

            Console.WriteLine("\n3. In ascending order of the minimum elements of the matrix rows:");
            int[] arrayWithMin = mtrx.ArrayOfMinOrMaxElement(false);          
            mtrx.MatrixSortByCondition(arrayWithMin);
            mtrx.MatrixPrint();             
        }        
    }
}
