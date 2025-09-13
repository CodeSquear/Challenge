namespace ChallengeProblemSolution.ArrayAndHashing;

public class Solution001
{
    public bool hasDuplicate(int[] nums)
        => new HashSet<int>(nums).Count != nums.Length;
}