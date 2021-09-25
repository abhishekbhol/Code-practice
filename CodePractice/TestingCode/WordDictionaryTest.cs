using CodePractice.Tree;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode
{
    public class WordDictionaryTest
    {
        [Test]
        public void TestDictionary()
        {
            var dict = new WordDictionary();
            dict.AddWord("bad");
            dict.AddWord("dad");
            dict.AddWord("mad");

            var res = dict.Search("pad");
            Assert.False(res);
            
            res = dict.Search("bad");
            Assert.True(res);

            res = dict.Search(".ad");
            Assert.True(res);

            res = dict.Search("b..");
            Assert.True(res);
        }
    }
}
