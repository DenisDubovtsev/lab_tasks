using System;
using System.Collections.Generic;
using GCDCalculator;
using NullableExtension;

namespace Module_4
{
    public static class Program
    {
        public static void Main()
        {
            /*
            Разработать класс, позволяющий выполнять вычисления НОД 
            по алгоритму Евклида для двух, трех и т.д. целых чисел             
            */

            Task_2_GCD();

            /*
            Реализовать для null-able типов, дополнительную возможность определения - является ссылка null или нет
             */

            Task_3_IsNullExtension();
        }

        public static void Task_2_GCD()
        {
            List<int> numbers = new List<int>() { 1250, 1100, 2250 };

            Console.WriteLine("List of numbers: ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            TimeSpan time;

            Console.WriteLine();
            GreatestCommonDivisorCalculator calc = new GreatestCommonDivisorCalculator(numbers, new GcdRecursive());

            Console.WriteLine($"{calc.GcdCalcType.GetType().Name}\tGCD: {calc.GCD(out time)}\ttime: {time} ");

            calc.GcdCalcType = new GcdLoop();
            Console.WriteLine($"{calc.GcdCalcType.GetType().Name}\t\tGCD: {calc.GCD(out time)}\ttime: {time} ");

            calc.GcdCalcType = new GcdClassical();
            Console.WriteLine($"{calc.GcdCalcType.GetType().Name}\tGCD: {calc.GCD(out time)}\ttime: {time} ");

            calc.GcdCalcType = new GcdBinary();
            Console.WriteLine($"{calc.GcdCalcType.GetType().Name}\tGCD: {calc.GCD(out time)}\ttime: {time} ");

            calc.GcdCalcType = new GcdBitCalc();
            Console.WriteLine($"{calc.GcdCalcType.GetType().Name}\tGCD: {calc.GCD(out time)}\ttime: {time} ");

            Console.WriteLine();
        }

        public static void Task_3_IsNullExtension()
        {
            string name = "Kathy";
            name = null;
            int? a = 5;
            int? b = null;
            double? c = 5;

            Console.WriteLine(name.IsNull());
            Console.WriteLine(name.IsNull());
            Console.WriteLine(a.IsNull());
            Console.WriteLine(b.IsNull());
            Console.WriteLine(c.IsNull());
        }       
    }   
}
