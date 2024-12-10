﻿/*
* Name: Vishwaja Painjane
* email: painjavv@mail.uc.edu
* Assignment Number: Final Group Project
* Due Date: Tuesday, December 10th, 2024
* Course #/Section: IS3050-001
* Semester/Year: Fall 2024
* Brief Description of the assignment: This is our final group assignment. We had to solve one leetcode problem each.
* Brief Description of what this module does: This is a final group project
* Citations: Used Leetcode.com for the problem and ChatGPT for the solution.
* Anything else that's relevant: N/A
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pilot_run
{
    public class Class1
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Replace all values <= 0 or greater than n with a number outside the valid range (n + 1)
            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 || nums[i] > n)
                {
                    nums[i] = n + 1;
                }
            }

            // Step 2: Use the index to mark the presence of numbers
            for (int i = 0; i < n; i++)
            {
                int num = Math.Abs(nums[i]);
                if (num <= n)
                {
                    if (nums[num - 1] > 0)
                    {
                        nums[num - 1] = -nums[num - 1];
                    }
                }
            }

            // Step 3: The first index with a positive value is the missing number
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1;  // The missing number is i + 1
                }
            }

            return n + 1;  // If no number is missing, return n + 1
        }
    }
}