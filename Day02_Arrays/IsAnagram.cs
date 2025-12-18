using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02_Arrays
{
    public class IsAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            // foreach (char c in s)
            // map[c] = map.GetValueOrDefault(c, 0) + 1;
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c))
                    return false;
                charCount[c]--;
                if (charCount[c] < 0)
                    return false;
            }
        }

        public bool ValidAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] count = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }

            foreach (int c in count)
            {
                if (c != 0) return false;
            }

            return true;
        }
    }
}