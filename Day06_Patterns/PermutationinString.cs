using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day06_Patterns
{
    public class PermutationinString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int[] cnt = new int[26];
            foreach (char c in s1) cnt[c - 'a']++;

            int left = 0;
            for (int right = 0; right < s2.Length; right++)
            {
                cnt[s2[right] - 'a']--;
                if (right - left + 1 > s1.Length)
                    cnt[s2[left++] - 'a']++;

                if (cnt.All(x => x == 0)) return true;
            }
            return false;
        }


    }
}