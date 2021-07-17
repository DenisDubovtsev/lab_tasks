using System;
//using Module_3_Lib;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {            
            MyMatrix mtrx = new MyMatrix(5, 5, new StrategyOne());
            
            int number = 30;
            mtrx.Fill(number); // filling randomly from 0 to number

            Console.WriteLine("\nThe original matrix: ");
            mtrx.Print();

            Console.WriteLine("\n1. In ascending order of the maximum elements of the rows of the matrix:");
            mtrx.Sort();
            mtrx.Print();

            mtrx.Sortable = new StrategyTwo();

            Console.WriteLine("\n2. In ascending order of the minimum elements of the matrix rows:");
            mtrx.Sort();
            mtrx.Print();

            mtrx.Sortable = new StrategyThree();

            Console.WriteLine("\n3. In ascending order of the sums of the elements of the rows of the matrix:");
            mtrx.Sort();
            mtrx.Print();
        }        
    }
}
