using ChallengeProblemSolution.Math;

namespace ChallengeTesting.MathTest;

public class SolutionMinimumSumTest
{
    private readonly SolutionMinimumSum _solution = new SolutionMinimumSum();

    [Fact]
    public void MinimumSum_Returns_CaseOne()
    {
        int num = 2932;

        var res = _solution.MinimumSum(num);

        Assert.Equal(52, res);
    }

    [Fact]
    public void MinimumSum_Returns_CaseTwo()
    {
        int num = 4009;

        var res = _solution.MinimumSum(num);

        Assert.Equal(13, res);
    }
}