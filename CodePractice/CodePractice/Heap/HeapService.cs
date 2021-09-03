using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Heap
{
    public class MinHeap
    {
        public int[] heapArr;
        public int count;
        public int capacity;

        public MinHeap(int capacity)
        {
            this.capacity = capacity;
            heapArr = new int[capacity];
            count = 0;
        }

        public static void swap<T>(ref T val1, ref T val2)
        {
            T tmp = val1;
            val1 = val2;
            val2 = tmp;
        }

        public int Parent(int n)
        {
            return (n - 1) / 2;
        }

        public int Left(int n)
        {
            return 2 * n + 1;
        }

        public int Right(int n)
        {
            return 2 * n + 2;
        }

        public bool InsertKey(int key)
        {
            if (count == capacity)
                return false;

            int i = count;
            heapArr[i] = key;
            count++;

            while(heapArr[Parent(i)] > heapArr[i] && (i > 0))
            {
                swap(ref heapArr[i], ref heapArr[Parent(i)]);
                i = Parent(i);
            }
            return true;
        }

        public int ExtractMin()
        {
            if (count <= 0)
                return int.MaxValue;

            if(count == 1)
            {
                count--;
                return heapArr[0];
            }

            var root = heapArr[0];
            heapArr[0] = heapArr[count-1];
            count--;

            MinHeapify(0);

            return root;
        }

        private void MinHeapify(int key)
        {
            var left = Left(key);
            var right = Right(key);

            var smallest = key;

            if (left < count && heapArr[left] < heapArr[smallest])
                smallest = left;

            if (right < count && heapArr[right] < heapArr[smallest])
                smallest = right;

            if (smallest != key)
            {
                swap(ref heapArr[smallest], ref heapArr[key]);
                MinHeapify(smallest);
            }
        }
    }
}
