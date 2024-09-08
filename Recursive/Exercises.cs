using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Exercises
    {
        public static int SumOdd(int[] arr)
        {
        //  1
            int sum = 0;
            //       n * 1
            for (int i = 0; i < arr.Length; i++)
            {
                //   n * 2
                if (arr[i] % 2 != 0)
                {
                    // n
                    sum += arr[i];
                }
            }
            // 1
            return sum;
        }

        public static int FindMaximumTwo(int[] arr)
        {
            //  1        1      1 1
            int maxSum = arr[0] + arr[1];
            //  1          n - 1               n
            for(int i = 1; i < arr.Length - 1 ;i++)
            {
                // n * 4
                int sum = arr[i] + arr[i+1];
                // n
                if (sum > maxSum)
                {
                    //n
                    maxSum = sum;
                }
            }
            // 1
            return maxSum;
        }

        public static int[] BobbleSort(int[] ints)
        {
            int temp = 0;

            for(int i = 0;i < ints.Length - 1;i++)
            {
                for(int j = 0; j < ints.Length -1 - i; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        temp = ints[j + 1];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }
            return ints;
        }
        
    }
}
