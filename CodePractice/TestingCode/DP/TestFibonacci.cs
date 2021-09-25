using CodePractice.Dynamic_Programming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode.DP
{
    public class TestFibonacci
    {
        [Test]
        public void TestMemoization()
        {
            var f = new Fibonacci();
            Fibonacci.Initialize();
            int n = 40;
            Assert.AreEqual(102334155, f.Memoization(n));
        }

        [Test]
        public void TestTabulation()
        {
            var f = new Fibonacci();
            int n = 40;
            Assert.AreEqual(102334155, f.Tabulation(n));
        }
    }
}
