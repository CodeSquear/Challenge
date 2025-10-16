using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class SolutionMajorityElementTest
{
    private readonly SolutionMajorityElement _solution
        = new SolutionMajorityElement();

    [Fact]
    public void MajorityElement_Returns_CaseOne()
    {
        int[] nums = { 3, 2, 3 };
        int[] output = { 3 };

        var result = _solution.MajorityElement(nums);

        Assert.Equal(result , output);
    }

    [Fact]
    public void MajorityElement_Returns_CaseTwo()
    {
        int[] nums = { 1 };
        int[] output = { 1 };

        var result = _solution.MajorityElement(nums);

        Assert.Equal(result , output);
    }

    [Fact]
    public void MajorityElement_Returns_CaseThree()
    {
        int[] nums = { 1, 2 };
        int[] output = { 1, 2 };

        var reult = _solution.MajorityElement(nums);

        Assert.Equal(reult , output);
    }
}