using CodePractice.LinkedList;
using NUnit.Framework;

namespace TestingCode
{
    public class LinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LinkedListInsetionTest()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(5);
            ll.InsertAfter(ll.head.next, 4);
            ll.InsertAtFirst(1);

            Assert.AreEqual(ll.size, 5);
            Assert.AreEqual(ll.head.data, 1);
            Assert.AreEqual(ll.head.next.data, 2);
            Assert.AreEqual(ll.head.next.next.data, 3);
            Assert.AreEqual(ll.head.next.next.next.data, 4);
            Assert.AreEqual(ll.head.next.next.next.next.data, 5);
        }

        [Test]
        public void LinkedListDeletionTest()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(4);
            ll.InsertAtFirst(1);

            Assert.AreEqual(ll.size, 4);

            ll.DeleteFromStart();
            Assert.AreEqual(ll.size, 3);
            Assert.AreEqual(ll.head.data, 2);

            ll.DeleteFromEnd();
            Assert.AreEqual(ll.size, 2);
            Assert.AreEqual(ll.head.data, 2);
            Assert.AreEqual(ll.head.next.data, 3);

            ll.DeleteFromEnd();
            Assert.AreEqual(ll.size, 1);
            Assert.AreEqual(ll.head.data, 2);
            Assert.Null(ll.head.next);

            ll.DeleteFromStart();
            Assert.AreEqual(ll.size, 0);
            Assert.Null(ll.head);
        }

        [Test]
        public void TestNthNodeFromStartAllCases()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(4);
            ll.InsertAtFirst(1);

            var node = ll.NthNodeFromStart(2);
            Assert.AreEqual(node.data, 2);

            node = ll.NthNodeFromStart(1);
            Assert.AreEqual(node.data, 1);

            node = ll.NthNodeFromStart(4);
            Assert.AreEqual(node.data, 4);

            node = ll.NthNodeFromStart(5);
            Assert.Null(node);
        }

        [Test]
        public void TestNthNodeFromStart1Node()
        {
            var ll = new LinkedList(3);

            var node = ll.NthNodeFromStart(2);
            Assert.Null(node);

            node = ll.NthNodeFromStart(1);
            Assert.AreEqual(node.data, 3);
        }

        [Test]
        public void TestNthNodeFromEndAllCases()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(4);
            ll.InsertAtFirst(1);

            var node = ll.NthNodeFromEnd(2);
            Assert.AreEqual(node.data, 3);

            node = ll.NthNodeFromEnd(3);
            Assert.AreEqual(node.data, 2);

            node = ll.NthNodeFromEnd(4);
            Assert.AreEqual(node.data, 1);

            node = ll.NthNodeFromEnd(1);
            Assert.AreEqual(node.data, 4);

            node = ll.NthNodeFromEnd(5);
            Assert.Null(node);
        }

        [Test]
        public void TestNthNodeFromEnd1Node()
        {
            var ll = new LinkedList(3);

            var node = ll.NthNodeFromEnd(2);
            Assert.Null(node);

            node = ll.NthNodeFromEnd(1);
            Assert.AreEqual(node.data, 3);
        }

        [Test]
        public void TestMiddleElement()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(1);

            var node = ll.MiddleElement();
            Assert.AreEqual(node.data, 2);

            ll.InsertAtLast(4);
            node = ll.MiddleElement();
            Assert.AreEqual(node.data, 3);
        }

        [Test]
        public void TestMiddleElement1element()
        {
            var ll = new LinkedList(3);

            var node = ll.MiddleElement();
            Assert.AreEqual(node.data, 3);

            ll.DeleteFromEnd();
            node = ll.MiddleElement();
            Assert.Null(node);
        }

        [Test]
        public void TestPalindrome()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(2);

            var val = ll.IsPalindrome();  // 2->3->2
            Assert.True(val);

            ll.InsertAfter(ll.head.next, 3); // 2->3->3->2
            val = ll.IsPalindrome();
            Assert.True(val);

            ll.DeleteFromStart(); // 3->3->2
            val = ll.IsPalindrome();
            Assert.False(val);

            ll.DeleteFromEnd(); // 3->3
            val = ll.IsPalindrome();
            Assert.True(val);

            ll.DeleteFromEnd(); // 3
            val = ll.IsPalindrome();
            Assert.True(val);
        }

        [Test]
        public void TestDuplicates1()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(2);
            ll.InsertAtLast(3);
            ll.InsertAtLast(2);

            ll.RemoveAllDuplicates();
            var count = ll.size;
            Assert.AreEqual(2, count);
            Assert.AreEqual(2, ll.head.data);
            Assert.AreEqual(3, ll.head.next.data);
        }

        [Test]
        public void TestDuplicates2()
        {
            var ll = new LinkedList(2);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(2);

            ll.RemoveAllDuplicates();
            var count = ll.size;
            Assert.AreEqual(1, count);
            Assert.AreEqual(2, ll.head.data);
        }

        [Test]
        public void TestDuplicates3()
        {
            var ll = new LinkedList(3);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(2);
            ll.InsertAtLast(4);
            ll.InsertAtLast(4);
            ll.InsertAtLast(4);
            ll.InsertAtLast(5);
            ll.InsertAtLast(4);
            ll.InsertAtLast(3);
            ll.InsertAtLast(5);

            ll.RemoveAllDuplicates();
            var count = ll.size;
            Assert.AreEqual(4, count);
            Assert.AreEqual(2, ll.head.data);
            Assert.AreEqual(3, ll.head.next.data);
            Assert.AreEqual(4, ll.head.next.next.data);
            Assert.AreEqual(5, ll.head.next.next.next.data);
        }

    }
}