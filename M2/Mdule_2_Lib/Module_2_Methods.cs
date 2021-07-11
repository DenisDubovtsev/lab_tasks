using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Lib
{
    public static class Module_2_Methods
    {
        /* (это задание пока не получается)
        #1 Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). 
        Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в 
        другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются 
        справа налево). Разработать модульные тесты (NUnit и(!) MS Unit Test) для 
        тестирования метода. (Ниже пояснение к алгоритму).         
        */

        public static void BitShifting(int numberOne, int numberTwo, int i, int j)
        {
            throw new NotImplementedException();
        }

        /*
        #2 Реализовать рекурсивный алгоритм поиска максимального элемента в неотсортированном целочисленом массиве.
        */
        public static int FindMax(int[] numbers, int index = 0)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            if (numbers.Length > index)
            {
                int next = FindMax(numbers, index + 1);
                return (numbers[index] > next) ? numbers[index] : next;
            }
            else
            {
                return numbers[0];
            }
        }

        /*
        #3 Реализовать алгоритм поиска в вещественном массиве индекса элемента, для которого сумма элементов 
        слева и сумма элементов спарава равны. Если такого элемента не существует вернуть null (или -1).
        */
        public static int FindNumberIndex(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            double sumLeft = array[0];
            double sumRight = SumOfArrayElements(array, 2, array.Length - 1);

            int index = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (sumLeft == sumRight)
                {
                    index = i;
                    break;
                }

                else
                {
                    sumLeft += array[i];
                    sumRight -= array[i + 1];
                }
            }

            return index;
        }

        /*
        #4 Реализовать алгоритм конкатенации двух строк, содержащих только символы латинского алфавита, 
        исключая повторяющиеся символы.
        */
        public static string UniqueConcat(string firstString, string secondString)
        {         
            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                throw new ArgumentNullException();
            }

            StringBuilder resultString = new StringBuilder();

            string temp = firstString + secondString;
            for (int i = 0; i < temp.Length; i++)
            {
                if (!resultString.ToString().Contains(temp[i]) && temp[i] != ' ')
                {
                    resultString.Append(temp[i]);
                }
            }

            return resultString.ToString();
        }

        /*
        #5 Реализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее 
        целое, состоящее из цифр исходного числа, и null (или -1), если такого числа не существует.

        TODO: Добавить к методу FindNextBiggerNumber возможность вернуть время нахождения заданного числа (!)
        */
        public static int FindNextBigger(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException();
            }

            string numberString = number.ToString();

            List<char> rightPart = new List<char>();
            List<char> leftPart = new List<char>();

            bool isSame = true;
            for (int i = 0; i < numberString.Length - 1; i++)
            {
                if (numberString[i] < numberString[i + 1])
                {
                    isSame = false;
                    break;
                }
            }

            if (!isSame)
            {
                char stopDigit = ' ';
                for (int i = numberString.Length - 1; i > 0; i--)
                {
                    if (numberString[i - 1] >= numberString[i])
                    {
                        rightPart.Add(numberString[i]);
                    }
                    else
                    {
                        stopDigit = numberString[i];
                        rightPart.Add(numberString[i - 1]);

                        for (int j = 0; j < i - 1; j++)
                        {
                            leftPart.Add(numberString[j]);
                        }

                        rightPart.Sort();
                        break;
                    }

                }
                string result = new string(leftPart.ToArray()) + stopDigit + new string(rightPart.ToArray());

                return Convert.ToInt32(result);
            }
            else
            {
                return -1;
            }
        }

        /*
        #6 Реализовать метод FilterDigit который принимает массив целых чисел и фильтрует его таким образом, 
        чтобы на выходе остались только числа, содержащие заданную цифру
        */
        public static int[] ArrayFilter(int[] array, int number)
        {
            if ( array == null)
            {
                throw new ArgumentNullException();
            }

            List<int> filtered = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(number.ToString()))
                {
                    filtered.Add(array[i]);
                }
            }

            return filtered.ToArray();
        }

        public static double SumOfArrayElements(double[] array, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            double sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += array[i];
            }

            return sum;
        }        
    }
}
