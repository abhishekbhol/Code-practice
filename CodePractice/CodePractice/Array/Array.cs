using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Array
{
    public class ArrayService
    {
        public static void ArrangePositiveAndNegativeArray(int[] arr, int n)
        {
            var i = 0;
            var j = n - 1;

            while( i < j)
            {
                while (arr[i] < 0 && i < j)
                {
                    i++;
                }
                while (arr[j] > 0 && i < j)
                {
                    j--;
                }

                var tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
    }
}
