using System;

namespace MyStandardLibrary
{
    public static class MyLogger
    {
        public static string PrintGreeting(string name) => $"Hello, {name}, {DateTime.Now}";               
    }
}


