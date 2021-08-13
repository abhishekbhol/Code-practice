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

        public LinkedList(int data)
        {
            head = new Node(data);
            size = 1;
        }

        #region Insertion

        public void InsertAtFirst(int data)
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

    }

}
