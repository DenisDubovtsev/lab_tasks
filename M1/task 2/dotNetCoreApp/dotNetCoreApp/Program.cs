using System;
using MyStandardLibrary;

namespace dotNetCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name, please: ");
            string name = Console.ReadLine();
            string greet = MyLogger.PrintGreeting(name);            

            Console.WriteLine(greet);
            Console.ReadLine();
        }

        
    }
}

