using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.LinkedList
{
    public class LLService
    {

        #region Reverse

        public static Node Reverse(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            Node left = null;
            Node Curr = head;
            Node right = head.next;

            while (right != null)
            {
                Curr.next = left;
                left = Curr;
                Curr = right;
                right = right.next;
            }
            Curr.next = left;

            head = Curr;
            return head;
        }

        public static Node ReverseInGroup(Node root, int k)
        {
            if (root == null)
                return null;

            Node current = root;
            Node prev = null;
            Node next = null;

            int count = 0;

            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }

            if (next != null)
                root.next = ReverseInGroup(next, k);

            return prev;
        }

        #endregion

        #region Addition
        public Node Add(Node head1, Node head2)
        {
            var rev1 = Reverse(head1);
            var rev2 = Reverse(head2);

            int carry = 0;
            int sum = 0;

            Node tmp = null;
            Node res = null;
            Node prev = null;

            while (rev1 != null || rev2 != null)
            {
                sum = (rev1 != null ? rev1.data : 0) + (rev2 != null ? rev2.data : 0) + carry;
                carry = sum > 10 ? 1 : 0;

                sum = sum % 10;
                tmp = new Node(sum);

                if (res == null)
                {
                    res = tmp;
                }
                else
                {
                    prev.next = tmp;
                }

                prev = tmp;

                if (rev1 != null)
                {
                    rev1 = rev1.next;
                }

                if (rev2 != null)
                {
                    rev2 = rev2.next;
                }
            }

            if (carry > 0)
            {
                tmp.next = new Node(carry);
            }

            return Reverse(res);
        }

        #endregion

    }
}
