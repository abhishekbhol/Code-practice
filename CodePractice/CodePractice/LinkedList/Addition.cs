using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.LinkedList
{
    public class Addition
    {
        public Node Add(Node head1, Node head2)
        {
            var ll = new LinkedList();
            var rev1 = ll.Reverse(head1);
            var rev2 = ll.Reverse(head2);

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

            return ll.Reverse(res);
        }

    }
}
