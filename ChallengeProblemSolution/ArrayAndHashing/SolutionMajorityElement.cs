namespace ChallengeProblemSolution.ArrayAndHashing;

public class SolutionMajorityElement
{
    public IList<int> MajorityElement(int[] nums)
    {
        int len = nums.Length / 3;
        var list = new List<int>();
        foreach (var item in GetDictionary(nums))
            if (item.Value > len)
                list.Add(item.Key);

        return list;
    }
    private Dictionary<int, int> GetDictionary(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
        return dict;
    }
}