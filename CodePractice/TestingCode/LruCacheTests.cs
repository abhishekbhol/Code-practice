using CodePractice.Cache;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode
{
    public class LruCacheTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBasicCacheInsertion()
        {
            var cache = new LRUCache(4);
            cache.Set("abhi", "shek");
            cache.Set("mona", "lisa");

            var res = cache.Peek();
            Assert.AreEqual("lisa", res);

            res = cache.Get("abhi");
            Assert.AreEqual("shek", res);

            res = cache.Get("mona");
            Assert.AreEqual("lisa", res);
        }

        [Test]
        public void TestBasicCacheInsertionObject()
        {
            var cache = new LRUCache(4);
            cache.Set("abhi", 1);
            cache.Set("mona", "lisa");

            var res = cache.Peek();
            Assert.AreEqual("lisa", res);

            res = cache.Get("abhi");
            Assert.AreEqual(1, res);

            res = cache.Get("mona");
            Assert.AreEqual("lisa", res);

            cache.Set("lala", new List<string> { "val1", "val2", "val3" });
            List<string> res1 = (List<string>)cache.Get("lala");
            Assert.AreEqual(3, res1.Count);
        }

        [Test]
        public void TestCacheEviction()
        {
            var cache = new LRUCache(4);
            cache.Set("abhi", "shek");
            cache.Set("mona", "lisa");
            cache.Set("harry", "potter");
            cache.Set("ron", "weisley");
            cache.Set("hermione", "granger");

            var res = cache.Get("abhi");
            Assert.AreEqual(null, res);
        }

        [Test]
        public void TestCacheEviction2()
        {
            var cache = new LRUCache(3);
            cache.Set("abhi", "shek");
            cache.Set("mona", "lisa");
            cache.Set("harry", "potter");

            var res = cache.Peek();
            Assert.AreEqual("potter", res);

            cache.Set("ron", "weisley");

            res = cache.Peek();
            Assert.AreEqual("weisley", res);

            res = cache.Get("abhi");
            Assert.AreEqual(null, res);

            cache.Set("hermione", "granger");

            res = cache.Get("mona");
            Assert.AreEqual(null, res);

            res = cache.Get("harry");
            Assert.AreEqual("potter", res);
        }

    }
}
