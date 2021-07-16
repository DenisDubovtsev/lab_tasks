using System;
using MyStackLib;

namespace MyQueueLib
{
    public class MyQueue<T>
    {
        private static readonly int defaultSize = 10;

        private MyStack<T> stackTop;
        private MyStack<T> stackEnd;

        public int Count { get; set; }
        

        public MyQueue()
        {            
            stackTop = new MyStack<T>(defaultSize);
            stackEnd = new MyStack<T>(defaultSize);
        }

        public void Push(T element)
        {
            stackTop.Push(element);
            Count++;
        }

        public T Pop()
        {
            if (stackEnd.IsEmpty())
            {
                while (!stackTop.IsEmpty())
                {
                    stackEnd.Push(stackTop.Pop());
                }                
            }

            Count--;
            
            return stackEnd.Pop();
        }

        public T Peek()
        {
            if (stackEnd.IsEmpty())
            {
                while (!stackTop.IsEmpty())
                {
                    stackEnd.Push(stackTop.Pop());
                }
            }            

            return stackEnd.Peek();
        }

        public void Print()
        {
            while (!stackTop.IsEmpty())
            {
                stackEnd.Push(stackTop.Pop());
            }

            while (!stackEnd.IsEmpty())
            {
                Console.WriteLine(stackEnd.Pop());        

            }
        }

        public void Clear()
        {
            stackEnd.Clear();
            stackTop.Clear();

            Count = 0;
        }

        public bool Contains(T element)
        {
            while (!stackTop.IsEmpty())
            {
                stackEnd.Push(stackTop.Pop());
            }

            foreach (T item in stackEnd)
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
    }
}
