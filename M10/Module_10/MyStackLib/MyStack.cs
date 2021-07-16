using System;
using System.Collections;


namespace MyStackLib
{
    public class MyStack<T> : IEnumerable, ICloneable
    {
        private static readonly int defaultSize = 10;

        private T[] array;
        private int topIndex = -1;
        public int Count 
        { 
            get
            {
                return topIndex + 1;
            }
        }

        public MyStack()
        {
            array = new T[defaultSize];
        }
        public MyStack(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                array = new T[size];
            }
            
        }

        public void Push(T element)
        {
            if (topIndex == array.Length-1)
            {
                T[] newArray = new T[array.Length + 10];
                Array.Copy(array, 0, newArray, 0, topIndex + 1);
                array = newArray;
            }

            array[++topIndex] = element;
        }
        public T Pop()
        {
            if (topIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return array[topIndex--];
            }
        }
        public T Peek()
        {
            if (topIndex < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return array[topIndex];
            }            
        }

        public T[] ToArray()
        {
            T[] newArray = new T[topIndex + 1];
            Array.Copy(array, 0, newArray, 0, topIndex + 1);
            
            return newArray;
        }       
        public object Clone()
        {
            return MemberwiseClone();
        }
        public void Clear()
        {
            Array.Clear(array, 0, topIndex + 1);
            topIndex = -1;
        }

        

        public bool Contains(T element)
        {

            foreach (T item in array)
            {
                if (item.Equals(element))
                {
                    return true;
                }

            }
            return false;
        }

        public bool IsEmpty()
        {
            return (Count == 0) ? true : false;            
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}

