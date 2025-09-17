using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class SolutionTransformArrayTest
{
    private readonly SolutionTransformArray _solution = new SolutionTransformArray();

    [Fact]
    public void TransformArray_Returns_CaseOne()
    {
        int[] nums = { 4, 3, 2, 1 };

        var res = _solution.TransformArray(nums);

        Assert.Equal([0, 0, 1, 1], res);
    }

    [Fact]
    public void TransformArray_Returns_CaseTwo()
    {
        int[] nums = { 1, 5, 1, 4, 2 };

        var res = _solution.TransformArray(nums);

        Assert.Equal([0, 0, 1, 1, 1] , res);
    }
}