using ChallengeProblemSolution.TwoPointer;

namespace ChallengeTesting.TwoPointerTests;

public class Solution001Test
{
    private readonly Solution001 _solution = new Solution001();

    [Fact]
    public void IsPalindrome_Return_CaseOne()
    {
        var s = "Was it a car or a cat I saw?";

        var res = _solution.IsPalindrome(s);

        Assert.True(res);
    }

    [Fact]
    public void IsPalindrome_Return_CaseTwo()
    {
        var s = "tab a cat";

        var res = _solution.IsPalindrome(s);

        Assert.True(res);
    }

    [Fact]
    public void IsPalindrome_Return_CaseThere()
    {
        var s = "the cat in out";

        var res = _solution.IsPalindrome(s);

        Assert.True(res);
    }
}