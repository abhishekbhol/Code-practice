using CodePractice.Leetcode;
using System;

namespace CodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new int[] { 4, 0, 1 };

            var res  = MaxSumOfTwoNonOverlappingSubArrays.MaxSumTwoNoOverlap(arr, 2, 1);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
