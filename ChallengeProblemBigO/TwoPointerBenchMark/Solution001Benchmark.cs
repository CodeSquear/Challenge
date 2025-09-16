using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.TwoPointer;

namespace ChallengeProblemBigO.TwoPointerBenchMark;

[MemoryDiagnoser]
[ShortRunJob]
public class Solution001Benchmark
{
    private readonly Solution001 _solution = new Solution001();
    private string smallString;
    private string middleString;
    private string largeString;

    [GlobalSetup]
    public void Setup()
    {
        smallString = "madam"; 
        middleString = "racecarannakayakracecar"; 
        largeString = new string('a', 10000) + "b" + new string('a', 10000);
    }

    [Benchmark]
    public bool SmallString()
        => _solution.IsPalindrome(smallString);

    [Benchmark]
    public bool MiddleString()
        => _solution.IsPalindrome(middleString);

    [Benchmark]
    public bool LargeString()
        => _solution.IsPalindrome(largeString);
}