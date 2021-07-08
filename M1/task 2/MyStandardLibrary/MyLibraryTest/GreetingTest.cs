using System;
using Xunit;
using MyStandardLibrary;

namespace MyLibraryTest
{
    public class GreetingTest
    {
        [Fact]
        public void Is_Correct_Greeting()
        {
            //arrange
            string name = "Denis";

            //act
            string expected = $"Hello, Denis, {DateTime.Now}";
            string actual = MyLogger.PrintGreeting(name);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
