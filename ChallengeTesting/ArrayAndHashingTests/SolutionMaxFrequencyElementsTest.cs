using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class SolutionMaxFrequencyElementsTest
{
    private readonly SolutionMaxFrequencyElements _solution
        = new SolutionMaxFrequencyElements();

    [Fact]
    public void MaxFrequencyElements_Returns_CaseOne()
    {
        int[] nums = { 1, 2, 2, 3, 1, 4 };

        var res = _solution.MaxFrequencyElements(nums);

        Assert.Equal(4, res);
    }

    [Fact]
    public void MaxFrequencyElements_Returns_CaseTwo()
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        var res = _solution.MaxFrequencyElements(nums);

        Assert.Equal(5, res);
    }

    [Fact]
    public void MaxFrequencyElements_Returns_CaseThere()
    {
        int[] nums = { 17, 17, 2, 12, 20, 17, 12 };

        var res = _solution.MaxFrequencyElements(nums);

        Assert.Equal(3, res);
    }
}