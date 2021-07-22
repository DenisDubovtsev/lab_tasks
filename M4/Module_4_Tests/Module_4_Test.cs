using System;
using Xunit;
using GCDCalculator;
using NullableExtension;
using System.Collections.Generic;

namespace Module_4_Tests
{
    public class Module_4_Test
    {
        [Fact]
        public void GCD_Test()
        {
            List<int> numbers = new List<int>() { 1250, 1100, 2250 };

            var calc = new GreatestCommonDivisorCalculator(numbers, new GcdRecursive());
            Assert.Equal(50, calc.GCD(out _));
           
            calc.GcdCalcType = new GcdLoop();
            Assert.Equal(50, calc.GCD(out _));

            calc.GcdCalcType = new GcdClassical();
            Assert.Equal(50, calc.GCD(out _));

            calc.GcdCalcType = new GcdBinary();
            Assert.Equal(50, calc.GCD(out _));

            calc.GcdCalcType = new GcdBitCalc();
            Assert.Equal(50, calc.GCD(out _));
        }

        [Fact]       
        public void IsNull_Test()
        {
            int? a = 5;            
            Assert.True(!a.IsNull());

            a = null;
            Assert.True(a.IsNull());
            
            double? b = 5.5;
            Assert.True(!b.IsNull());
            
            b = null;
            Assert.True(b.IsNull());

            string str = "Kathy";
            Assert.True(!str.IsNull());

            str = null;
            Assert.True(str.IsNull());
        }        
    }
}
