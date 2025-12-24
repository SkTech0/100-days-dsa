using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day08_Dictionary
{
    public class MostFrequentEvenElement
    {
        public int MostFrequentEven(int[] nums)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            // Step 1: Count only even numbers
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    freq[num] = freq.GetValueOrDefault(num, 0) + 1;
            }

            // Step 2: Find max frequency with smallest value tie-break
            int result = -1;
            int maxFreq = 0;

            foreach (var kvp in freq)
            {
                int value = kvp.Key;
                int count = kvp.Value;

                if (count > maxFreq || (count == maxFreq && value < result))
                {
                    maxFreq = count;
                    result = value;
                }
            }

            return result;
        }


    }
}