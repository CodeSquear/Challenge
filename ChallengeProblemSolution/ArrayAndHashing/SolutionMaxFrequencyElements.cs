namespace ChallengeProblemSolution.ArrayAndHashing;

public class SolutionMaxFrequencyElements
{
    public int MaxFrequencyElements(int[] nums)
    {
        var dict = GetDict(nums);
        int maxFreq = dict.Values.Max(), count = 0;


        foreach(var item in dict)
            if (item.Value == maxFreq)
                count += item.Value;

        return count;
    }

    private Dictionary<int, int> GetDict(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
        return dict;
    }
}