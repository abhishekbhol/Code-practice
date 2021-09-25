using CodePractice.Leetcode;
using System;

namespace CodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var arr = new int[] { 4, 0, 1 };
            //var res  = MaxSumOfTwoNonOverlappingSubArrays.MaxSumTwoNoOverlap(arr, 2, 1);
            //Console.WriteLine(res);

            //var nums = new int[] { 1, 2, 2 };
            //var res = Powrset.SubsetsWithDup(nums);
            //foreach (var r in res)
            //{
            //    Console.WriteLine("[{0}]", string.Join(", ", r));
            //}

            var pairs = new int[3][];
            pairs[0] = new int[2] { 1, 2 };
            pairs[1] = new int[2] { 2, 3 };
            pairs[2] = new int[2] { 3, 4 };

            //pairs[0] = new int[2] { -6, 9};
            //pairs[1] = new int[2] { 1, 6 };
            //pairs[2] = new int[2] { 8, 10 };
            //pairs[3] = new int[2] { -1, 4 };
            //pairs[4] = new int[2] { -6 , -2 };
            //pairs[5] = new int[2] { -9, 8 };
            //pairs[6] = new int[2] { -5, 3 };
            //pairs[7] = new int[2] { 0, 3 };

            var res = MaxLengthPairChain.FindLongestChain(pairs);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
