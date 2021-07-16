using System;
using Xunit;
using MyStackLib;
using MyQueueLib;
using MyListLib;

namespace MyCollectionLibTests
{
    public class MyCollectionTest
    {
        //MyList tests
        [Fact]
        public void MyList_CountTest()
        {
            MyList<int> sut = new MyList<int>();

            Assert.Equal(0, sut.Count);
            sut.Add(10);
            Assert.Equal(1, sut.Count);
            sut.Clear();
            Assert.Equal(0, sut.Count);
        }

        [Fact]
        public void MyList_InsertAtTest()
        {
            MyList<int> sut = new MyList<int>();

            sut.Add(10);
            sut.Add(20);
            sut.InsertAt(100, 1);

            int expected = 100;
            int actual = sut[1];

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyList_RemoveAtTest()
        {
            MyList<int> sut = new MyList<int>();

            sut.Add(10);
            sut.Add(20);
            sut.Add(30);
            sut.InsertAt(100, 1);
            sut.RemoveAt(1);

            int expected = 20;
            int actual = sut[1];

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyList_ContainsTest()
        {
            MyList<int> sut = new MyList<int>();

            sut.Add(10);
            sut.Add(20);
            sut.Add(30);
            
            bool expected = true;
            bool actual = sut.Contains(10);

            Assert.Equal(actual, expected);

            expected = false;
            actual = sut.Contains(100);

            Assert.Equal(actual, expected);
        }

        //MyQueue tests
        [Fact]
        public void MyQueue_PushTest()
        {
            var sut = new MyQueue<int>();
            sut.Push(5);

            int expected = 1;
            int actual = sut.Count;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyQueue_PopTest()
        {
            var sut = new MyQueue<int>();
            sut.Push(5);
            sut.Push(5);
            sut.Push(5);
            sut.Pop();

            int expected = 2;
            int actual = sut.Count;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyQueue_PeekTest()
        {
            var sut = new MyQueue<int>();
            sut.Push(15);
            sut.Push(5);

            int expected = 15;
            int actual = sut.Peek();

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyQueue_ClearTest()
        {
            var sut = new MyQueue<int>();
            sut.Push(15);
            sut.Push(5);
            sut.Clear();

            bool expected = true;
            bool actual = sut.IsEmpty();

            Assert.Equal(actual, expected);
        }


        //MyStack tests
        [Fact]
        public void MyStack_PushTest()
        {
            var sut = new MyStack<int>();
            sut.Push(5);

            int expected = 1;
            int actual = sut.Count;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyStack_PopTest()
        {
            var sut = new MyStack<int>();
            sut.Push(5);
            sut.Push(5);
            sut.Push(5);
            sut.Pop();

            int expected = 2;
            int actual = sut.Count;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyStack_PeekTest()
        {
            var sut = new MyStack<int>();
            sut.Push(15);
            sut.Push(5);

            int expected = 5;
            int actual = sut.Peek();

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MyStack_ClearTest()
        {
            var sut = new MyStack<int>();
            sut.Push(15);
            sut.Push(5);
            sut.Clear();

            bool expected = true;
            bool actual = sut.IsEmpty();

            Assert.Equal(actual, expected);
        }
    }
}
