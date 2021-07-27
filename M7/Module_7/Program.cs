using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Module_7
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        //Task 2 and 4: need to implement

        //Task 1
        public static void Task_1()
        {
            Customer user = new Customer("John", "8 777 777 77 77", 100000, new PrintFullInfo());

            Console.WriteLine(user.ShowInfo());

            user.PrintInfo = new PrintContactNumber();
            Console.WriteLine(user.ShowInfo());

            user.PrintInfo = new PrintNameAndRevenue();
            Console.WriteLine(user.ShowInfo());

            user.PrintInfo = new PrintName();
            Console.WriteLine(user.ShowInfo());

            user.PrintInfo = new PrintAdditional();
            Console.WriteLine(user.ShowInfo());
        }


        //Task 3
        public static string AddOrChangeUrlParameter(string url, string parameter)
        {
            if (url.Contains("key=") && parameter.Contains("key="))
            {
                StringBuilder oldValue = new StringBuilder();
                for(int i = url.IndexOf("key="); i < url.Length; i++)
                {
                    oldValue.Append(url[i]);
                }

                StringBuilder result = new StringBuilder(url);

                return result.Replace(oldValue.ToString(), parameter).ToString();
            }
            else if (!url.Contains(parameter) && url.Contains("key="))
            {
                return new StringBuilder(url + "&" + parameter).ToString();
            }
            else
            {
                return new StringBuilder(url + "?" + parameter).ToString();
            }      
        }        

        //Task 5
        public static string ReverseWords(string sentence)
        {
            var words = Regex.Replace(sentence, "[^a-zA-Z0-9% ._]", string.Empty).Split(' ');
            Array.Reverse(words);

            StringBuilder result = new StringBuilder();
            foreach(var item in words)
            {
                result.Append(item + " ");
            }
            
            return result.ToString().TrimEnd();
        }

        //Task 6
        public static string BigIntSum(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                throw new ArgumentNullException();
            }

            BigInteger first = 0, second = 0;

            try
            {
                first = BigInteger.Parse(a);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to convert the string '{a}' to a BigInteger value.");
            }

            try
            {
                second = BigInteger.Parse(b);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to convert the string '{b}' to a BigInteger value.");
            }
       
            return (first + second).ToString();
        }
    }
}
