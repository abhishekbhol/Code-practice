using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CodePractice.Questions;

namespace TestingCode
{
    public class General
    {
        [Test]
        public void TestMaxScore()
        {
            var maxScore = new MaxScoreFromRemovingStones();
            var res = maxScore.MaximumScore(2, 4, 6);
            Assert.AreEqual(6, res);
        }
    }
}
