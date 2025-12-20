using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day04_SlidingWindow
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums[0], curr = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                curr = Math.Max(nums[i], curr + nums[i]);
                maxSoFar = Math.Max(maxSoFar, curr);
            }
            return maxSoFar;
        }


    }
}