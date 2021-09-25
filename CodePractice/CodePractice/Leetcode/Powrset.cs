using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CodePractice.Leetcode
{
    public class Powrset
    {
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();

            var dict = new Dictionary<string, bool>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j <= nums.Length; j++)
                {
                    var subArray = nums.Skip(i).Take(j - i).ToArray();
                    var key = string.Join("", subArray); ;
                    if (!dict.ContainsKey(key))
                    {
                        dict.TryAdd(key, true);
                        res.Add(subArray);
                    }
                }
            }

            res.Add(nums.Take(0).ToArray());

            return res;
        }
    }
}
