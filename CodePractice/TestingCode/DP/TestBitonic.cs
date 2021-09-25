using CodePractice.Dynamic_Programming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode.DP
{
    public class TestBitonic
    {
        [Test]
        public void TestBitonic1()
        {
            int[] arr = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            int n = arr.Length;
            Assert.AreEqual(7, Bitonic.BitonicSequence(arr, n));
        }

        [Test]
        public void TestBitonic2()
        {
            int[] arr = { 1, 11, 2, 10, 4, 5, 2, 1 };
            int n = arr.Length;
            Assert.AreEqual(6, Bitonic.BitonicSequence(arr, n));
        }

        [Test]
        public void TestBitonic3()
        {
            int[] arr = { 12, 11, 40, 5, 3, 1 };
            int n = arr.Length;
            Assert.AreEqual(5, Bitonic.BitonicSequence(arr, n));
        }
    }
}
