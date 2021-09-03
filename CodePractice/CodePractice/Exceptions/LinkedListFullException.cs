using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Exceptions
{
    public class LinkedListFullException : Exception
    {
        public LinkedListFullException()
        {
        }

        public LinkedListFullException(int capacity)
            : base($"Linked List is full. Capacity {capacity}")
        {
        }
    }
}
