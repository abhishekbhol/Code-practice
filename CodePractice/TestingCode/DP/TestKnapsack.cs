using CodePractice.Dynamic_Programming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode.DP
{
    public class TestKnapsack
    {
        [Test]
        public void TestKnapsack1()
        {
            var k = new Knapsack();
            var val = new int[] { 60, 100, 120 };
            var wt = new int[] { 10, 20, 30 };
            int W = 50;

            Assert.AreEqual(220, k.ZeroOneKnapsack(val, wt, W));
        }

    }
}
