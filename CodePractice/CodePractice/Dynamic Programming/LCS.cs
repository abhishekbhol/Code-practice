using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Dynamic_Programming
{
    public class LCS
    {
        public static int LongestCommonSubsequence(String str1, String str2)
        {
            int m = str1.Length;
            int n = str2.Length;
            var dp = new int[m+1, n+1];

            for(int i=0; i<=m; i++)
            {
                for(int j=0; j<=n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }                    
                    else if(str1[i-1] == str2[j-1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }

        static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
