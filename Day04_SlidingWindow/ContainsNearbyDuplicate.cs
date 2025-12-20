using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day04_SlidingWindow
{
    public class ContainsNearbyDuplicate
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) return true;

                set.Add(nums[i]);
                if (set.Count > k) set.Remove(nums[i - k]);
            }
            return false;
        }


    }
}