using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Leetcode
{
    public class MaxLengthPairChain
    {
        public static int FindLongestChain(int[][] pairs)
        {
            Sort<int>(pairs, 1);
            //Sort<int>(pairs, 0);

            var len = pairs.GetLength(0);
            int count = 1;

            int i = 0;
            int j = 1;
            while (i < len && j < len)
            {
                if (pairs[i][1] < pairs[j][0])
                {
                    count++;
                    i = j;
                }
                j++;

            }
            return count;
        }

        private static void Sort<T>(T[][] data, int col)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            System.Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
        }
    }
}
