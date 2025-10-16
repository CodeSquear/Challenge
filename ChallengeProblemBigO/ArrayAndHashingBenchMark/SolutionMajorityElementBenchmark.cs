using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.ArrayAndHashing;

namespace ChallengeProblemBigO.ArrayAndHashingBenchMark;

[ShortRunJob]
[MemoryDiagnoser]
public class SolutionMajorityElementBenchmark
{
    private readonly SolutionMajorityElement _solution
        = new SolutionMajorityElement();
    private readonly Random _random 
        = new Random();

    private int[] smallArray;
    private int[] middleArray;
    private int[] largeArray;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = GenerateRandomNumbers(10);
        middleArray = GenerateRandomNumbers(1_000);
        largeArray = GenerateRandomNumbers(10_000);
    }

    private int[] GenerateRandomNumbers(int size)
        => Enumerable.Range(0, size)
            .Select(_ => _random.Next(0, 10))
            .ToArray();

    [Benchmark]
    public void TestSmallArray() => _solution.MajorityElement(smallArray);

    [Benchmark]
    public void TestMiddleArray() => _solution.MajorityElement(middleArray);

    [Benchmark]
    public void TestLargeArray() => _solution.MajorityElement(largeArray);
}