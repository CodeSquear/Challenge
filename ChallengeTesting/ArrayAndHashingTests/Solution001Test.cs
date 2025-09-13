using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class Solution001Test
{
    private readonly Solution001 _solution = new Solution001();

    [Fact]
    public void HasDuplicate_Return_CaseOne()
    {
        int[] nums = { 1, 2, 3, 3 };

        var res = _solution.hasDuplicate(nums);

        Assert.True(res);
    }

    [Fact]
    public void HasDuplicate_Returns_CaseTwo()
    {
        int[] nums = { 1, 2, 3, 4 };

        var res = _solution.hasDuplicate(nums);

        Assert.True(res);
    }
}