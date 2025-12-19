using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day03_Arrays
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (left < right && !Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (left < right && !Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }
        }
        
    }
}