using CodePractice.Dynamic_Programming;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode.DP
{
    public class TestLcs
    {
        [Test]
        public void TestLcs1()
        {
            String s1 = "AGGTAB";
            String s2 = "GXTXAYB";
            Assert.AreEqual(4, LCS.LongestCommonSubsequence(s1, s2));
        }

        [Test]
        public void TestLcs2()
        {
            String s1 = "AGK";
            String s2 = "AK";
            Assert.AreEqual(2, LCS.LongestCommonSubsequence(s1, s2));
        }
    }
}
