using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }


    public class LinkedList
    {
        public Node head;
        public int size;

        public LinkedList()
        {
            head = null;
            size = 0;
        }

        public LinkedList(int data)
        {
            head = new Node(data);
            size = 1;
        }

        #region Insertion

        public void InsertAtStart(int data)
        {
            var newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            size++;
        }

        public void InsertAtLast(int data)
        {
            var newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node tmp = head;

            while(tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = newNode;
            size++;
        }

        public void InsertAfter(Node node, int data)
        {
            if(node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }

            var newNode = new Node(data);

            newNode.next = node.next;

            node.next = newNode;

            size++;
        }

        #endregion

        #region Deletion

        public void DeleteFromStart()
        {
            if(head == null)
            {
                return;
            }
            head = head.next;
            size--;
        }

        public void DeleteFromEnd()
        {
            if(head == null)
            {
                return;
            }

            if(head.next == null)
            {
                head = null;
                size--;
                return;
            }

            Node tmp = head;

            while(tmp.next.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = null;
            size--;
        }

        #endregion

        #region Nth Node

        public Node NthNodeFromStart(int n)
        {
            if(head == null)
            {
                return null;
            }

            int count = 1;
            Node tmp = head;

            while(count < n && tmp != null)
            {
                tmp = tmp.next;
                count++;
            }

            if(count == n)
            {
                return tmp;
            }

            return null;
        }

        public Node NthNodeFromEnd(int n)
        {
            if(head == null)
            {
                return null;
            }

            int count = 1;
            Node tmp = head;

            while(tmp != null && count < n)
            {
                tmp = tmp.next;
                count++;
            }

            if(tmp == null)
            {
                return null;
            }

            Node tmp2 = head;
            while(tmp.next != null)
            {
                tmp = tmp.next;
                tmp2 = tmp2.next;
            }

            return tmp2;
        }

        #endregion

        #region Middle Element

        public Node MiddleElement()
        {
            if(head == null)
            {
                return null;
            }

            if(head.next == null)
            {
                return head;
            }

            Node slowPtr = head;
            Node fastPtr = head;

            while(fastPtr != null && fastPtr.next != null)
            {
                fastPtr = fastPtr.next.next;
                slowPtr = slowPtr.next;
            }

            return slowPtr;
        }

        #endregion

        #region Loop

        public bool HasLoop()
        {
            Node slowPtr = head;
            Node fastPtr = head;

            while (fastPtr != null && fastPtr.next != null)
            {
                fastPtr = fastPtr.next.next;
                slowPtr = slowPtr.next;

                if (fastPtr == slowPtr)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Palindrome

        public bool IsPalindrome()
        {
            if(head == null)
            {
                return false;
            }

            if(head.next == null)
            {
                return true;
            }

            var stack = new Stack<int>();
            Node slowPtr = head;
            Node fastPtr = head;
            stack.Push(slowPtr.data);

            while (fastPtr != null && fastPtr.next != null)
            {
                fastPtr = fastPtr.next.next;
                slowPtr = slowPtr.next;
                stack.Push(slowPtr.data);
            }

            if(fastPtr == null)
            {
                stack.Pop();
            }

            while (stack.Count > 0)
            {
                var val = stack.Pop();
                if(val != slowPtr.data)
                {
                    return false;
                }
                slowPtr = slowPtr.next;
            }

            return true;
        }

        #endregion

        #region Duplicate

        public void RemoveAllDuplicates()
        {
            var set = new HashSet<int>();

            if(head == null || head.next == null)
            {
                return;
            }

            var tmp = head.next;
            var prev = head;
            set.Add(prev.data);

            while(tmp != null && prev != null)
            {
                if(set.Contains(tmp.data))
                {
                    prev.next = tmp.next;
                    size--;
                }
                else
                {
                    prev = prev.next;
                    set.Add(prev.data);
                }
                tmp = tmp.next;
            }
        }

        #endregion


    }

}
