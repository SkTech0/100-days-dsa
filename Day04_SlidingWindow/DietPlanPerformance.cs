using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day04_SlidingWindow
{
    public class DietPlanPerformance
    {
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            int sum = 0, score = 0;

            for (int i = 0; i < calories.Length; i++)
            {
                sum += calories[i];
                if (i >= k) sum -= calories[i - k];

                if (i >= k - 1)
                {
                    if (sum < lower) score--;
                    else if (sum > upper) score++;
                }
            }
            return score;
        }


    }
}