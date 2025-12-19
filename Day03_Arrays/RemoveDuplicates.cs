using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day03_Arrays
{
    public class RemoveDuplicates
    {
        public int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int writeIndex = 1;

            for (int readIndex = 1; readIndex < nums.Length; readIndex++)
            {
                if (nums[readIndex] != nums[readIndex - 1])
                {
                    nums[writeIndex] = nums[readIndex];
                    writeIndex++;
                }
            }

            return writeIndex;
        }
        
    }
}