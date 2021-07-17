using System;
using Xunit;
using Module_3_Lib;

namespace Module_3_Lib_Tests
{
    public class Module_3_Lib
    {
        [Theory]
        [InlineData(1, 5, 0.0001, 1)]
        [InlineData(8, 3, 0.0001, 2)]
        [InlineData(0.001, 3, 0.0001, 0.1)]
        [InlineData(0.04100625, 4, 0.0001, 0.45)]
        [InlineData(0.0279936, 7, 0.0001, 0.6)]
        [InlineData(0.0081, 4, 0.1, 0.3)]
        [InlineData(-0.008, 3, 0.1, -0.2)]
        [InlineData(0.004241979, 9, 0.00000001, 0.545)]
        public void FindNthRoot_Test(double number, int degree, double accuracy, double expected)
        {
            double actual = Module_3.FindNthRoot(number, degree, accuracy);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(-0.01, 2, 0.0001)]
        [InlineData(0.001, -2, 0.0001)]
        [InlineData(0.01, 2, -1)]
        public void FindNthRoot_Exc_Test(double number, int degree, double accuracy)
        {
            Assert.Throws<ArgumentException>(() => Module_3.FindNthRoot(number, degree, accuracy));
        }
    }
}
