using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace GCDCalculator
{
    public class GreatestCommonDivisorCalculator
    {
        public int[] Numbers { get; set; }
        public ICalculation GcdCalcType { get; set; }

        public GreatestCommonDivisorCalculator(List<int> numbers, ICalculation gcdCalcType)
        {
            Numbers = numbers.ToArray();
            GcdCalcType = gcdCalcType;
        }

        public int GCD(out TimeSpan time)
        {
            int result = Numbers[0];

            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 1; i < Numbers.Length; i++)
            {
                result = GcdCalcType.GCD(Numbers[i], result);

                if (result == 1)
                {
                    watch.Stop();
                    time = watch.Elapsed;
                    return 1;
                }
            }

            watch.Stop();
            time = watch.Elapsed;
            return result;
        }       
    }
}
