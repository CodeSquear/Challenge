using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.Math;

namespace ChallengeProblemBigO.Math;

[MemoryDiagnoser]
[ShortRunJob]
public class SolutionMinimumSumTestBenchmark
{
    private readonly SolutionMinimumSum _solution = new SolutionMinimumSum();
    private readonly Random _random = new Random();

    private int first;
    private int second;
    private int last;

    [GlobalSetup]
    public void Setup()
    {
        first = _random.Next(1, 1000);
        second = _random.Next(1, 1000);
        last = _random.Next(1, 1000);
    }

    [Benchmark]
    public int FirstNum()
        => _solution.MinimumSum(first);

    [Benchmark]
    public int SecondNum()
        => _solution.MinimumSum(second);

    [Benchmark]
    public int LastNum()
        => _solution.MinimumSum(last);
}