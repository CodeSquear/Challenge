using ChallengeProblemSolution.LinkedList._001;
using ChallengeTesting.LinkedListTests.Helper;

namespace ChallengeTesting.LinkedListTests;

public class Solution001Tests
{
    [Fact]
    public void ReverseList_Input_0_1_2_3_Returns_3_2_1_0()
    {
        // Arrange
        var input = ListNodeHelper.FromList(new List<int> { 0, 1, 2, 3 });
        var expected = new List<int> { 3, 2, 1, 0 };
        var solution = new Solution001();

        // Act
        var result = solution.ReverseList(input);
        var resultList = ListNodeHelper.ToList(result);

        // Assert
        Assert.Equal(expected, resultList);
    }

    [Fact]
    public void ReverseList_Input_Empty_Returns_Empty()
    {
        // Arrange
        var solution = new Solution001();

        // Act
        var result = solution.ReverseList(null);
        var resultList = ListNodeHelper.ToList(result);

        // Assert
        Assert.Empty(resultList);
    }
}