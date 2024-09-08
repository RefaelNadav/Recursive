using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Recursion
    {
        //exc1
        public static int Multiply(int a, int b)
        {
            if (b == 0 || a == 0)
                return 0;
            return Multiply(a, b - 1) + a;
        }

        //exc2
        public static int SumOfDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return SumOfDigits(n / 10) + n % 10;
        }

        //exc3
        public static int Power(int a, int b)
        {
            if(b == 0)
            {
                return 1;
            }
            return Power(a, b - 1) * a;
        }

        //exc4
        public static void Reversed(int num)
        {
            if (num == 0)
            {
                Console.WriteLine();
                return;
            }
            Console.Write((num % 10).ToString());
            Reversed(num / 10);
        }

        //exc5
        public static int FindSum(int[] ints, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return FindSum(ints, n - 1) + ints[n - 1];
        }

        //exc6
        public static int Divide(int a, int b)
        {
            if (a < b)
            {
                return 0;
            }
            return Divide(a - b, b) + 1;
        }

        //exc7
        /*public static bool IsPalindrome(string str)
        {
            if 
        }*/
    }
}
