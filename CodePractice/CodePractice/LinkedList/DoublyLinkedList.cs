using CodePractice.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.LinkedList
{
    public class DoublyNode
    {
        public int data;
        public DoublyNode next;
        public DoublyNode prev;

        public DoublyNode(int data)
        {
            this.data = data;
            this.next = this.prev = null;
        }
    }


    public class DoublyLinkedList
    {
        public DoublyNode head;

        public DoublyLinkedList()
        {
            head = null;
        }

        public DoublyLinkedList(int data)
        {
            head = new DoublyNode(data);
        }

        #region Length

        public int Length()
        {
            int len = 0;
            var tmp = head;
            while(tmp != null)
            {
                tmp = tmp.next;
                len++;
            }
            return len;
        }

        #endregion

        #region Insertion

        public void InsertAtStart(int data)
        {
            var newNode = new DoublyNode(data);
            if(head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }

        public void InsertAtLast(int data)
        {
            var newNode = new DoublyNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            var tmp = head;

            while(tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = newNode;
            newNode.prev = tmp;
        }

        public void InsertAfter(DoublyNode node, int data)
        {
            if(node == null)
            {
                return;
            }
            var newNode = new DoublyNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = node.next;
            newNode.prev = node;

            node.next.prev = newNode;
            node.next = newNode;
        }

        #endregion

        #region Deletion

        public void DeleteFromStart()
        {
            if(head == null)
            {
                return;
            }
            if(head.next == null)
            {
                head = null;
                return;
            }

            head.next.prev = null;
            head = head.next;
        }

        public void DeleteFromEnd()
        {
            if (head == null)
            {
                return;
            }
            if (head.next == null)
            {
                head = null;
                return;
            }

            var tmp = head;

            while(tmp.next.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next.prev = null;
            tmp.next = null;

        }

        #endregion
    }
}
