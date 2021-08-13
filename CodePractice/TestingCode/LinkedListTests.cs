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
    }
}