using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day03_Arrays
{
    public class ReverseString
    {
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }


    }
}