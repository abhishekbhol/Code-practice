using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Dynamic_Programming
{
    public class LIS
    {
        public static int longestIncreasingSequence(int[] arr, int n)
        {
            var lis = new int[n+1];
            int i, j, max = 0;

            for(i = 0; i<n; i++)
            {
                lis[i] = 1;
            }

            for(i=1; i<n; i++)
            {
                for(j=0; j<i; j++)
                {
                    if(arr[i] > arr[j] && lis[i] < lis[j] + 1)
                    {
                        lis[i] = lis[j] + 1;
                    }
                }
            }

            for(i=0; i<n; i++)
            {
                if (lis[i] > max)
                    max = lis[i];
            }
            return max;
        }
    }
}
