using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_09_Sliding_Window
{
    public class SubarrayswithKDifferentIntegers
    {
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            return AtMost(nums, k) - AtMost(nums, k - 1);
        }

        private int AtMost(int[] nums, int k)
        {
            Dictionary<int, int> map = new();
            int left = 0, res = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (!map.ContainsKey(nums[right])) k--;
                map[nums[right]] = map.GetValueOrDefault(nums[right]) + 1;

                while (k < 0)
                {
                    map[nums[left]]--;
                    if (map[nums[left]] == 0) k++;
                    left++;
                }
                res += right - left + 1;
            }
            return res;
        }


    }
}