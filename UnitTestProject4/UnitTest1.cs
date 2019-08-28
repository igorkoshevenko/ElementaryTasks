using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task8.Fibonacci;

namespace UnitTestProject4
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciMethodTest()
        {
            int a = 2;

            int expected = 1;

            Fibonacci f = new Fibonacci(0, 100);
            int actual = f.fib(2);

            Assert.AreEqual(expected, actual);
        }
    }
}
