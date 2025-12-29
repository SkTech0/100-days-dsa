using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_10_InterviewQuestions.BruteForce
{
    public class TwoSum
    {
        public int[] TwoSum_BruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0]; // never reached as solution always exists
        }


    }
}