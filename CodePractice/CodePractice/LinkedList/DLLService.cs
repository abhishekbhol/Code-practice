using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.LinkedList
{
    public class DLLService
    {
        public static DoublyNode RemoveDuplicates(DoublyNode head)
        {
            var set = new HashSet<int>();

            if (head == null || head.next == null)
            {
                return head;
            }

            var tmp = head;

            while(tmp != null)
            {
                if(set.Contains(tmp.data))
                {
                    var tmp2 = tmp;
                    tmp.prev.next = tmp.next;
                    if(tmp.next != null)
                        tmp.next.prev = tmp.prev;
                    tmp = tmp.next;
                    tmp2.next = tmp2.prev = null;
                }
                else
                {
                    set.Add(tmp.data);
                    tmp = tmp.next;
                }
            }

            return head;
        }

        public static DoublyNode Rotate(DoublyNode head, int n)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            //make the DLL a circular DLL

            var tmp = head;

            while(tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = head;
            head.prev = tmp;

            // rotate k times and make the Kth node as head

            tmp = head;
            int k = 0;

            while(k < n)
            {
                tmp = tmp.next;
                k++;
            }

            tmp.prev.next = null;
            tmp.prev = null;

            head = tmp;

            return head;
        }

        public static DoublyNode CopyWithRamdomPointers(DoublyNode head)
        {
            var tmp1 = head;
            DoublyNode head2;

            // insert new node after the original node
            while (tmp1 != null)
            {
                var newNode = new DoublyNode(tmp1.data);

                newNode.prev = tmp1;
                newNode.next = tmp1.next;

                //if(tmp1.next != null)
                //    tmp1.next.prev = newNode;

                tmp1.next = newNode;

                tmp1 = newNode.next;
            }

            //update the prev pointer of new list
            tmp1 = head;

            while(tmp1 != null)
            {
                tmp1.next.prev = tmp1.prev.next;

                tmp1 = tmp1.next.next;
            }

            //separate the two lists
            head2 = head.next;

            tmp1 = head;
            DoublyNode tmp2 = head2;

            while( tmp1 != null && tmp2 != null)
            {
                tmp1.next = tmp2.next;

                if (tmp2.next != null)
                {
                    tmp2.next = tmp2.next.next;
                }

                tmp1 = tmp1.next;
                tmp2 = tmp2.next;
            }


            return head2;
        }
    }
}
