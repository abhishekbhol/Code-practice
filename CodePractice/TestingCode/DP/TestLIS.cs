using CodePractice.Dynamic_Programming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode.DP
{
    public class TestLIS
    {
        [Test]
        public void TestLis1()
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
            int n = arr.Length;
            Assert.AreEqual(5, LIS.longestIncreasingSequence(arr, n));
        }

        [Test]
        public void TestLis2()
        {
            int[] arr = { 3, 10, 2, 1, 20 };
            int n = arr.Length;
            Assert.AreEqual(3, LIS.longestIncreasingSequence(arr, n));
        }

        [Test]
        public void TestLis3()
        {
            int[] arr = { 3, 2 };
            int n = arr.Length;
            Assert.AreEqual(1, LIS.longestIncreasingSequence(arr, n));
        }

        [Test]
        public void TestLis4()
        {
            int[] arr = { 50, 3, 10, 7, 40, 80 };
            int n = arr.Length;
            Assert.AreEqual(4, LIS.longestIncreasingSequence(arr, n));
        }
    }
}
