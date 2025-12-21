// =====================================================
// DSA PATTERN TEMPLATES - C#
// Purpose:
// - Interview preparation
// - Pattern recognition
// - Fast problem solving
//
// Key Idea:
// Do NOT memorize solutions.
// Understand patterns → adapt templates.
// =====================================================

using System;
using System.Collections.Generic;
using System.Linq;
namespace Day05_Patterns
{
    public class DSAPatternTemplates
    {
        // =====================================================
        // PATTERN 1: SLIDING WINDOW (Variable Size)
        // =====================================================
        /*
         * Used when:
         * - Subarray / substring problems
         * - Contiguous elements
         * - Longest / shortest / count conditions
         *
         * Core idea:
         * Expand window with 'right'
         * Shrink window with 'left' when condition breaks
         */
        public static int SlidingWindowTemplate(int[] nums)
        {
            int left = 0;                 // Left boundary of window
            int result = 0;               // Stores final answer
            Dictionary<int, int> freq = new Dictionary<int, int>(); // Tracks window state

            for (int right = 0; right < nums.Length; right++)
            {
                // Expand window: include nums[right]
                if (!freq.ContainsKey(nums[right]))
                    freq[nums[right]] = 0;
                freq[nums[right]]++;

                // Shrink window if condition is violated
                while (/* condition_not_met */ false)
                {
                    freq[nums[left]]--;
                    if (freq[nums[left]] == 0)
                        freq.Remove(nums[left]);
                    left++; // shrink window
                }

                // Update answer based on current window
                result = Math.Max(result, right - left + 1);
            }

            return result;
        }

        // =====================================================
        // PATTERN 2: TWO POINTERS
        // =====================================================
        /*
         * Used when:
         * - Array is sorted
         * - Pair / triplet problems
         * - Shrinking from both ends
         */
        public static void TwoPointersTemplate(int[] nums)
        {
            int left = 0;                 // Start pointer
            int right = nums.Length - 1;  // End pointer

            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == 0)
                {
                    // Found required pair
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    // Need bigger value → move left
                    left++;
                }
                else
                {
                    // Need smaller value → move right
                    right--;
                }
            }
        }

        // =====================================================
        // PATTERN 3: FAST & SLOW POINTERS (Cycle Detection)
        // =====================================================
        /*
         * Used when:
         * - Linked list cycle
         * - Middle of linked list
         * - Happy number
         *
         * Key logic:
         * Fast moves 2 steps, slow moves 1 step
         */
        public static bool FastSlowPointerTemplate(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;           // 1 step
                fast = fast.next.next;      // 2 steps

                if (slow == fast)
                    return true;            // Cycle detected
            }

            return false;
        }

        // =====================================================
        // PATTERN 4: PREFIX SUM + HASHMAP
        // =====================================================
        /*
         * Used when:
         * - Subarray sum problems
         * - Range sum
         * - Count of subarrays
         *
         * Trick:
         * prefix[j] - prefix[i] = k
         */
        public static int PrefixSumTemplate(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;                 // Base case: prefix sum = 0

            int prefixSum = 0;
            int count = 0;

            foreach (int num in nums)
            {
                prefixSum += num;

                // Check if required sum exists before
                if (map.ContainsKey(prefixSum - k))
                    count += map[prefixSum - k];

                // Store current prefix sum
                if (!map.ContainsKey(prefixSum))
                    map[prefixSum] = 0;
                map[prefixSum]++;
            }

            return count;
        }

        // =====================================================
        // PATTERN 5: HASHING (MAP / SET)
        // =====================================================
        /*
         * Used when:
         * - Frequency count
         * - Uniqueness
         * - Mapping relationships
         */
        public static void HashingTemplate(int[] nums)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 0;

                freq[num]++;
            }

            // Example usage
            foreach (var pair in freq)
            {
                Console.WriteLine($"Value {pair.Key} occurs {pair.Value} times");
            }
        }

        // =====================================================
        // PATTERN 6: SORTING + GREEDY
        // =====================================================
        /*
         * Used when:
         * - Interval problems
         * - Scheduling
         * - Minimum / maximum decisions
         *
         * Rule:
         * Sort first → make greedy choice
         */
        public static void SortingGreedyTemplate(int[] nums)
        {
            Array.Sort(nums);            // Sorting is mandatory

            int count = 0;

            foreach (int num in nums)
            {
                if (/* canTake(num) */ true)
                {
                    count++;             // Greedy decision
                }
            }
        }

        // =====================================================
        // PATTERN 7: GREEDY (Kadane / Jump / Gas Station)
        // =====================================================
        /*
         * Used when:
         * - Maximum / minimum optimization
         * - Decisions affect future
         */
        public static int GreedyTemplate(int[] nums)
        {
            int current = 0;             // Local best
            int best = int.MinValue;     // Global best

            foreach (int num in nums)
            {
                // Either start fresh OR continue
                current = Math.Max(num, current + num);
                best = Math.Max(best, current);
            }

            return best;
        }
    }

    // =====================================================
    // Supporting Linked List Node
    // =====================================================
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int value)
        {
            val = value;
            next = null;
        }
    }
}