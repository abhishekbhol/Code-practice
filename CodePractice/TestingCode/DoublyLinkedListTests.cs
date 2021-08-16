using CodePractice.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingCode
{
    public class DoublyLinkedListTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DoublyLinkedListInsetionTest()
        {
            var ll = new DoublyLinkedList(3);
            ll.InsertAtStart(2);
            ll.InsertAtLast(5);
            ll.InsertAfter(ll.head.next, 4);
            ll.InsertAtStart(1);

            Assert.AreEqual(ll.Length(), 5);
            Assert.AreEqual(ll.head.data, 1);
            Assert.AreEqual(ll.head.next.data, 2);
            Assert.AreEqual(ll.head.next.next.data, 3);
            Assert.AreEqual(ll.head.next.next.next.data, 4);
            Assert.AreEqual(ll.head.next.next.next.next.data, 5);
        }

        [Test]
        public void DoublyLinkedListDeletionTest()
        {
            var ll = new DoublyLinkedList(3);
            ll.InsertAtStart(2);
            ll.InsertAtLast(4);
            ll.InsertAtStart(1);

            Assert.AreEqual(ll.Length(), 4);

            ll.DeleteFromStart();
            Assert.AreEqual(ll.Length(), 3);
            Assert.AreEqual(ll.head.data, 2);

            ll.DeleteFromEnd();
            Assert.AreEqual(ll.Length(), 2);
            Assert.AreEqual(ll.head.data, 2);
            Assert.AreEqual(ll.head.next.data, 3);

            ll.DeleteFromEnd();
            Assert.AreEqual(ll.Length(), 1);
            Assert.AreEqual(ll.head.data, 2);
            Assert.Null(ll.head.next);

            ll.DeleteFromStart();
            Assert.AreEqual(ll.Length(), 0);
            Assert.Null(ll.head);
        }

        [Test]
        public void TestDllDuplicates1()
        {
            var ll = new DoublyLinkedList(3);
            ll.InsertAtStart(2);
            ll.InsertAtStart(2);
            ll.InsertAtLast(2);
            ll.InsertAtLast(3);
            ll.InsertAtLast(2);

            DLLService.RemoveDuplicates(ll.head);
            var count = ll.Length();
            Assert.AreEqual(2, count);
            Assert.AreEqual(2, ll.head.data);
            Assert.AreEqual(3, ll.head.next.data);
        }

        [Test]
        public void TestDLLDuplicates2()
        {
            var ll = new DoublyLinkedList(2);
            ll.InsertAtStart(2);
            ll.InsertAtStart(2);
            ll.InsertAtStart(2);

            DLLService.RemoveDuplicates(ll.head);
            var count = ll.Length();
            Assert.AreEqual(1, count);
            Assert.AreEqual(2, ll.head.data);
        }

        [Test]
        public void TestDLLDuplicates3()
        {
            var ll = new DoublyLinkedList(3);
            ll.InsertAtStart(2);
            ll.InsertAtStart(2);
            ll.InsertAtLast(4);
            ll.InsertAtLast(4);
            ll.InsertAtLast(4);
            ll.InsertAtLast(5);
            ll.InsertAtLast(4);
            ll.InsertAtLast(3);
            ll.InsertAtLast(5);

            DLLService.RemoveDuplicates(ll.head);
            var count = ll.Length();
            Assert.AreEqual(4, count);
            Assert.AreEqual(2, ll.head.data);
            Assert.AreEqual(3, ll.head.next.data);
            Assert.AreEqual(4, ll.head.next.next.data);
            Assert.AreEqual(5, ll.head.next.next.next.data);
        }

        [Test]
        public void TestRotate()
        {
            var ll = new DoublyLinkedList(3);
            ll.InsertAtStart(2);
            ll.InsertAtStart(1);
            ll.InsertAtLast(4);
            ll.InsertAtLast(5);

            var res = DLLService.Rotate(ll.head, 2);

            Assert.AreEqual(3, res.data);
            Assert.AreEqual(4, res.next.data);
            Assert.AreEqual(5, res.next.next.data);
            Assert.AreEqual(1, res.next.next.next.data);
            Assert.AreEqual(2, res.next.next.next.next.data);
        }

        [Test]
        public void TestCopyRandomPointers()
        {
            var ll = new DoublyLinkedList(3);
            ll.InsertAtStart(2);
            ll.InsertAtStart(1);
            ll.InsertAtLast(4);
            ll.InsertAtLast(5);

            ll.head.prev = ll.head.next.next;
            ll.head.next.prev = ll.head;
            ll.head.next.next.prev = ll.head.next.next.next.next;
            ll.head.next.next.next.prev = ll.head.next.next.next.next;
            ll.head.next.next.next.next.prev = ll.head.next;

            var res = DLLService.CopyWithRamdomPointers(ll.head);

            Assert.AreEqual(res.data, 1);
            Assert.AreEqual(res.next.data, 2);
            Assert.AreEqual(res.next.next.data, 3);
            Assert.AreEqual(res.next.next.next.data, 4);
            Assert.AreEqual(res.next.next.next.next.data, 5);

            Assert.AreEqual(res.prev, res.next.next);
            Assert.AreEqual(res.next.prev, res);
            Assert.AreEqual(res.next.next.prev, res.next.next.next.next);
            Assert.AreEqual(res.next.next.next.prev, res.next.next.next.next);
            Assert.AreEqual(res.next.next.next.next.prev, res.next);
        }
    }
}
