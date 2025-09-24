using ChallengeProblemSolution.Math;

namespace ChallengeTesting.MathTest;

public class SolutionCheckPerfectNumberTest
{
    private readonly SolutionCheckPerfectNumber _solution
    = new SolutionCheckPerfectNumber();

    [Fact]
    public void CheckPerfectNumber_Returns_CaseOne()
    {
        int num = 28;

        var res = _solution.CheckPerfectNumber(num);

        Assert.True(res);
    }

    [Fact]
    public void CheckPerfectNumber_Returns_CaseTwo()
    {
        int num = 7;

        var res = _solution.CheckPerfectNumber(num);

        Assert.True(res);
    }

    [Theory]
    [InlineData(7)]
    [InlineData(329)]
    [InlineData(3242)]
    public void CheckPerfectNumber_Returns_Cases(int num)
    {
        var res = _solution.CheckPerfectNumber(num);
        Assert.True(res);
    }
}