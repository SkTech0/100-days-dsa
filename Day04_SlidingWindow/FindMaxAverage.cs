using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day04_SlidingWindow
{
    public class FindMaxAverage
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++) sum += nums[i];

            int maxSum = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, sum);
            }
            return (double)maxSum / k;
        }


    }
}