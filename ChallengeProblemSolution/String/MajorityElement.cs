namespace ChallengeProblemSolution.String;

public class MajorityElement
{
    public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        var majorityCount = nums.Length / 2;
        foreach (var kvp in dict)
        {
            if (kvp.Value > majorityCount)
                return kvp.Key;
        }

        return 0;
    }
}
