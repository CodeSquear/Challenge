using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.Math;

namespace ChallengeProblemBigO.Math;

[MemoryDiagnoser]
[ShortRunJob]
public class SolutionCheckPerfectNumberBenchmark
{
    private readonly SolutionCheckPerfectNumber _solution
        = new SolutionCheckPerfectNumber();

    private readonly Random _random = new Random();

    private int smallNum;
    private int bigNum;
    private int largeNum;

    [GlobalSetup]
    public void Setup()
    {
        smallNum = _random.Next(1, 10);
        bigNum = _random.Next(1, 1_000);
        largeNum = _random.Next(1, 10_0000);
    }

    [Benchmark]
    public bool SmallNumber()
        => _solution.CheckPerfectNumber(smallNum);

    [Benchmark]
    public bool BigNumber()
        => _solution.CheckPerfectNumber(bigNum);

    [Benchmark]
    public bool LargeNumber()
        => _solution.CheckPerfectNumber(largeNum);
}