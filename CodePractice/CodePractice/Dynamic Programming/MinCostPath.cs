using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Dynamic_Programming
{
    public class MinCostPath
    {
        public int MCP(int[,] arr, int m, int n)
        {
            int i, j;

            var dp = new int[m + 1, n + 1];

            dp[0, 0] = arr[0, 0];

            for(i=1; i<=m; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + arr[i, 0];
            }

            for (j = 1; j <= n; j++)
            {
                dp[0, j] = dp[0, j-1] + arr[0, j];
            }

            for (i=1; i<=m; i++)
            {
                for(j=1; j<=n; j++)
                {
                    dp[i, j] = arr[i, j] + Min(
                        dp[i-1, j],
                        dp[i, j-1],
                        dp[i-1, j-1]
                        );
                }
            }
            return dp[m, n];
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
