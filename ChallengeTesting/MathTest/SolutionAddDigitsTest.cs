using ChallengeProblemSolution.Math;

namespace ChallengeTesting.MathTest;

public class SolutionAddDigitsTest
{
    private readonly SolutionAddDigits _solution = new SolutionAddDigits();

    [Fact]
    public void AddDigits_Returns_CaseOne()
    {
        int num = 38;

        var result = _solution.AddDigits(num);  

        Assert.Equal(2, result);
    }

    [Fact]
    public void AddDigits_Returns_CaseTwo()
    {
        int num = 44;

        var result = _solution.AddDigits(num);

        Assert.Equal(8, result);
    }

    [Fact]
    public void AddDigits_Returns_CaseThere()
    {
        int num = 10;

        var result = _solution.AddDigits(num);

        Assert.Equal(1, result);
    }
}