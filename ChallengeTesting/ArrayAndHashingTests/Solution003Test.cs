using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class Solution003Test
{
    private readonly Solution003 _solution = new Solution003();

    [Fact]
    public void TwoSum_Returns_CaseOne()
    {
        int[] nums = { 3, 4, 5, 6 };
        int target = 7;

        var res = _solution.TwoSum(nums, target);

        Assert.Equal([0,1] ,res);
    }

    [Fact]
    public void TwoSum_Returns_CaseTwo()
    {
        int[] nums = { 5, 5 };
        int target = 10;

        var res = _solution.TwoSum(nums, target);

        Assert.Equal([0,1] , res);
    }

    [Fact]
    public void TwoSum_Returns_CaseThere()
    {
        int[] nums = { 4, 5, 6 };
        int target = 11;

        var res = _solution.TwoSum(nums, target);

        Assert.Equal([1,2] , res);
    }
}