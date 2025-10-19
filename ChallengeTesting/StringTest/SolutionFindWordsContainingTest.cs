using ChallengeProblemSolution.String;

namespace ChallengeTesting.StringTest;

public class SolutionFindWordsContainingTest
{
    private readonly SolutionFindWordsContaining _solution
        = new SolutionFindWordsContaining();

    [Fact]
    public void FindWordsContaining_Returns_CaseOne()
    {
        var words = new string[] { "leet", "code" };
        char x = 'e';

        var res = _solution.FindWordsContaining(words, x);

        var exp = new List<int>() { 0, 1 };

        Assert.Equal(exp, res);
    }

    [Fact]
    public void FindWordsContaining_Returns_CaseTwo()
    {
        var words = new string[] { "abc", "bcd", "aaaa", "cbc" };
        char x = 'a';

        var res = _solution.FindWordsContaining(words, x);
        var exp = new List<int>() { 0, 2 };

        Assert.Equal(exp, res);
    }

    [Fact]
    public void FindWordsContaining_Returns_CaseThree()
    {
        var words = new string[] { "abc", "bcd", "aaaa", "cbc" };
        char x = 'z';

        var res = _solution.FindWordsContaining(words, x);
        var exp = new List<int>() { };

        Assert.Equal(exp, res);
    }
}