using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10_InterviewQuestions.OptimalSolution
{
    public class TwoSum
    {
        public int[] TwoSum_Optimal(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int needed = target - nums[i];

                if (map.ContainsKey(needed))
                {
                    return new int[] { map[needed], i };
                }

                // store current number with index
                map[nums[i]] = i;
            }

            return new int[0];
        }

    }
}