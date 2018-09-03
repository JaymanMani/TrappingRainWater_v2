using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bars = new int[] { 3,0,0,2,0,4 };
            Console.WriteLine(FindWater(bars,bars.Length));
            Console.Read();
        }

        static int FindWater(int[] arr, int n)
        {
            int result = 0;

            int lo = 0, hi = n - 1;
            int leftMax = 0, rightMax = 0;

            while (lo <= hi)
            {
                if (arr[lo] < arr[hi])
                {
                    if (arr[lo] > leftMax)
                    {
                        leftMax = arr[lo];
                    }
                    else
                    {
                        result += leftMax - arr[lo];
                    }
                    lo++;
                }
                else
                {
                    if (arr[hi] > rightMax)
                    {
                        rightMax = arr[hi];
                    }
                    else
                    {
                        result += rightMax - arr[hi];
                    }
                    hi--;
                }
            }

            return result;
        }
    }
}
