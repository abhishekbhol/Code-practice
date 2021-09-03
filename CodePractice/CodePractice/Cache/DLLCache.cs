using CodePractice.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Cache
{

    public class DoublyNodeCache
    {
        public string key;
        public object value;
        public DoublyNodeCache next;
        public DoublyNodeCache prev;

        public DoublyNodeCache(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.next = this.prev = null;
        }
    }

    public class DLLCache
    {
        public DoublyNodeCache head;
        public DoublyNodeCache tail;
        public int capacity;
        public volatile int count;

        public DLLCache(int capacity)
        {
            head = null;
            tail = null;
            this.capacity = capacity;
        }

        public int Length()
        {
            int len = 0;
            var tmp = head;
            while (tmp != null)
            {
                tmp = tmp.next;
                len++;
            }
            return len;
        }

        public void InsertAtStart(string key, object data)
        {
            if (count == capacity)
            {
                throw new LinkedListFullException(capacity);
            }

            var newNode = new DoublyNodeCache(key, data);
            if (head == null)
            {
                tail = head = newNode;
                count++;
                return;
            }

            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            count++;
        }

        #region Deletion

        public void DeleteNode(DoublyNodeCache node)
        {
            if(node.prev != null)
                node.prev.next = node.next;

            if(node.next != null)
                node.next.prev = node.prev;

            node.next = node.prev = null;

            if (head == node)
                head = head.next;

            if (tail == node)
                tail = tail.prev;

            count--;
        }

        public void DeleteFromStart()
        {
            if (head == null)
            {
                return;
            }
            if (head.next == null)
            {
                tail = head = null;
                count--;
                return;
            }

            head.next.prev = null;
            head = head.next;
            count--;
        }

        public void DeleteFromEnd()
        {
            if (head == null)
            {
                return;
            }
            if (head.next == null)
            {
                tail = head = null;
                count--;
                return;
            }

            var tmp = tail;
            tail = tail.prev;

            tail.next = null;
            tmp.prev = null;
            count--;
        }

        #endregion

    }
}
