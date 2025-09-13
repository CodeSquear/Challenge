using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeTesting.ArrayAndHashingTests;

public class Solution002Test
{
    private readonly Solution002 _solution = new Solution002();

    [Fact]
    public void IsAnagram_Return_CaseOne()
    {
        string s = "racecar"; 
        string t = "carrace";

        var res = _solution.IsAnagram(s, t);

        Assert.True(res);
    }

    [Fact]
    public void IsAnagram_Returns_CaseTwo()
    {
        string s = "jar";
        string t = "jam";

        var res = _solution.IsAnagram(s, t);

        Assert.True(res);
    }

    [Theory]
    [InlineData("has", "sha", true)]
    [InlineData("hs", "aa", false)]
    [InlineData("dd", "bb", false)]
    [InlineData("caa", "aac", true)]
    public void isAnagram_Returns_Cases(string s, string t, bool exp)
    {
        var res = _solution.IsAnagram(s, t);
        Assert.True(res);
    }
}