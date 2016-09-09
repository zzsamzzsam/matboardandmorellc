using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockmarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100 180 695 260 310 40 535
            do
            {
                stuff();
                Console.WriteLine("\nPress 'y' to exit.");
            } while (Console.ReadKey().Key != ConsoleKey.Y);

        }

        static void stuff()
        {
            Console.WriteLine("\nInput a space seperated list of numbers:");
            String numline = Console.ReadLine();

            int[] nums = stringToIntArrays(numline.Split(' '));

            int min = nums.Max();
            int maxProfit = 0;
            int byAt = -1;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num < min)
                {
                    min = num;

                    int[] sub = nums.Skip(i).ToArray();
                    int tempMax = sub.Max();
                    int profit = tempMax - num;
                    if (profit > maxProfit)
                    {
                        max = tempMax;
                        maxProfit = profit;
                        byAt = i;
                    }
                }
            }

            if (byAt == -1)
            {
                Console.WriteLine("No profit to be made.");
            }
            else
            {
                Console.WriteLine("Profit made: {0} | Buy day{1} | Sell day{2}", maxProfit, byAt, Array.IndexOf(nums, max));
            }
        }

        static int[] stringToIntArrays(String[] x)
        {
            int l = x.Length;
            int[] ret = new int[l];
            for (int i = 0; i < l; i++)
            {
                ret[i] = Convert.ToInt32(x[i]);
            }

            return ret;
        }
    }
}
