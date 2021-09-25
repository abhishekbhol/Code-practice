using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Dynamic_Programming
{
    public class Fibonacci
    {
        static int MAX = 100;
        static int NIL = -1;
        static int[] lookup = new int[MAX];

        public int Tabulation(int n)
        {
            var f = new int[n+1];

            for(int i=0; i<=n; i++)
            {
                if(i <= 1)
                {
                    f[i] = i;
                }
                else
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
            }
            return f[n];
        }

        public static void Initialize()
        {
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }

        public int Memoization(int n)
        {
            if(lookup[n] == NIL)
            {
                if(n <= 1)
                {
                    lookup[n] = n;
                }
                else
                {
                    lookup[n] = Memoization(n - 1) + Memoization(n - 2);
                }
            }
            return lookup[n];
        }
    }
}
