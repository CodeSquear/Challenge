using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.Math;

namespace ChallengeProblemBigO.Math;

[MemoryDiagnoser]
[ShortRunJob]
public class SolutionAddDigitsBenchmark
{
    private readonly SolutionAddDigits _solution 
        = new SolutionAddDigits();

    private readonly Random _random = new Random();

    private int smallNumber;
    private int middleNumber;
    private int bigNumber;

    [GlobalSetup]
    public void Setup()
    {
        smallNumber = _random.Next(1, 10);
        middleNumber = _random.Next(1, 1_000);
        bigNumber = _random.Next(1, 10_000);
    }

    [Benchmark]
    public int SmallNumber() 
        => _solution.AddDigits(smallNumber);

    [Benchmark]
    public int MiddleNumber()
        => _solution.AddDigits(middleNumber);

    [Benchmark]
    public int BigNumber()
        => _solution.AddDigits(bigNumber);
}