using System;
using Xunit;

namespace Module_7_Tests
{
    public class Module_7Tests
    {
        [Theory]
        [InlineData("www.example.com","key=value", "www.example.com?key=value")]
        [InlineData("www.example.com?key=value", "key2=value2", "www.example.com?key=value&key2=value2")]
        [InlineData("www.example.com?key=oldValue", "key=newValue", "www.example.com?key=newValue")]
        public void AddOrChangeUrlParameer_Test(string url, string parameter, string expected)
        {
            string actual = Module_7.Program.AddOrChangeUrlParameter(url, parameter);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("The greatest victory is that which requires no battle", 
                    "battle no requires which that is victory greatest The")]
        public void ReverseWords_Test(string sentence, string expected)
        {
            string actual = Module_7.Program.ReverseWords(sentence);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("91389681247993671255432112000000", "91389681247993671255432112000000", "182779362495987342510864224000000")]
        public void BigIntSum_Test(string firstNum, string secondNum, string expected)
        {
            string actual = Module_7.Program.BigIntSum(firstNum, secondNum);
            Assert.Equal(actual, expected);
        }
    }
}
