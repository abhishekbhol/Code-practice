using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Dynamic_Programming
{
    public class Knapsack
    {
        public int ZeroOneKnapsack(int[] val, int[] wt, int w)
        {
            int i, j;
            var n = val.Length;
            var dp = new int[n + 1, w + 1];

            for(i=0; i<=n; i++)
            {
                for(j=0; j<=w; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;
                    else if (wt[i - 1] <= j)
                    {
                        dp[i, j] = Math.Max(
                            val[i - 1] + dp[i - 1, j - wt[i - 1]],
                            dp[i - 1, j]
                            );
                    }
                    else
                        dp[i, j] = dp[i - 1, j];
                }
            }
            return dp[n, w];
        }

        private int Min(int x, int y, int z)
        {
            if (x < y)
                return ((x < z) ? x : z);
            else
                return ((y < z) ? y : z);
        }
    }
}
