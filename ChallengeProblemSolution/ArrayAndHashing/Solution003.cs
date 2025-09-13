﻿namespace ChallengeProblemSolution.ArrayAndHashing;

public class Solution003
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var temp = target - nums[i];

            if (dict.ContainsKey(temp))
                return new int[] { dict[temp], i };

            dict[nums[i]] = i;
        }

        return null;
    }
}