using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int MaxProfit(int[] prices)
            {
                if (prices.Length < 2) return 0;
                int maxProfit = 0;
                int lastPrice = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] > lastPrice)
                        maxProfit += prices[i] - lastPrice;
                    lastPrice = prices[i];

                }
                return maxProfit;
            }
            int removeDuplicates(int[] nums)
            {
                int index = 1;
                for(int i = 0; i < nums.Length - 1; i++)
                {
                    if(nums[i] != nums[i + 1])
                     {
                        nums[index++] = nums[i + 1];
                    }
                }

                return index;
            }
            int[]p = { 1, 1, 2 };

             int a = removeDuplicates(p);

            Console.WriteLine(a);

            int[] q = { 7, 1, 5, 3, 6, 4 };

            int q2a = MaxProfit(q);

            Console.WriteLine(q2a);
        }
    }
}
