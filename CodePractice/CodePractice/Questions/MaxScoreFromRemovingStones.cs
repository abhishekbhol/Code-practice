using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Questions
{
    public class MaxScoreFromRemovingStones
    {
        public int MaximumScore(int a, int b, int c)
        {
            int ans = 0;

            while (ContinueGame(a, b, c))
            {
                int min = a;
                int max = a;

                if (a > b)
                {
                    if (a > c)
                        a--;
                    else
                        c--;

                    if (b > c && c > 0)
                        c--;
                    else
                        b--;
                }
                else
                {
                    if (b > c)
                        b--;
                    else
                        c--;

                    if (a > c && c > 0)
                        c--;
                    else
                        a--;
                }
                ans++;
            }
            return ans;
        }

        public bool ContinueGame(int a, int b, int c)
        {
            int res = 0;
            if (a > 0)
                res++;
            if (b > 0)
                res++;
            if (c > 0)
                res++;

            return (res > 1);
        }
    }
}
