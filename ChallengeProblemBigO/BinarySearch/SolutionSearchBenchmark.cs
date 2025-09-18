using BenchmarkDotNet.Attributes;
using ChallengeProblemSolution.BinarySearch;

namespace ChallengeProblemBigO.BinarySearch;

[MemoryDiagnoser]
[ShortRunJob]
public class SolutionSearchBenchmark
{
    private readonly ProblemSearch _solution = new ProblemSearch();
    private Random _next = new Random();

    private int[] smallArray;
    private int[] middArray;
    private int[] largeArray;

    private int smallTarget;
    private int midTarget;
    private int largeTarget;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = Enumerable.Range(1, 10).ToArray();
        smallTarget = _next.Next(1, 10);

        middArray = Enumerable.Range(1, 1_000).ToArray();
        midTarget = _next.Next(1, 1_000);

        largeArray = Enumerable.Range(1, 10_000).ToArray();
        largeTarget = _next.Next(1, 10_000);
    }

    [Benchmark]
    public int SmallArray()
        => _solution.Search(smallArray, smallTarget);

    [Benchmark]
    public int MiddleArray()
        => _solution.Search(middArray, midTarget);

    [Benchmark]
    public int LargeArray()
        => _solution.Search(largeArray, largeTarget);
}