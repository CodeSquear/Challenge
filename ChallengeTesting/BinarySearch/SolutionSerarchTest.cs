using ChallengeProblemSolution.BinarySearch;

namespace ChallengeTesting.BinarySearch;

public class SolutionSearchTest
{
    private readonly ProblemSearch _solution = new ProblemSearch();

    [Fact]
    public void Search_Returns_CaseOne()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        var target = 9;

        var res = _solution.Search(nums, target);

        Assert.Equal(4, res);
    }

    [Fact]
    public void Search_Returns_CaseTwo()
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        var target = 2;

        var res = _solution.Search(nums, target);

        Assert.Equal(-1, res);
    }
}