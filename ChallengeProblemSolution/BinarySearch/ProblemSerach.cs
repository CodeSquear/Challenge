namespace ChallengeProblemSolution.BinarySearch;

public class ProblemSearch
{
    public int Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int midd = (left + right) / 2;

            if (nums[midd] == target) return midd;

            if (nums[midd] < target) left++;
            else right--;
        }

        return -1;
    }
}