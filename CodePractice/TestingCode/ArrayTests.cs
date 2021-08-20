using CodePractice.Array;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode
{
    public class ArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestArrangePositiveAndNegativeNumbers1()
        {
            var arr = new int[] { 1, -2, 4, 3, -5, -8, 7, -9 ,-6 };
            ArrayService.ArrangePositiveAndNegativeArray(arr, 9);
            Assert.IsTrue(arr[0] < 0);
            Assert.IsTrue(arr[1] < 0);
            Assert.IsTrue(arr[2] < 0);
            Assert.IsTrue(arr[3] < 0);
            Assert.IsTrue(arr[4] < 0);
            Assert.IsTrue(arr[5] > 0);
            Assert.IsTrue(arr[6] > 0);
            Assert.IsTrue(arr[7] > 0);
            Assert.IsTrue(arr[8] > 0);
        }

        [Test]
        public void TestArrangePositiveAndNegativeNumbers2()
        {
            var arr = new int[] { 1, -2, 3, -5, -8, 7, -9, -6 };
            ArrayService.ArrangePositiveAndNegativeArray(arr, 8);
            Assert.IsTrue(arr[0] < 0);
            Assert.IsTrue(arr[1] < 0);
            Assert.IsTrue(arr[2] < 0);
            Assert.IsTrue(arr[3] < 0);
            Assert.IsTrue(arr[4] < 0);
            Assert.IsTrue(arr[5] > 0);
            Assert.IsTrue(arr[6] > 0);
            Assert.IsTrue(arr[7] > 0);
        }

        [Test]
        public void TestArrangePositiveAndNegativeNumbers3()
        {
            var arr = new int[] { 1, 2, 4, 3, 5 };
            ArrayService.ArrangePositiveAndNegativeArray(arr, 5);
            Assert.IsTrue(arr[0] > 0);
            Assert.IsTrue(arr[1] > 0);
            Assert.IsTrue(arr[2] > 0);
            Assert.IsTrue(arr[3] > 0);
            Assert.IsTrue(arr[4] > 0);
        }

        [Test]
        public void TestArrangePositiveAndNegativeNumbers4()
        {
            var arr = new int[] { -1, -2, -4, -3, -5 };
            ArrayService.ArrangePositiveAndNegativeArray(arr, 5);
            Assert.IsTrue(arr[0] < 0);
            Assert.IsTrue(arr[1] < 0);
            Assert.IsTrue(arr[2] < 0);
            Assert.IsTrue(arr[3] < 0);
            Assert.IsTrue(arr[4] < 0);
        }
    }
}
