using System;
using System.Collections;

namespace MyListLib
{
    public class MyList<T> : IEnumerable
    {
        private T[] array;
        private int topIndex = -1;
        private int capacity;
        public int Count { get; set; }

        public MyList(int defaultSize = 0)
        {
            capacity = defaultSize;
            array = new T[capacity];
        }


        public void InsertAt(T newElement, int index)
        {            
            Count++;
            Array.Resize(ref array, Count);

            for (int i = topIndex; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = newElement;
            topIndex++;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < topIndex - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[topIndex - 1] = default(T);
            topIndex--;
        }

        public void Clear()
        {
            array = new T[1];
            Count = 0;
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

        
        public void Add(T element)
        {
            Count++;
            Array.Resize(ref array, Count);
            topIndex++;
            array[topIndex] = element;
        }      

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
