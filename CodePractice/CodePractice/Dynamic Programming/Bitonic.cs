using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Dynamic_Programming
{
    public class Bitonic
    {
        public static int BitonicSequence(int[] arr, int n)
        {
            var inc = new int[n+  1];
            var dec = new int[n + 1];
            int i, j, max = 0;

            for(i = 0; i<n; i++)
            {
                inc[i] = 1;
                dec[i] = 1;
            }

            for(i=1; i<n; i++)
            {
                for(j=0; j<i; j++)
                {
                    if(arr[i] > arr[j] && inc[i] < inc[j] + 1)
                    {
                        inc[i] = inc[j] + 1;
                    }
                }
            }

            for (i = n-2; i >= 0; i--)
            {
                for (j = n-1; j > i; j--)
                {
                    if (arr[i] > arr[j] && dec[i] < dec[j] + 1)
                    {
                        dec[i] = dec[j] + 1;
                    }
                }
            }

            for (i=0; i<n; i++)
            {
                if (inc[i] + dec[i] - 1 > max)
                    max = inc[i] + dec[i] - 1;
            }
            return max;
        }
    }
}
