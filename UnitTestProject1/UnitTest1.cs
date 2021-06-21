using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Personal_Stack;
using Frolov_Lib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyStack<int> myStack = new MyStack<int>();

            for (int i = 0; i < 4; i++)
                myStack.Push(i);

            myStack = Program.DellEverySecond(myStack);

            Assert.AreEqual("2\n0\n", myStack.ToString(), "Что-то сломалось");
        }
    }
}
