using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day03_Arrays
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return new int[] { -1, -1 }; // Return an invalid index if no solution is found
        }
        
    }
}