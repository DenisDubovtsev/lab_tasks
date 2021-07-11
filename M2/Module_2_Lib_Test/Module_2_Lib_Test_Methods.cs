using System;
using Xunit;
using Module_2_Lib;

namespace Module_2_Lib_Test
{
    public class Module_2_Lib_Test_Methods
    {
        [Theory]
        [InlineData("jj", "kk", "jk")]
        [InlineData("aabb", "hhggaa", "abhg")]
        public void UniqueConcat_TwoStrings_OneStringWithoutDuplicates(string firstString, string secondString, string expected)
        {
            string actual = Module_2_Methods.UniqueConcat(firstString, secondString);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", "kk")]
        [InlineData("aabb", "")]
        public void UniqueConcat_TwoStrings_OneStringIsEmpty(string firstString, string secondString)
        {
            Assert.Throws<ArgumentNullException>(() => Module_2_Methods.UniqueConcat(firstString, secondString));
        }

        [Theory]
        [InlineData(new int[] {1, 3, 33, 7}, 3, new int[] { 3, 33 })]
        [InlineData(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, new int[] { 7, 7, 70, 17 })]
        [InlineData(new int[] { 7 }, 7, new int[] { 7 })]
        public void ArrayFilter_Digit_ArrayNumbersWithDigit(int[] array, int digit, int[] expected)
        {
            int[] actual = Module_2_Methods.ArrayFilter(array, digit);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, 3)]
        public void ArrayFilter_Digit_NullArray(int[] array, int digit)
        {
            Assert.Throws<ArgumentNullException>(() => Module_2_Methods.ArrayFilter(array, digit));
        }

        [Theory]
        [InlineData(new int[] { 1, 3, 33, 7 }, 33)]
        [InlineData(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 70)]

        public void FindMax_Array_MaxElement(int[] array, int expected)
        {
            int actual = Module_2_Methods.FindMax(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null)]
        public void FindMax_Array_NullArray(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Module_2_Methods.FindMax(array));
        }

        [Theory]
        [InlineData(12356, 12365)]
        [InlineData(12, 21)]
        [InlineData(513, 531)]
        [InlineData(2017, 2071)]
        [InlineData(414, 441)]
        [InlineData(144, 414)]
        [InlineData(1234321, 1241233)]
        [InlineData(1234126, 1234162)]
        [InlineData(3456432, 3462345)]
        [InlineData(771, -1)]
        [InlineData(3331, -1)]
        [InlineData(10, -1)]
        [InlineData(20, -1)]
        [InlineData(2, -1)]

        public void FindNextBigger_Number_NextBiggerNumberWithSameDigits(int number, int expected)
        {
            int actual = Module_2_Methods.FindNextBigger(number);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-5)]
        public void FindNextBigger_Number_NonPositiveNumber(int number)
        {
            Assert.Throws<ArgumentException>(() => Module_2_Methods.FindNextBigger(number));
        }


        [Theory]
        [InlineData(new double[] { 1, 0, 1, 0 }, 1)]
        [InlineData(new double[] { 1 }, -1)]
        [InlineData(new double[] { 1, 1, 1, 1 }, -1)]
        [InlineData(new double[] { 1, 1, 0, 1, 1 }, 2)]
        [InlineData(new double[] { 2.5, 15, 1, 17.5 }, 2)]
        public void FindNumberIndex_Array_Correct(double[] array, int expected)
        {            
            int actual = Module_2_Methods.FindNumberIndex(array);

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(null)]
        public void FindNumberIndex_Array_NullArray(double[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Module_2_Methods.FindNumberIndex(array));
        }

        [Theory]
        [InlineData(new double[] { 1, 0, 1, 0 }, 0, 3, 2)]
        [InlineData(new double[] { 1 }, 0, 0, 1)]
        [InlineData(new double[] { 2.5, 15 }, 0, 1, 17.5)]
        public void SumOfArrayElements_Array_Correct(double[] array, int startIndex, int endIndex, double expected)
        {
            double actual = Module_2_Methods.SumOfArrayElements(array, startIndex, endIndex);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 1, 0, 1, 0 }, -1, 3)]
        public void SumOfArrayElements_Array_StartIndexIncorrect(double[] array, int startIndex, int endIndex)
        {            
            Assert.Throws<IndexOutOfRangeException>(() => Module_2_Methods.SumOfArrayElements(array, startIndex, endIndex));
        }

        [Theory]
        [InlineData(new double[] { 1, 0, 1, 0 }, 1, 10)]
        public void SumOfArrayElements_Array_EndIndexIncorrect(double[] array, int startIndex, int endIndex)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Module_2_Methods.SumOfArrayElements(array, startIndex, endIndex));
        }
    }
}
