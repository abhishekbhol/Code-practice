using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Leetcode
{
    public class MaxSumOfTwoNonOverlappingSubArrays
    {
        public static int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
        {
            if(secondLen > firstLen)
            {
                int tmp = firstLen;
                firstLen = secondLen;
                secondLen = tmp;
            }

            var arrLen = nums.Length;
            int i = 0;
            int j = firstLen - 1;

            int k = 0;
            int localSum = 0;
            int firstSum = 0;
            int secSum = 0;

            while (k < firstLen)
            {
                localSum += nums[k];
                k++;
            }
            firstSum = localSum;

            while (k < arrLen)
            {
                localSum += nums[k];
                localSum -= nums[k - firstLen];

                if (localSum > firstSum)
                {
                    firstSum = localSum;
                    i = k - firstLen + 1;
                    j = k;
                }
                k++;
            }

            int m = 0;
            int n = 0;
            localSum = 0;

            if (i >= secondLen)
            {
                n = secondLen - 1;
                k = 0;
                while (k < secondLen)
                {
                    localSum += nums[k];
                    k++;
                }
                secSum = localSum;

                while (k < i)
                {
                    localSum += nums[k];
                    localSum -= nums[k - secondLen];

                    if (localSum > secSum)
                    {
                        secSum = localSum;
                        m = k - secondLen + 1;
                        n = k;
                    }
                    k++;
                }
            }

            localSum = 0;
            if (secondLen + j < arrLen)
            {
                k = 0;
                m = j + 1;
                n = j + secondLen + 1;

                while (k < secondLen)
                {
                    localSum += nums[k + j + 1];
                    k++;
                }
                if (localSum > secSum)
                {
                    secSum = localSum;
                }

                while (j + k < arrLen - 1)
                {
                    localSum += nums[j + k + 1];
                    localSum -= nums[j + k - secondLen + 1];

                    if (localSum > secSum)
                    {
                        secSum = localSum;
                        m = k - secondLen + 1;
                        n = k;
                    }
                    k++;
                }
            }

            return firstSum + secSum;

        }
    }
}
