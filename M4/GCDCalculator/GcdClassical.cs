using System;
using System.Collections.Generic;
using System.Text;

namespace GCDCalculator
{
    public class GcdClassical : ICalculation
    {
        public int GCD(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (b < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        } 
    }
}
